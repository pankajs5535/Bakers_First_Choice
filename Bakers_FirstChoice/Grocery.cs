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
    public partial class Grocery : Form
    {
        public Grocery()
        {
            InitializeComponent();
        }

        private void Grocery_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_username.Text = Login.user_name;
                timer_tool.Start();

                this.MinimumSize = new Size(1100, 768); // Example: Minimum size 1100x768
                this.MaximumSize = new Size(1100, 768); // Set the maximum size of the form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during form load: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            try
            {
                Item i = new Item();
                this.Hide();
                i.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Item form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_products_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                this.Hide();
                p.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Product form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error opening Welcome form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Welcome form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
