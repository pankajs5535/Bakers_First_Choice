
namespace Bakers_FirstChoice
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.groupBox_Produt = new System.Windows.Forms.GroupBox();
            this.btn_privious = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_items = new System.Windows.Forms.ComboBox();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.listview_product = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_head = new System.Windows.Forms.Label();
            this.errorProvider_pname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_price = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_username = new System.Windows.Forms.Label();
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Produt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Produt
            // 
            this.groupBox_Produt.Controls.Add(this.btn_privious);
            this.groupBox_Produt.Controls.Add(this.btn_update);
            this.groupBox_Produt.Controls.Add(this.label2);
            this.groupBox_Produt.Controls.Add(this.comboBox_items);
            this.groupBox_Produt.Controls.Add(this.txt_product_price);
            this.groupBox_Produt.Controls.Add(this.label1);
            this.groupBox_Produt.Controls.Add(this.btn_close);
            this.groupBox_Produt.Controls.Add(this.btn_add);
            this.groupBox_Produt.Controls.Add(this.txt_product_name);
            this.groupBox_Produt.Controls.Add(this.lbl_product_name);
            this.groupBox_Produt.Controls.Add(this.btn_delete);
            this.groupBox_Produt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Produt.Location = new System.Drawing.Point(22, 227);
            this.groupBox_Produt.Name = "groupBox_Produt";
            this.groupBox_Produt.Size = new System.Drawing.Size(429, 363);
            this.groupBox_Produt.TabIndex = 13;
            this.groupBox_Produt.TabStop = false;
            this.groupBox_Produt.Text = "Products";
            // 
            // btn_privious
            // 
            this.btn_privious.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_privious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_privious.Location = new System.Drawing.Point(17, 312);
            this.btn_privious.Name = "btn_privious";
            this.btn_privious.Size = new System.Drawing.Size(209, 35);
            this.btn_privious.TabIndex = 20;
            this.btn_privious.Text = "Privious Window";
            this.btn_privious.UseVisualStyleBackColor = true;
            this.btn_privious.Click += new System.EventHandler(this.btn_privious_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(114, 249);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 40);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Item Name";
            // 
            // comboBox_items
            // 
            this.comboBox_items.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_items.FormattingEnabled = true;
            this.comboBox_items.Location = new System.Drawing.Point(157, 68);
            this.comboBox_items.Name = "comboBox_items";
            this.comboBox_items.Size = new System.Drawing.Size(251, 29);
            this.comboBox_items.TabIndex = 1;
            this.comboBox_items.SelectedIndexChanged += new System.EventHandler(this.comboBox_items_SelectedIndexChanged);
            // 
            // txt_product_price
            // 
            this.txt_product_price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_price.Location = new System.Drawing.Point(157, 196);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.Size = new System.Drawing.Size(251, 29);
            this.txt_product_price.TabIndex = 3;
            this.txt_product_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_product_price_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Price";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(314, 249);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(91, 40);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(17, 249);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 40);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_product_name
            // 
            this.txt_product_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(157, 137);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(251, 29);
            this.txt_product_name.TabIndex = 2;
            this.txt_product_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_product_name_KeyPress);
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(6, 139);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(128, 22);
            this.lbl_product_name.TabIndex = 9;
            this.lbl_product_name.Text = "Product Name";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(211, 249);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 40);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // listview_product
            // 
            this.listview_product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listview_product.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview_product.HideSelection = false;
            this.listview_product.Location = new System.Drawing.Point(478, 227);
            this.listview_product.Name = "listview_product";
            this.listview_product.Size = new System.Drawing.Size(543, 363);
            this.listview_product.TabIndex = 12;
            this.listview_product.UseCompatibleStateImageBehavior = false;
            this.listview_product.View = System.Windows.Forms.View.Details;
            this.listview_product.DoubleClick += new System.EventHandler(this.listview_product_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Price";
            this.columnHeader2.Width = 238;
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(335, 38);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(414, 64);
            this.lbl_head.TabIndex = 11;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // errorProvider_pname
            // 
            this.errorProvider_pname.ContainerControl = this;
            // 
            // errorProvider_price
            // 
            this.errorProvider_price.ContainerControl = this;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(789, 54);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 23);
            this.lbl_username.TabIndex = 22;
            this.lbl_username.Text = "User Name";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer_tool
            // 
            this.timer_tool.Tick += new System.EventHandler(this.timer_tool_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(789, 87);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 23);
            this.lbl_timer.TabIndex = 23;
            this.lbl_timer.Text = "Timer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.groupBox_Produt);
            this.Controls.Add(this.listview_product);
            this.Controls.Add(this.lbl_head);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.groupBox_Produt.ResumeLayout(false);
            this.groupBox_Produt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Produt;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListView listview_product;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.TextBox txt_product_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_items;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ErrorProvider errorProvider_pname;
        private System.Windows.Forms.ErrorProvider errorProvider_price;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Timer timer_tool;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_privious;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}