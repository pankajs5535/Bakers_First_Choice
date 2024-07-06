
namespace Bakers_FirstChoice
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_head = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.groupBox_toolkit = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_security = new System.Windows.Forms.Button();
            this.btn_grocery = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox_toolkit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_tool
            // 
            this.timer_tool.Tick += new System.EventHandler(this.timer_tool_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(793, 101);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 23);
            this.lbl_timer.TabIndex = 14;
            this.lbl_timer.Text = "Timer";
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(335, 27);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(414, 64);
            this.lbl_head.TabIndex = 13;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Old English Text MT", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(341, 101);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(403, 33);
            this.lbl_welcome.TabIndex = 15;
            this.lbl_welcome.Text = "Welcome To Bakers First Choice";
            // 
            // groupBox_toolkit
            // 
            this.groupBox_toolkit.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_toolkit.Controls.Add(this.pictureBox1);
            this.groupBox_toolkit.Controls.Add(this.btn_customer);
            this.groupBox_toolkit.Controls.Add(this.btn_cancel);
            this.groupBox_toolkit.Controls.Add(this.btn_bill);
            this.groupBox_toolkit.Controls.Add(this.btn_security);
            this.groupBox_toolkit.Controls.Add(this.btn_grocery);
            this.groupBox_toolkit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_toolkit.Location = new System.Drawing.Point(191, 245);
            this.groupBox_toolkit.Name = "groupBox_toolkit";
            this.groupBox_toolkit.Size = new System.Drawing.Size(752, 363);
            this.groupBox_toolkit.TabIndex = 18;
            this.groupBox_toolkit.TabStop = false;
            this.groupBox_toolkit.Text = "Welcome to Backeres";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // btn_customer
            // 
            this.btn_customer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(438, 168);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(209, 35);
            this.btn_customer.TabIndex = 14;
            this.btn_customer.Text = "Customer Info";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(438, 288);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(209, 35);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Location = new System.Drawing.Point(438, 228);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(209, 35);
            this.btn_bill.TabIndex = 12;
            this.btn_bill.Text = "Bill";
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_security
            // 
            this.btn_security.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_security.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_security.Location = new System.Drawing.Point(438, 108);
            this.btn_security.Name = "btn_security";
            this.btn_security.Size = new System.Drawing.Size(209, 35);
            this.btn_security.TabIndex = 11;
            this.btn_security.Text = "About Security";
            this.btn_security.UseVisualStyleBackColor = true;
            this.btn_security.Click += new System.EventHandler(this.btn_security_Click);
            // 
            // btn_grocery
            // 
            this.btn_grocery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btn_grocery.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_grocery.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grocery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.btn_grocery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grocery.Location = new System.Drawing.Point(438, 48);
            this.btn_grocery.Name = "btn_grocery";
            this.btn_grocery.Size = new System.Drawing.Size(209, 35);
            this.btn_grocery.TabIndex = 10;
            this.btn_grocery.Text = "Grocery";
            this.btn_grocery.UseVisualStyleBackColor = false;
            this.btn_grocery.Click += new System.EventHandler(this.btn_grocery_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(793, 57);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(109, 23);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "User_Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox_toolkit);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_head);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.groupBox_toolkit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_tool;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.GroupBox groupBox_toolkit;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_security;
        private System.Windows.Forms.Button btn_grocery;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}