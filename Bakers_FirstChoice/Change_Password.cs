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
    public partial class Change_Password : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;

        public Change_Password()
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

        private void Change_Password_Load(object sender, EventArgs e)
        {
            try
            {
                timer_tool.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during form load: " + ex.Message);
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

        private void Passwords_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_new_pass.Text != txt_retype_pass.Text)
                {
                    // If passwords do not match, set an error
                    errorProvider3.SetError(txt_retype_pass, "Passwords do not match!");
                }
                else
                {
                    // Clear the error if passwords match
                    errorProvider3.SetError(txt_retype_pass, "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking passwords: " + ex.Message);
            }
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();
            string currentPassword = txt_current_pass.Text.Trim();
            string newPassword = txt_new_pass.Text.Trim();
            string retypePassword = txt_retype_pass.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txt_email, "Please enter your email.");
                return;
            }
            else
            {
                errorProvider1.SetError(txt_email, ""); // Clear any previous error message
            }

            if (string.IsNullOrEmpty(currentPassword))
            {
                errorProvider2.SetError(txt_current_pass, "Please enter your current password.");
                return;
            }
            else
            {
                errorProvider2.SetError(txt_current_pass, ""); // Clear any previous error message
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                errorProvider3.SetError(txt_new_pass, "Please enter your new password.");
                return;
            }
            else
            {
                errorProvider3.SetError(txt_new_pass, ""); // Clear any previous error message
            }

            if (string.IsNullOrEmpty(retypePassword))
            {
                errorProvider4.SetError(txt_retype_pass, "Please retype your new password.");
                return;
            }
            else if (newPassword != retypePassword)
            {
                errorProvider4.SetError(txt_retype_pass, "New password and retyped password do not match.");
                return;
            }
            else
            {
                errorProvider4.SetError(txt_retype_pass, ""); // Clear any previous error message
            }

            // Confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to update your password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string query = "UPDATE tbl_signup SET password = @new_password WHERE email = @current_email AND password = @current_password";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@new_password", newPassword);
                            cmd.Parameters.AddWithValue("@current_email", email);
                            cmd.Parameters.AddWithValue("@current_password", currentPassword);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Clear text boxes after successful update
                                txt_email.Text = "";
                                txt_current_pass.Text = "";
                                txt_new_pass.Text = "";
                                txt_retype_pass.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Failed to update password. Please check your email and current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
