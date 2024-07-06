using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakers_FirstChoice
{
    public partial class Security : Form
    {
        public Security()
        {
            try
            {
                InitializeComponent();
                timer_tool.Start();

                this.MinimumSize = new Size(1100, 768);
                this.MaximumSize = new Size(1100, 768);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Security_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_username.Text = Login.user_name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_privious_Click(object sender, EventArgs e)
        {
            try
            {
                Welcome g = new Welcome();
                this.Hide();
                g.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_change_email_Click(object sender, EventArgs e)
        {
            try
            {
                Change_Email ce = new Change_Email();
                this.Hide();
                ce.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            try
            {
                Change_Password ce = new Change_Password();
                this.Hide();
                ce.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Welcome g = new Welcome();
                this.Hide();
                g.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
