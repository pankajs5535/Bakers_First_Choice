
namespace Bakers_FirstChoice
{
    partial class Home_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_head = new System.Windows.Forms.Label();
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.lbl_login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_timer.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl_timer.Location = new System.Drawing.Point(678, 40);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 25);
            this.lbl_timer.TabIndex = 14;
            this.lbl_timer.Text = "Timer";
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.BackColor = System.Drawing.Color.Transparent;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl_head.Location = new System.Drawing.Point(263, 74);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(515, 82);
            this.lbl_head.TabIndex = 13;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl_login.Location = new System.Drawing.Point(904, 113);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(68, 28);
            this.lbl_login.TabIndex = 15;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bakers_FirstChoice.Properties.Resources.Loginogo;
            this.pictureBox1.Location = new System.Drawing.Point(848, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_head);
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Page";
            this.Load += new System.EventHandler(this.Home_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Timer timer_tool;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}