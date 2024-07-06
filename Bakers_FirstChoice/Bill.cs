using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakers_FirstChoice
{
    public partial class Bill : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter sda;

        public static string cust_name, cust_phone, cust_email, cust_dtp;

        public Bill()
        {
            InitializeComponent();
            BindComboBoxItems();

            this.MinimumSize = new Size(1100, 768); // Example: Minimum size 800x600
            this.MaximumSize = new Size(1100, 768); // Set the maximum size of the form
        }


        private void Bill_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_username.Text = Login.user_name;
                timer_tool.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load: " + ex.Message);
            }
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


        // Bind ComboBox
        void BindComboBoxItems()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open(); // Open the connection here
                    string select_item = "select * from tbl_item";
                    using (cmd = new SqlCommand(select_item, con))
                    {
                        using (sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                comboBox_items.Items.Add(sdr["item_name"]).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while binding combo box items: " + ex.Message);
            }
        }

        private void comboBox_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open(); // Opening the database connection
                    string select_ItemId = "select Item_Id from tbl_item where Item_Name = @ItemName";
                    cmd = new SqlCommand(select_ItemId, con);
                    cmd.Parameters.AddWithValue("@ItemName", comboBox_items.SelectedItem.ToString());
                    object id = cmd.ExecuteScalar();

                    if (id != null)
                    {
                        string selectProductsQuery = "select Product_Name from tbl_product where item_id = @ItemId";
                        cmd.CommandText = selectProductsQuery;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ItemId", (int)id);

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            listBox_product.Items.Clear();
                            while (rdr.Read())
                            {
                                listBox_product.Items.Add(rdr["product_name"].ToString());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void TotalCalc()
        {
            try
            {
                double sum = 0;
                foreach (ListViewItem l in this.listview_product.Items)
                {
                    sum = sum + Convert.ToInt32(l.SubItems[3].Text);
                }
                lbl_print_grand_total.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_add_to_lv_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_product.SelectedItem == null)
                {
                    MessageBox.Show("First select product to add.");
                }
                else
                {
                    ListViewItem item1 = null;
                    foreach (ListViewItem item in listview_product.Items)
                    {
                        if (Convert.ToString(listBox_product.SelectedItem).Equals(item.Text))
                        {
                            item1 = item;
                        }
                    }
                    if (item1 != null && item1.Text.Length == Convert.ToString(listBox_product.SelectedItem).Length) // already present list view
                    {
                        item1.SubItems[2].Text = (Convert.ToInt32(item1.SubItems[2].Text) + Convert.ToInt32(txt_unit_values.Text)).ToString();
                        item1.SubItems[3].Text = (Convert.ToInt32(item1.SubItems[2].Text) * Convert.ToInt32(item1.SubItems[1].Text)).ToString();
                        txt_unit_values.Text = "" + 1;
                        TotalCalc();
                    }
                    else
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            String ptypequery = "select product_price from tbl_product where product_name = '" + Convert.ToString(listBox_product.SelectedItem) + "'";
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(ptypequery, con))
                            {
                                object anObj = cmd.ExecuteScalar();
                                float rate = (anObj == null ? -1 : Convert.ToInt32(anObj.ToString()));
                                int unit = Convert.ToInt32(txt_unit_values.Text);
                                ListViewItem item = new ListViewItem();
                                item.Text = Convert.ToString(listBox_product.SelectedItem);
                                item.SubItems.Add(rate.ToString());
                                item.SubItems.Add(unit.ToString());
                                item.SubItems.Add((rate * unit).ToString());
                                listview_product.Items.Add(item);
                                txt_unit_values.Text = "" + 1;
                                TotalCalc();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_remove_to_lv_Click(object sender, EventArgs e)
        {
            try
            {
                int scount = listview_product.SelectedItems.Count;

                if (scount != 1)
                {
                    if (scount > 1)
                        MessageBox.Show("Select single Product. Multiple selection not allowed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("First select product to remove !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ListViewItem list_view_item = new ListViewItem();
                    list_view_item = listview_product.SelectedItems[0];

                    if (Convert.ToInt32(list_view_item.SubItems[2].Text) == 1 || Convert.ToInt32(list_view_item.SubItems[2].Text) == Convert.ToInt32(txt_unit_values.Text))
                    {
                        list_view_item.Remove();
                        txt_unit_values.Text = "" + 1;
                        TotalCalc();
                    }
                    else if (Convert.ToInt32(list_view_item.SubItems[2].Text) > Convert.ToInt32(txt_unit_values.Text))
                    {
                        list_view_item.SubItems[2].Text = (Convert.ToInt32(list_view_item.SubItems[2].Text) - Convert.ToInt32(txt_unit_values.Text)).ToString();
                        list_view_item.SubItems[3].Text = (Convert.ToInt32(list_view_item.SubItems[2].Text) * Convert.ToInt32(list_view_item.SubItems[1].Text)).ToString();
                        txt_unit_values.Text = "" + 1;
                        TotalCalc();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txt_cust_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;


                Char ch = e.KeyChar;
                if (Char.IsDigit(ch) == true && textBox.Text.Length < 10 || Char.IsControl(ch))
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         
        private void btn_generate_bill_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txt_cust_name.Text.ToString();
                String phone = txt_cust_phone.Text.ToString();
                String email = txt_cust_email.Text.ToString();
                DateTime dtp = dtp_cust_add.Value;


                cust_name = name;
                cust_phone = phone;
                cust_email = email;
                cust_dtp = dtp.ToString();

                 


                // Validate customer details
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please fill in all customer details.");
                    return;
                }

                if (listview_product.Items.Count == 0)
                {
                    MessageBox.Show("No products to generate bill.");
                    return;
                }


                double grand_total = double.Parse(lbl_print_grand_total.Text);


                // Generate a unique invoice number
                int invoice_number = GenerateInvoiceNumber();

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    // Iterate through ListView items and insert product details along with customer details
                    foreach (ListViewItem item in listview_product.Items)
                    {
                        string product_name = item.Text;
                        string product_price = item.SubItems[1].Text;
                        string product_quantity = item.SubItems[2].Text;

                        string insertBillPrintQuery = "INSERT INTO tbl_bill_print (invoice_number, cust_name, cust_phone, cust_email, cust_dtp, " +
                                                      "product_name, product_quantity, product_price, grant_total) " +
                                                      "VALUES (@InvoiceNumber, @CustomerName, @CustomerPhone, @CustomerEmail, @CustomerDtp, " +
                                                      "@ProductName, @ProductQuantity, @ProductPrice, @GrantTotal)";


                        using (SqlCommand cmd = new SqlCommand(insertBillPrintQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@InvoiceNumber", invoice_number);
                            cmd.Parameters.AddWithValue("@CustomerName", name);
                            cmd.Parameters.AddWithValue("@CustomerPhone", phone);
                            cmd.Parameters.AddWithValue("@CustomerEmail", email);
                            cmd.Parameters.AddWithValue("@CustomerDtp", dtp.ToString());
                            cmd.Parameters.AddWithValue("@ProductName", product_name);
                            cmd.Parameters.AddWithValue("@ProductQuantity", product_quantity);
                            cmd.Parameters.AddWithValue("@ProductPrice", product_price);
                            cmd.Parameters.AddWithValue("@GrantTotal", grand_total.ToString());

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Bill generated and data sent to the database successfully.");

                    // Clear input fields
                    ClearInputFields();
                      
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
              
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Grocery g = new Grocery();
                this.Hide();
                g.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating to previous form: " + ex.Message);
            }
        }

        private void btn_print_bill_Click(object sender, EventArgs e)
        {

        }



        /*private void btn_print_bill_Click(object sender, EventArgs e)
         {
             //new Report.Bill_Print().Show();
             Bill_Print billp = new Bill_Print();
             this.Hide();
             billp.Show();

         }*/

        private int GenerateInvoiceNumber()
        {
            // You can implement your logic here to generate a unique invoice number,
            // such as fetching the last invoice number from the database and incrementing it.
            // For simplicity, let's generate a random number for demonstration purposes.
            Random rnd = new Random();
            return rnd.Next(100000, 999999);
        }
         
        private void ClearInputFields()
        {
            txt_cust_name.Clear();
            txt_cust_phone.Clear();
            txt_cust_email.Clear();
            dtp_cust_add.Value = DateTime.Now;
            listview_product.Items.Clear();
            lbl_print_grand_total.Text = "0";
            //comboBox_items.SelectedIndex = -1;
            listBox_product.Items.Clear();
            txt_unit_values.Text = "1";
        }
         
        private void btn_privious_Click(object sender, EventArgs e)
        {
            try
            {
                Grocery g = new Grocery();
                this.Hide();
                g.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating to previous form: " + ex.Message);
            }
        }
    }

}

