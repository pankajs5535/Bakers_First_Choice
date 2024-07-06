
namespace Bakers_FirstChoice
{
    partial class Grocery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grocery));
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_head = new System.Windows.Forms.Label();
            this.groupBox_toolkit = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_privious = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add_products = new System.Windows.Forms.Button();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox_toolkit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(784, 82);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 23);
            this.lbl_timer.TabIndex = 41;
            this.lbl_timer.Text = "Timer";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(784, 49);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 23);
            this.lbl_username.TabIndex = 40;
            this.lbl_username.Text = "User Name";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(335, 29);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(414, 64);
            this.lbl_head.TabIndex = 39;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // groupBox_toolkit
            // 
            this.groupBox_toolkit.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_toolkit.Controls.Add(this.pictureBox1);
            this.groupBox_toolkit.Controls.Add(this.btn_privious);
            this.groupBox_toolkit.Controls.Add(this.btn_cancel);
            this.groupBox_toolkit.Controls.Add(this.btn_add_products);
            this.groupBox_toolkit.Controls.Add(this.btn_add_item);
            this.groupBox_toolkit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_toolkit.Location = new System.Drawing.Point(101, 198);
            this.groupBox_toolkit.Name = "groupBox_toolkit";
            this.groupBox_toolkit.Size = new System.Drawing.Size(752, 363);
            this.groupBox_toolkit.TabIndex = 42;
            this.groupBox_toolkit.TabStop = false;
            this.groupBox_toolkit.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // btn_privious
            // 
            this.btn_privious.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_privious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_privious.Location = new System.Drawing.Point(479, 193);
            this.btn_privious.Name = "btn_privious";
            this.btn_privious.Size = new System.Drawing.Size(209, 35);
            this.btn_privious.TabIndex = 14;
            this.btn_privious.Text = "Privious Window";
            this.btn_privious.UseVisualStyleBackColor = true;
            this.btn_privious.Click += new System.EventHandler(this.btn_privious_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(479, 251);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(209, 35);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add_products
            // 
            this.btn_add_products.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_products.Location = new System.Drawing.Point(479, 135);
            this.btn_add_products.Name = "btn_add_products";
            this.btn_add_products.Size = new System.Drawing.Size(209, 35);
            this.btn_add_products.TabIndex = 11;
            this.btn_add_products.Text = "Add Products";
            this.btn_add_products.UseVisualStyleBackColor = true;
            this.btn_add_products.Click += new System.EventHandler(this.btn_add_products_Click);
            // 
            // btn_add_item
            // 
            this.btn_add_item.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_item.Location = new System.Drawing.Point(479, 77);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(209, 35);
            this.btn_add_item.TabIndex = 10;
            this.btn_add_item.Text = "Add Items";
            this.btn_add_item.UseVisualStyleBackColor = true;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // timer_tool
            // 
            this.timer_tool.Tick += new System.EventHandler(this.timer_tool_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Grocery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox_toolkit);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_head);
            this.Name = "Grocery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "grocery ";
            this.Load += new System.EventHandler(this.Grocery_Load);
            this.groupBox_toolkit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.GroupBox groupBox_toolkit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add_products;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.Timer timer_tool;
        private System.Windows.Forms.Button btn_privious;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}