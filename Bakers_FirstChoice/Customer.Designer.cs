
namespace Bakers_FirstChoice
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_head = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_privious = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dtp_cust_add = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cust_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cust_name = new System.Windows.Forms.TextBox();
            this.txt_cust_phone = new System.Windows.Forms.TextBox();
            this.lbl_cust_name = new System.Windows.Forms.Label();
            this.lbl_cust_email = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search_name = new System.Windows.Forms.Button();
            this.txt_search_by_name = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.dataGridView_CustInfo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_search_Date = new System.Windows.Forms.Button();
            this.dtp_end_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.dtp_start_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_filter_date = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustInfo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lbl_timer.Location = new System.Drawing.Point(791, 78);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 23);
            this.lbl_timer.TabIndex = 47;
            this.lbl_timer.Text = "Timer";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(791, 43);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 23);
            this.lbl_username.TabIndex = 46;
            this.lbl_username.Text = "User Name";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(338, 27);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(414, 64);
            this.lbl_head.TabIndex = 45;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_privious);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.dtp_cust_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_cust_email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cust_name);
            this.groupBox1.Controls.Add(this.txt_cust_phone);
            this.groupBox1.Controls.Add(this.lbl_cust_name);
            this.groupBox1.Controls.Add(this.lbl_cust_email);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 442);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // btn_privious
            // 
            this.btn_privious.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_privious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_privious.Location = new System.Drawing.Point(37, 287);
            this.btn_privious.Name = "btn_privious";
            this.btn_privious.Size = new System.Drawing.Size(169, 40);
            this.btn_privious.TabIndex = 39;
            this.btn_privious.Text = "Privious Window";
            this.btn_privious.UseVisualStyleBackColor = true;
            this.btn_privious.Click += new System.EventHandler(this.btn_privious_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(125, 229);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(81, 40);
            this.btn_update.TabIndex = 38;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(212, 287);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(81, 40);
            this.btn_close.TabIndex = 37;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(37, 229);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 40);
            this.btn_add.TabIndex = 35;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(212, 229);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 40);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dtp_cust_add
            // 
            this.dtp_cust_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_cust_add.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_cust_add.Location = new System.Drawing.Point(108, 176);
            this.dtp_cust_add.Name = "dtp_cust_add";
            this.dtp_cust_add.Size = new System.Drawing.Size(155, 29);
            this.dtp_cust_add.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Date";
            // 
            // txt_cust_email
            // 
            this.txt_cust_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_email.Location = new System.Drawing.Point(108, 132);
            this.txt_cust_email.Name = "txt_cust_email";
            this.txt_cust_email.Size = new System.Drawing.Size(251, 29);
            this.txt_cust_email.TabIndex = 30;
            this.txt_cust_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_email_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email";
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_name.Location = new System.Drawing.Point(108, 50);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Size = new System.Drawing.Size(251, 29);
            this.txt_cust_name.TabIndex = 26;
            this.txt_cust_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_name_KeyPress);
            // 
            // txt_cust_phone
            // 
            this.txt_cust_phone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_phone.Location = new System.Drawing.Point(108, 91);
            this.txt_cust_phone.Name = "txt_cust_phone";
            this.txt_cust_phone.Size = new System.Drawing.Size(251, 29);
            this.txt_cust_phone.TabIndex = 28;
            this.txt_cust_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_phone_KeyPress);
            // 
            // lbl_cust_name
            // 
            this.lbl_cust_name.AutoSize = true;
            this.lbl_cust_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cust_name.Location = new System.Drawing.Point(33, 53);
            this.lbl_cust_name.Name = "lbl_cust_name";
            this.lbl_cust_name.Size = new System.Drawing.Size(58, 22);
            this.lbl_cust_name.TabIndex = 27;
            this.lbl_cust_name.Text = "Name";
            // 
            // lbl_cust_email
            // 
            this.lbl_cust_email.AutoSize = true;
            this.lbl_cust_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cust_email.Location = new System.Drawing.Point(33, 94);
            this.lbl_cust_email.Name = "lbl_cust_email";
            this.lbl_cust_email.Size = new System.Drawing.Size(61, 22);
            this.lbl_cust_email.TabIndex = 29;
            this.lbl_cust_email.Text = "Phone";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_search_name);
            this.panel2.Controls.Add(this.txt_search_by_name);
            this.panel2.Controls.Add(this.lbl_search);
            this.panel2.Location = new System.Drawing.Point(414, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 51);
            this.panel2.TabIndex = 51;
            // 
            // btn_search_name
            // 
            this.btn_search_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_name.BackgroundImage")));
            this.btn_search_name.Location = new System.Drawing.Point(269, 1);
            this.btn_search_name.Name = "btn_search_name";
            this.btn_search_name.Size = new System.Drawing.Size(52, 50);
            this.btn_search_name.TabIndex = 23;
            this.btn_search_name.UseVisualStyleBackColor = true;
            this.btn_search_name.Click += new System.EventHandler(this.btn_search_name_Click);
            // 
            // txt_search_by_name
            // 
            this.txt_search_by_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_by_name.Location = new System.Drawing.Point(75, 11);
            this.txt_search_by_name.Name = "txt_search_by_name";
            this.txt_search_by_name.Size = new System.Drawing.Size(183, 29);
            this.txt_search_by_name.TabIndex = 22;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(3, 14);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(66, 20);
            this.lbl_search.TabIndex = 21;
            this.lbl_search.Text = "Search";
            // 
            // dataGridView_CustInfo
            // 
            this.dataGridView_CustInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CustInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CustInfo.Location = new System.Drawing.Point(414, 310);
            this.dataGridView_CustInfo.Name = "dataGridView_CustInfo";
            this.dataGridView_CustInfo.RowHeadersWidth = 51;
            this.dataGridView_CustInfo.Size = new System.Drawing.Size(634, 326);
            this.dataGridView_CustInfo.TabIndex = 49;
            this.dataGridView_CustInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_CustInfo_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_search_Date);
            this.panel3.Controls.Add(this.dtp_end_date);
            this.panel3.Controls.Add(this.lbl_to);
            this.panel3.Controls.Add(this.lbl_from);
            this.panel3.Controls.Add(this.dtp_start_date);
            this.panel3.Controls.Add(this.lbl_filter_date);
            this.panel3.Location = new System.Drawing.Point(414, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 50);
            this.panel3.TabIndex = 52;
            // 
            // btn_search_Date
            // 
            this.btn_search_Date.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_Date.BackgroundImage")));
            this.btn_search_Date.Location = new System.Drawing.Point(458, 3);
            this.btn_search_Date.Name = "btn_search_Date";
            this.btn_search_Date.Size = new System.Drawing.Size(47, 47);
            this.btn_search_Date.TabIndex = 24;
            this.btn_search_Date.UseVisualStyleBackColor = true;
            this.btn_search_Date.Click += new System.EventHandler(this.btn_search_Date_Click);
            // 
            // dtp_end_date
            // 
            this.dtp_end_date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end_date.Location = new System.Drawing.Point(344, 17);
            this.dtp_end_date.Name = "dtp_end_date";
            this.dtp_end_date.Size = new System.Drawing.Size(108, 29);
            this.dtp_end_date.TabIndex = 43;
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(309, 20);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(29, 20);
            this.lbl_to.TabIndex = 42;
            this.lbl_to.Text = "To";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.Location = new System.Drawing.Point(131, 20);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(50, 20);
            this.lbl_from.TabIndex = 41;
            this.lbl_from.Text = "From";
            // 
            // dtp_start_date
            // 
            this.dtp_start_date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start_date.Location = new System.Drawing.Point(189, 17);
            this.dtp_start_date.Name = "dtp_start_date";
            this.dtp_start_date.Size = new System.Drawing.Size(108, 29);
            this.dtp_start_date.TabIndex = 40;
            // 
            // lbl_filter_date
            // 
            this.lbl_filter_date.AutoSize = true;
            this.lbl_filter_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filter_date.Location = new System.Drawing.Point(3, 20);
            this.lbl_filter_date.Name = "lbl_filter_date";
            this.lbl_filter_date.Size = new System.Drawing.Size(132, 20);
            this.lbl_filter_date.TabIndex = 21;
            this.lbl_filter_date.Text = "Filter by Date : ";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_CustInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_head);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_tool;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_cust_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cust_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cust_name;
        private System.Windows.Forms.TextBox txt_cust_phone;
        private System.Windows.Forms.Label lbl_cust_name;
        private System.Windows.Forms.Label lbl_cust_email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search_name;
        private System.Windows.Forms.TextBox txt_search_by_name;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.DataGridView dataGridView_CustInfo;
        private System.Windows.Forms.Button btn_privious;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtp_end_date;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.DateTimePicker dtp_start_date;
        private System.Windows.Forms.Label lbl_filter_date;
        private System.Windows.Forms.Button btn_search_Date;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}