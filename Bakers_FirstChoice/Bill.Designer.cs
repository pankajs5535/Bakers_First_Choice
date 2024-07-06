
namespace Bakers_FirstChoice
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.listBox_product = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_items = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cust_name = new System.Windows.Forms.TextBox();
            this.lbl_cust_name = new System.Windows.Forms.Label();
            this.txt_cust_phone = new System.Windows.Forms.TextBox();
            this.lbl_cust_email = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_print_bill = new System.Windows.Forms.Button();
            this.btn_privious = new System.Windows.Forms.Button();
            this.btn_generate_bill = new System.Windows.Forms.Button();
            this.dtp_cust_add = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cust_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listview_product = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_unit_values = new System.Windows.Forms.TextBox();
            this.btn_add_to_lv = new System.Windows.Forms.Button();
            this.btn_remove_to_lv = new System.Windows.Forms.Button();
            this.lbl_grand_total = new System.Windows.Forms.Label();
            this.lbl_print_grand_total = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.lbl_head = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_product
            // 
            this.listBox_product.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_product.FormattingEnabled = true;
            this.listBox_product.ItemHeight = 21;
            this.listBox_product.Location = new System.Drawing.Point(122, 219);
            this.listBox_product.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_product.Name = "listBox_product";
            this.listBox_product.Size = new System.Drawing.Size(181, 193);
            this.listBox_product.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product";
            // 
            // comboBox_items
            // 
            this.comboBox_items.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_items.FormattingEnabled = true;
            this.comboBox_items.Location = new System.Drawing.Point(122, 161);
            this.comboBox_items.Name = "comboBox_items";
            this.comboBox_items.Size = new System.Drawing.Size(181, 29);
            this.comboBox_items.TabIndex = 20;
            this.comboBox_items.SelectedIndexChanged += new System.EventHandler(this.comboBox_items_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Item";
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_name.Location = new System.Drawing.Point(127, 45);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Size = new System.Drawing.Size(251, 29);
            this.txt_cust_name.TabIndex = 26;
            // 
            // lbl_cust_name
            // 
            this.lbl_cust_name.AutoSize = true;
            this.lbl_cust_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cust_name.Location = new System.Drawing.Point(52, 48);
            this.lbl_cust_name.Name = "lbl_cust_name";
            this.lbl_cust_name.Size = new System.Drawing.Size(53, 21);
            this.lbl_cust_name.TabIndex = 27;
            this.lbl_cust_name.Text = "Name";
            // 
            // txt_cust_phone
            // 
            this.txt_cust_phone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_phone.Location = new System.Drawing.Point(127, 80);
            this.txt_cust_phone.Name = "txt_cust_phone";
            this.txt_cust_phone.Size = new System.Drawing.Size(251, 29);
            this.txt_cust_phone.TabIndex = 28;
            this.txt_cust_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_phone_KeyPress);
            // 
            // lbl_cust_email
            // 
            this.lbl_cust_email.AutoSize = true;
            this.lbl_cust_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cust_email.Location = new System.Drawing.Point(52, 83);
            this.lbl_cust_email.Name = "lbl_cust_email";
            this.lbl_cust_email.Size = new System.Drawing.Size(57, 21);
            this.lbl_cust_email.TabIndex = 29;
            this.lbl_cust_email.Text = "Phone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_print_bill);
            this.groupBox1.Controls.Add(this.btn_privious);
            this.groupBox1.Controls.Add(this.btn_generate_bill);
            this.groupBox1.Controls.Add(this.dtp_cust_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_cust_email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cust_name);
            this.groupBox1.Controls.Add(this.txt_cust_phone);
            this.groupBox1.Controls.Add(this.lbl_cust_name);
            this.groupBox1.Controls.Add(this.lbl_cust_email);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 266);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Bill";
            // 
            // btn_print_bill
            // 
            this.btn_print_bill.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_bill.Location = new System.Drawing.Point(375, 207);
            this.btn_print_bill.Name = "btn_print_bill";
            this.btn_print_bill.Size = new System.Drawing.Size(74, 31);
            this.btn_print_bill.TabIndex = 36;
            this.btn_print_bill.Text = "Print";
            this.btn_print_bill.UseVisualStyleBackColor = true;
            this.btn_print_bill.Click += new System.EventHandler(this.btn_print_bill_Click);
            // 
            // btn_privious
            // 
            this.btn_privious.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_privious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_privious.Location = new System.Drawing.Point(201, 207);
            this.btn_privious.Name = "btn_privious";
            this.btn_privious.Size = new System.Drawing.Size(168, 31);
            this.btn_privious.TabIndex = 35;
            this.btn_privious.Text = "Privious Window";
            this.btn_privious.UseVisualStyleBackColor = true;
            this.btn_privious.Click += new System.EventHandler(this.btn_privious_Click);
            // 
            // btn_generate_bill
            // 
            this.btn_generate_bill.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate_bill.Location = new System.Drawing.Point(56, 207);
            this.btn_generate_bill.Name = "btn_generate_bill";
            this.btn_generate_bill.Size = new System.Drawing.Size(139, 31);
            this.btn_generate_bill.TabIndex = 34;
            this.btn_generate_bill.Text = "Generate Bill";
            this.btn_generate_bill.UseVisualStyleBackColor = true;
            this.btn_generate_bill.Click += new System.EventHandler(this.btn_generate_bill_Click);
            // 
            // dtp_cust_add
            // 
            this.dtp_cust_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_cust_add.Location = new System.Drawing.Point(127, 150);
            this.dtp_cust_add.Name = "dtp_cust_add";
            this.dtp_cust_add.Size = new System.Drawing.Size(200, 29);
            this.dtp_cust_add.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Date";
            // 
            // txt_cust_email
            // 
            this.txt_cust_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_email.Location = new System.Drawing.Point(127, 115);
            this.txt_cust_email.Name = "txt_cust_email";
            this.txt_cust_email.Size = new System.Drawing.Size(251, 29);
            this.txt_cust_email.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email";
            // 
            // listview_product
            // 
            this.listview_product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listview_product.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview_product.HideSelection = false;
            this.listview_product.Location = new System.Drawing.Point(428, 162);
            this.listview_product.Name = "listview_product";
            this.listview_product.Size = new System.Drawing.Size(525, 250);
            this.listview_product.TabIndex = 31;
            this.listview_product.UseCompatibleStateImageBehavior = false;
            this.listview_product.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Price";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 103;
            // 
            // txt_unit_values
            // 
            this.txt_unit_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit_values.Location = new System.Drawing.Point(337, 254);
            this.txt_unit_values.Name = "txt_unit_values";
            this.txt_unit_values.Size = new System.Drawing.Size(43, 35);
            this.txt_unit_values.TabIndex = 32;
            this.txt_unit_values.Text = "1";
            this.txt_unit_values.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add_to_lv
            // 
            this.btn_add_to_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_to_lv.Location = new System.Drawing.Point(337, 306);
            this.btn_add_to_lv.Name = "btn_add_to_lv";
            this.btn_add_to_lv.Size = new System.Drawing.Size(43, 35);
            this.btn_add_to_lv.TabIndex = 33;
            this.btn_add_to_lv.Text = ">>";
            this.btn_add_to_lv.UseVisualStyleBackColor = true;
            this.btn_add_to_lv.Click += new System.EventHandler(this.btn_add_to_lv_Click);
            // 
            // btn_remove_to_lv
            // 
            this.btn_remove_to_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_to_lv.Location = new System.Drawing.Point(337, 357);
            this.btn_remove_to_lv.Name = "btn_remove_to_lv";
            this.btn_remove_to_lv.Size = new System.Drawing.Size(43, 35);
            this.btn_remove_to_lv.TabIndex = 34;
            this.btn_remove_to_lv.Text = "<<";
            this.btn_remove_to_lv.UseVisualStyleBackColor = true;
            this.btn_remove_to_lv.Click += new System.EventHandler(this.btn_remove_to_lv_Click);
            // 
            // lbl_grand_total
            // 
            this.lbl_grand_total.AutoSize = true;
            this.lbl_grand_total.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grand_total.Location = new System.Drawing.Point(570, 449);
            this.lbl_grand_total.Name = "lbl_grand_total";
            this.lbl_grand_total.Size = new System.Drawing.Size(100, 21);
            this.lbl_grand_total.TabIndex = 35;
            this.lbl_grand_total.Text = "Grand Total";
            // 
            // lbl_print_grand_total
            // 
            this.lbl_print_grand_total.AutoSize = true;
            this.lbl_print_grand_total.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_print_grand_total.Location = new System.Drawing.Point(746, 449);
            this.lbl_print_grand_total.Name = "lbl_print_grand_total";
            this.lbl_print_grand_total.Size = new System.Drawing.Size(21, 21);
            this.lbl_print_grand_total.TabIndex = 36;
            this.lbl_print_grand_total.Text = "/-";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(792, 29);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 23);
            this.lbl_username.TabIndex = 37;
            this.lbl_username.Text = "User Name";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(792, 69);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 23);
            this.lbl_timer.TabIndex = 38;
            this.lbl_timer.Text = "Timer";
            // 
            // timer_tool
            // 
            this.timer_tool.Tick += new System.EventHandler(this.timer_tool_Tick);
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(335, 18);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(414, 64);
            this.lbl_head.TabIndex = 24;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(340, 229);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(40, 22);
            this.lbl_qty.TabIndex = 39;
            this.lbl_qty.Text = "Qty";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_print_grand_total);
            this.Controls.Add(this.lbl_grand_total);
            this.Controls.Add(this.btn_remove_to_lv);
            this.Controls.Add(this.btn_add_to_lv);
            this.Controls.Add(this.txt_unit_values);
            this.Controls.Add(this.listview_product);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_head);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_items);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cust_name;
        private System.Windows.Forms.Label lbl_cust_name;
        private System.Windows.Forms.TextBox txt_cust_phone;
        private System.Windows.Forms.Label lbl_cust_email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cust_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_cust_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listview_product;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_generate_bill;
        private System.Windows.Forms.TextBox txt_unit_values;
        private System.Windows.Forms.Button btn_add_to_lv;
        private System.Windows.Forms.Button btn_remove_to_lv;
        private System.Windows.Forms.Label lbl_grand_total;
        private System.Windows.Forms.Label lbl_print_grand_total;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer timer_tool;
        private System.Windows.Forms.Button btn_privious;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Button btn_print_bill;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}