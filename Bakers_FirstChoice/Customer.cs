using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Bakers_FirstChoice
{
    public partial class Customer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter sda;

        public Customer()
        {
            InitializeComponent();
            timer_tool.Start();

            this.MinimumSize = new Size(1100, 768); // Example: Minimum size 800x600
            this.MaximumSize = new Size(1100, 768); // Set the maximum size of the form
        }

        private void timer_tool_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                lbl_timer.Text = dt.ToString("dd/MM/yyyy hh:mm:ss tt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on timer tick: " + ex.Message);
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_username.Text = Login.user_name;
                BindGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during form load: " + ex.Message);
            }
        }

        private void txt_cust_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Char ch = e.KeyChar;
                if (Char.IsLetter(ch) || ch == 8) // Allow letters and Backspace key
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error handling key press: " + ex.Message);
            }
        }

        private void txt_cust_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;
                Char ch = e.KeyChar;

                if ((Char.IsDigit(ch) && textBox.Text.Length < 10) || Char.IsControl(ch) || ch == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error handling key press: " + ex.Message);
            }
        }

        private void txt_cust_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Char ch = e.KeyChar;

                // Allow letters
                if (Char.IsLetter(ch) || Char.IsDigit(ch) || Char.IsControl(ch) || ch == '@' || ch == '.' || ch == '_' || ch == '-')
                {
                    e.Handled = false;
                }
                // Disallow all other characters
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error handling key press: " + ex.Message);
            }
        }

        private void BindGridView()
        {
            try
            {
                con = new SqlConnection(cs);
                string query1 = "select id,name,phone,email, bdate from tbl_customer";
                sda = new SqlDataAdapter(query1, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_CustInfo.DataSource = dt;

                // Hide the ID column
                dataGridView_CustInfo.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error binding GridView: " + ex.Message);
            }
        }

        private void btn_privious_Click(object sender, EventArgs e)
        {
            try
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating to previous form: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_cust_name.Text))
                {
                    txt_cust_name.Focus();
                    errorProvider1.SetError(this.txt_cust_name, "Please enter the Name");
                }
                else if (string.IsNullOrEmpty(txt_cust_phone.Text))
                {
                    errorProvider2.SetError(this.txt_cust_phone, "Please enter the Phone");
                }
                else if (string.IsNullOrEmpty(txt_cust_email.Text))
                {
                    errorProvider3.SetError(this.txt_cust_email, "Please enter the Email");
                }
                else
                {
                    using (con = new SqlConnection(cs))
                    {
                        // Check if the email already exists
                        string query1 = "select count(*) from tbl_customer where email = @Email";
                        using (SqlCommand checkEmailCmd = new SqlCommand(query1, con))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@Email", txt_cust_email.Text);
                            con.Open();
                            int count = (int)checkEmailCmd.ExecuteScalar();
                            con.Close();

                            if (count > 0)
                            {
                                MessageBox.Show("The email " + txt_cust_email.Text + " is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Insert the new customer
                                string query2 = "insert into tbl_customer (name,phone,email, bdate) values (@Name, @Phone, @Email, @Dtp_cust_add)";
                                using (SqlCommand insertCmd = new SqlCommand(query2, con))
                                {
                                    insertCmd.Parameters.AddWithValue("@Name", txt_cust_name.Text);
                                    insertCmd.Parameters.AddWithValue("@Phone", txt_cust_phone.Text);
                                    insertCmd.Parameters.AddWithValue("@Email", txt_cust_email.Text);
                                    insertCmd.Parameters.AddWithValue("@Dtp_cust_add", dtp_cust_add.Text);

                                    con.Open();
                                    int result = insertCmd.ExecuteNonQuery();
                                    con.Close();

                                    if (result > 0)
                                    {
                                        MessageBox.Show("Customer Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        BindGridView();

                                        // Clear text boxes and error providers after successful update
                                        txt_cust_name.Clear();
                                        txt_cust_phone.Clear();
                                        txt_cust_email.Clear();
                                        dtp_cust_add.Value = DateTime.Now;

                                        errorProvider1.SetError(txt_cust_name, "");
                                        errorProvider2.SetError(txt_cust_phone, "");
                                        errorProvider3.SetError(txt_cust_email, "");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Customer Record Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_CustInfo.CurrentRow != null)
                {
                    // Confirm the update action 
                    DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Get the current row's ID (hidden column)
                        int customerID = Convert.ToInt32(dataGridView_CustInfo.CurrentRow.Cells["id"].Value);
                        string name = txt_cust_name.Text;
                        string phone = txt_cust_phone.Text;
                        string email = txt_cust_email.Text;
                        DateTime bdate = dtp_cust_add.Value;

                        // Update the record in the database
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string query = "update tbl_customer set name = @Name, phone = @Phone, email = @Email, bdate = @Bdate where id = @Id";
                            using (cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Id", customerID);
                                cmd.Parameters.AddWithValue("@Name", name);
                                cmd.Parameters.AddWithValue("@Phone", phone);
                                cmd.Parameters.AddWithValue("@Email", email);
                                cmd.Parameters.AddWithValue("@Bdate", bdate);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Refresh the GridView data
                        BindGridView();

                        // Optionally, clear the input fields
                        txt_cust_name.Clear();
                        txt_cust_phone.Clear();
                        txt_cust_email.Clear();
                        dtp_cust_add.Value = DateTime.Now;

                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_CustInfo.CurrentRow != null)
                {
                    // Confirm the delete action
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Get the current row's ID (hidden column)
                        int customerID = Convert.ToInt32(dataGridView_CustInfo.CurrentRow.Cells["id"].Value);

                        // Delete the record from the database
                        using (con = new SqlConnection(cs))
                        {
                            con.Open();
                            string query = "delete from tbl_customer where id = @Id";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Id", customerID);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Refresh the GridView data
                        BindGridView();

                        // Optionally, clear the input fields if the deleted record was selected
                        txt_cust_name.Clear();
                        txt_cust_phone.Clear();
                        txt_cust_email.Clear();
                        dtp_cust_add.Value = DateTime.Now;

                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing form: " + ex.Message);
            }
        }

        private void dataGridView_CustInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView_CustInfo.SelectedRows.Count > 0)
                {
                    txt_cust_name.Text = dataGridView_CustInfo.SelectedRows[0].Cells["name"].Value.ToString();
                    txt_cust_phone.Text = dataGridView_CustInfo.SelectedRows[0].Cells["phone"].Value.ToString();
                    txt_cust_email.Text = dataGridView_CustInfo.SelectedRows[0].Cells["email"].Value.ToString();
                    dtp_cust_add.Value = Convert.ToDateTime(dataGridView_CustInfo.SelectedRows[0].Cells["bdate"].Value);
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during row double click: " + ex.Message);
            }
        }

        private void btn_search_name_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select id,name,phone,email, bdate FROM tbl_customer where name like @name + '%'";
                using (sda = new SqlDataAdapter(query, con))
                {
                    sda.SelectCommand.Parameters.AddWithValue("@name", txt_search_by_name.Text.Trim());

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView_CustInfo.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView_CustInfo.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search by name: " + ex.Message);
            }
        }

        // Searching by Date
        private void SearchDataByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    string query = "SELECT id, name, phone, email, bdate FROM tbl_customer WHERE bdate BETWEEN @StartDate AND @EndDate";
                    sda = new SqlDataAdapter(query, cs);
                    sda.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                    sda.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView_CustInfo.DataSource = dataTable;
                    dataGridView_CustInfo.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching by date range: " + ex.Message);
            }
        }

        private void btn_search_Date_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtp_start_date.Value.Date;
                DateTime endDate = dtp_end_date.Value.Date.AddDays(1).AddTicks(-1); // To include all records from the end date
                SearchDataByDateRange(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during date search: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating to previous form: " + ex.Message);
            }
        }
    }

}
