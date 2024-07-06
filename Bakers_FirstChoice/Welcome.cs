using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakers_FirstChoice
{
    public partial class Welcome : Form
    { 
        public Welcome()
        {
            InitializeComponent();
 
            lbl_username.Text = Login.user_name;

            //lbl_fname.Text = Form1.text1;

            timer_tool.Start();

            this.MinimumSize = new Size(1100, 768); // Example: Minimum size 800x600

            // Set the maximum size of the form
            this.MaximumSize = new Size(1100, 768);

        }

        private void timer_tool_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_timer.Text = dt.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private async Task BlinkLabelAsync(Label label, Color color1, Color color2, Color color3, int cycleTimeMs)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            while (!cancellationToken.IsCancellationRequested)
            {
                label.ForeColor = color1;
                await Task.Delay(cycleTimeMs, cancellationToken);

                label.ForeColor = color2;
                await Task.Delay(cycleTimeMs, cancellationToken);

                label.ForeColor = color3;
                await Task.Delay(cycleTimeMs, cancellationToken);
            }
        }


        private async void Welcome_Load(object sender, EventArgs e)
        {

            lbl_username.Text = Login.user_name;

            // Start the blinking animation with three colors
            await BlinkLabelAsync(lbl_welcome, Color.Red, Color.Blue, Color.Green, 500);

        }

        private void btn_grocery_Click(object sender, EventArgs e)
        {
            Grocery g = new Grocery();
            this.Hide();
            g.Show();

        }


        private void btn_security_Click(object sender, EventArgs e)
        {
            Security s = new Security();
            this.Hide();
            s.Show();
        }
        private void btn_customer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            this.Hide();
            c.Show();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            Bill bl = new Bill();
            this.Hide();
            bl.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
