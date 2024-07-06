
namespace Bakers_FirstChoice
{
    partial class Change_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Email));
            this.lbl_head = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btn_privious = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_new_email = new System.Windows.Forms.TextBox();
            this.lbl_new_email = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_change_email = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(335, 32);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(414, 64);
            this.lbl_head.TabIndex = 48;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btn_privious);
            this.groupBox.Controls.Add(this.pictureBox1);
            this.groupBox.Controls.Add(this.txt_new_email);
            this.groupBox.Controls.Add(this.lbl_new_email);
            this.groupBox.Controls.Add(this.txt_password);
            this.groupBox.Controls.Add(this.btn_change_email);
            this.groupBox.Controls.Add(this.txt_email);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.lbl);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(104, 218);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(724, 354);
            this.groupBox.TabIndex = 51;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Change Email";
            // 
            // btn_privious
            // 
            this.btn_privious.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_privious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_privious.Location = new System.Drawing.Point(536, 270);
            this.btn_privious.Name = "btn_privious";
            this.btn_privious.Size = new System.Drawing.Size(147, 34);
            this.btn_privious.TabIndex = 53;
            this.btn_privious.Text = "Privious Window";
            this.btn_privious.UseVisualStyleBackColor = true;
            this.btn_privious.Click += new System.EventHandler(this.btn_privious_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // txt_new_email
            // 
            this.txt_new_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_email.Location = new System.Drawing.Point(455, 200);
            this.txt_new_email.Name = "txt_new_email";
            this.txt_new_email.Size = new System.Drawing.Size(228, 29);
            this.txt_new_email.TabIndex = 14;
            this.txt_new_email.UseSystemPasswordChar = true;
            this.txt_new_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_new_email_KeyPress);
            // 
            // lbl_new_email
            // 
            this.lbl_new_email.AutoSize = true;
            this.lbl_new_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_email.Location = new System.Drawing.Point(318, 202);
            this.lbl_new_email.Name = "lbl_new_email";
            this.lbl_new_email.Size = new System.Drawing.Size(100, 22);
            this.lbl_new_email.TabIndex = 13;
            this.lbl_new_email.Text = "New Email";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(455, 148);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(228, 29);
            this.txt_password.TabIndex = 12;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btn_change_email
            // 
            this.btn_change_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_change_email.Location = new System.Drawing.Point(383, 270);
            this.btn_change_email.Name = "btn_change_email";
            this.btn_change_email.Size = new System.Drawing.Size(147, 35);
            this.btn_change_email.TabIndex = 4;
            this.btn_change_email.Text = "Change Email";
            this.btn_change_email.UseVisualStyleBackColor = true;
            this.btn_change_email.Click += new System.EventHandler(this.btn_change_email_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(455, 96);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(228, 29);
            this.txt_email.TabIndex = 0;
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(318, 98);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(58, 22);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Email";
            // 
            // timer_tool
            // 
            this.timer_tool.Tick += new System.EventHandler(this.timer_tool_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(793, 73);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 23);
            this.lbl_timer.TabIndex = 53;
            this.lbl_timer.Text = "Timer";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(793, 43);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 23);
            this.lbl_username.TabIndex = 52;
            this.lbl_username.Text = "User Name";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Change_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lbl_head);
            this.Name = "Change_Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Emaol";
            this.Load += new System.EventHandler(this.Change_Email_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txt_new_email;
        private System.Windows.Forms.Label lbl_new_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_change_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Timer timer_tool;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_privious;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}