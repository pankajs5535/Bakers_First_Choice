
namespace Bakers_FirstChoice
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_head = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.groupbox_login = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_nevigation_signup = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupbox_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(335, 51);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(414, 64);
            this.lbl_head.TabIndex = 2;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(764, 74);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 23);
            this.lbl_timer.TabIndex = 12;
            this.lbl_timer.Text = "Timer";
            // 
            // groupbox_login
            // 
            this.groupbox_login.Controls.Add(this.pictureBox1);
            this.groupbox_login.Controls.Add(this.txt_password);
            this.groupbox_login.Controls.Add(this.lbl_nevigation_signup);
            this.groupbox_login.Controls.Add(this.btn_login);
            this.groupbox_login.Controls.Add(this.chkPassword);
            this.groupbox_login.Controls.Add(this.txt_email);
            this.groupbox_login.Controls.Add(this.label2);
            this.groupbox_login.Controls.Add(this.lbl);
            this.groupbox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_login.Location = new System.Drawing.Point(220, 231);
            this.groupbox_login.Name = "groupbox_login";
            this.groupbox_login.Size = new System.Drawing.Size(714, 343);
            this.groupbox_login.TabIndex = 11;
            this.groupbox_login.TabStop = false;
            this.groupbox_login.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(412, 115);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(228, 26);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_nevigation_signup
            // 
            this.lbl_nevigation_signup.AutoSize = true;
            this.lbl_nevigation_signup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nevigation_signup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_nevigation_signup.Location = new System.Drawing.Point(408, 219);
            this.lbl_nevigation_signup.Name = "lbl_nevigation_signup";
            this.lbl_nevigation_signup.Size = new System.Drawing.Size(162, 21);
            this.lbl_nevigation_signup.TabIndex = 3;
            this.lbl_nevigation_signup.Text = "Click here to Signup";
            this.lbl_nevigation_signup.Click += new System.EventHandler(this.lbl_nevigation_signup_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(316, 262);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(324, 35);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPassword.Location = new System.Drawing.Point(412, 165);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(151, 25);
            this.chkPassword.TabIndex = 2;
            this.chkPassword.Text = "Show Password";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(412, 68);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(228, 29);
            this.txt_email.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(312, 71);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(58, 22);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Email";
            // 
            // timer_tool
            // 
            this.timer_tool.Tick += new System.EventHandler(this.timer_tool_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.groupbox_login);
            this.Controls.Add(this.lbl_head);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Signin_Load);
            this.groupbox_login.ResumeLayout(false);
            this.groupbox_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.GroupBox groupbox_login;
        private System.Windows.Forms.Label lbl_nevigation_signup;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Timer timer_tool;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}