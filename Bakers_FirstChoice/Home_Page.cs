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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();

            try
            {
                timer_tool.Interval = 1000; // Set the timer interval to 1 second
                timer_tool.Tick += new EventHandler(timer_tool_Tick); // Attach the event handler
                timer_tool.Start();

                this.MinimumSize = new Size(1100, 768); // Example: Minimum size 1100x768

                // Set the maximum size of the form
                this.MaximumSize = new Size(1100, 768);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during form initialization: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error updating timer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            try
            {
                Login si = new Login();
                this.Hide();
                si.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Login form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            try
            {
                timer_tool.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during form load: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
