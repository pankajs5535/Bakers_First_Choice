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

    public partial class Change_Email : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;

        public Change_Email()
        {
            InitializeComponent();
            lbl_username.Text = Login.user_name;

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

        private void btn_change_email_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();
            string password = txt_password.Text.Trim();
            string new_email = txt_new_email.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txt_email, "Please enter your current email.");
                return;
            }
            else
            {
                errorProvider1.SetError(txt_email, ""); // Clear any previous error message
            }

            if (string.IsNullOrEmpty(password))
            {
                errorProvider2.SetError(txt_password, "Please enter your password.");
                return;
            }
            else
            {
                errorProvider2.SetError(txt_password, ""); // Clear any previous error message
            }

            if (string.IsNullOrEmpty(new_email))
            {
                errorProvider3.SetError(txt_new_email, "Please enter your new email.");
                return;
            }
            else
            {
                errorProvider3.SetError(txt_new_email, ""); // Clear any previous error message
            }

            // Confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to update the email address?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string query = "UPDATE tbl_signup SET email = @new_email WHERE email = @current_email AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@new_email", new_email);
                            cmd.Parameters.AddWithValue("@current_email", email);
                            cmd.Parameters.AddWithValue("@password", password);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Email updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Clear text boxes after successful update
                                txt_email.Text = "";
                                txt_password.Text = "";
                                txt_new_email.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Failed to update email. Please check your current email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                MessageBox.Show("Error handling key press: " + ex.Message);
            }
        }

        private void txt_new_email_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Error handling key press: " + ex.Message);
            }
        }

        private void btn_privious_Click(object sender, EventArgs e)
        {
            try
            {
                Security se = new Security();
                this.Hide();
                se.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating to previous form: " + ex.Message);
            }
        }

        private void Change_Email_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Login.user_name;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Security se = new Security();
                this.Hide();
                se.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating to previous form: " + ex.Message);
            }
        }
    }

}
