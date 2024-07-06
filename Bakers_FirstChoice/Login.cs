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
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;

        public static string user_name;

        public Login()
        {
            InitializeComponent();

            this.MinimumSize = new Size(1100, 768);
            this.MaximumSize = new Size(1100, 768);
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            try
            {
                timer_tool.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    string query = "select name from tbl_signup where email = @email and password = @password";

                    using (cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@password", txt_password.Text);

                        con.Open();

                        using (sdr = cmd.ExecuteReader())
                        {
                            if (sdr.HasRows)
                            {
                                sdr.Read();
                                string name = sdr["name"].ToString();

                                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();

                                Welcome w = new Welcome();
                                user_name = name;
                                this.Hide();
                                w.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                bool check = chkPassword.Checked;
                txt_password.UseSystemPasswordChar = !check;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_nevigation_signup_Click(object sender, EventArgs e)
        {
            try
            {
                Signup sp = new Signup();
                this.Hide();
                sp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
