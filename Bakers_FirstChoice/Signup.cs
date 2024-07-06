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
    public partial class Signup : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter sda;


        public Signup()
        {
            InitializeComponent();
            timer_tool.Start();
            // Subscribe to the TextChanged event
            this.txt_password.TextChanged += new System.EventHandler(this.Passwords_TextChanged);
            this.txt_confirm_pass.TextChanged += new System.EventHandler(this.Passwords_TextChanged);

            // Initialize the ErrorProvider
            errorProvider6 = new ErrorProvider();

            this.MinimumSize = new Size(1100, 768); // Example: Minimum size 800x600
            this.MaximumSize = new Size(1100, 768);  // Set the maximum size of the form
        }



        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Char ch = e.KeyChar;
                if (Char.IsLetter(ch) == true)
                {
                    e.Handled = false;
                }
                else if (ch == 8)
                {
                    e.Handled = false;
                }
                else if (ch == 32)
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

        private void txt_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Char ch = e.KeyChar;
                if (Char.IsLetter(ch) == true)
                {
                    e.Handled = false;
                }
                else if (ch == 8) //Backspace key
                {
                    e.Handled = false;
                }
                /*else if (ch == 32) //space 
                {
                    e.Handled = false;
                }*/
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

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Char ch = e.KeyChar;

                // Allow letters
                if (Char.IsLetter(ch))
                {
                    e.Handled = false;
                }
                // Allow digits
                else if (Char.IsDigit(ch))
                {
                    e.Handled = false;
                }
                // Allow control keys like Backspace
                else if (Char.IsControl(ch))
                {
                    e.Handled = false;
                }
                // Allow common email characters: '@', '.', '_', and '-'
                else if (ch == '@' || ch == '.' || ch == '_' || ch == '-')
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the input fields
                if (string.IsNullOrEmpty(txt_name.Text))
                {
                    txt_name.Focus();
                    errorProvider1.SetError(this.txt_name, "Please enter the name");
                }
                else if (string.IsNullOrEmpty(txt_surname.Text))
                {
                    errorProvider2.SetError(this.txt_surname, "Please enter the surname");
                }
                else if (string.IsNullOrEmpty(txt_email.Text))
                {
                    errorProvider3.SetError(this.txt_email, "Please enter the email");
                }
                else if (string.IsNullOrEmpty(txt_password.Text))
                {
                    errorProvider4.SetError(this.txt_password, "Please enter the password");
                }
                else if (combo_city.SelectedItem == null)
                {
                    errorProvider5.SetError(this.combo_city, "Please select a city");
                }
                else if (txt_password.Text != txt_confirm_pass.Text)
                {
                    errorProvider6.SetError(txt_confirm_pass, "Passwords do not match!");
                }
                else
                {
                    using (con = new SqlConnection(cs))
                    {
                        // Check if the email already exists
                        string query1 = "select count(*) from tbl_signup where email = @Email";
                        using (SqlCommand checkEmailCmd = new SqlCommand(query1, con))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@Email", txt_email.Text);
                            con.Open();
                            int count = (int)checkEmailCmd.ExecuteScalar();
                            con.Close();

                            if (count > 0)
                            {
                                MessageBox.Show("The email " + txt_email.Text + " is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Insert the new customer
                                // string query2 = "insert into tbl_signup (name, surname, email, password, city) values (@Name, @Surname, @Email, @Password, @City)";

                                string query2 = "insert into tbl_signup (name, surname,gender, email,phone,city,password) values (@Name, @Surname,@Gender, @Email,@Phone, @City, @Password)";

                                using (SqlCommand insertCmd = new SqlCommand(query2, con))
                                {
                                    insertCmd.Parameters.AddWithValue("@Name", txt_name.Text);
                                    insertCmd.Parameters.AddWithValue("@Surname", txt_surname.Text);
                                    string gender = rdo_male.Checked ? "Male" : "Female";
                                    insertCmd.Parameters.AddWithValue("@Gender", gender);
                                    insertCmd.Parameters.AddWithValue("@Email", txt_email.Text);
                                    insertCmd.Parameters.AddWithValue("@Phone", txt_phone.Text);
                                    insertCmd.Parameters.AddWithValue("@City", combo_city.SelectedItem.ToString());
                                    insertCmd.Parameters.AddWithValue("@Password", txt_password.Text);

                                    con.Open();
                                    int result = insertCmd.ExecuteNonQuery();
                                    con.Close();

                                    if (result > 0)
                                    {
                                        MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        MessageBox.Show("Your Email: " + txt_email.Text + "\nYour Password: " + txt_password.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Optionally, redirect to another form (e.g., Login form)
                                        this.Hide();
                                        Login si = new Login();
                                        si.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Registration Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear all the text fields
                txt_name.Text = "";
                txt_surname.Text = "";
                txt_phone.Text = "";
                txt_email.Text = "";
                txt_password.Text = "";

                // Reset the combo box selection
                combo_city.SelectedIndex = -1;

                // Optionally, clear all error providers
                errorProvider1.SetError(txt_name, "");
                errorProvider2.SetError(txt_surname, "");
                errorProvider3.SetError(txt_email, "");
                errorProvider4.SetError(txt_phone, "");
                errorProvider6.SetError(combo_city, "");
                errorProvider5.SetError(txt_password, "");
                errorProvider6.SetError(txt_confirm_pass, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void byn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Passwords_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_password.Text != txt_confirm_pass.Text)
                {
                    // If passwords do not match, set an error
                    errorProvider6.SetError(txt_confirm_pass, "Passwords do not match!");
                }
                else
                {
                    // Clear the error if passwords match
                    errorProvider6.SetError(txt_confirm_pass, "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
