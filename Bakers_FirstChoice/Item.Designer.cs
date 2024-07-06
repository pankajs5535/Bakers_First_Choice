
namespace Bakers_FirstChoice
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.lbl_head = new System.Windows.Forms.Label();
            this.listview_item = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider_item = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_Items = new System.Windows.Forms.GroupBox();
            this.btn_privious = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.lbl_item_name = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_item)).BeginInit();
            this.groupBox_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(335, 36);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(414, 64);
            this.lbl_head.TabIndex = 1;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // listview_item
            // 
            this.listview_item.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listview_item.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview_item.HideSelection = false;
            this.listview_item.Location = new System.Drawing.Point(481, 212);
            this.listview_item.Name = "listview_item";
            this.listview_item.Size = new System.Drawing.Size(537, 363);
            this.listview_item.TabIndex = 8;
            this.listview_item.UseCompatibleStateImageBehavior = false;
            this.listview_item.View = System.Windows.Forms.View.Details;
            this.listview_item.DoubleClick += new System.EventHandler(this.listview_item_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 607;
            // 
            // errorProvider_item
            // 
            this.errorProvider_item.ContainerControl = this;
            // 
            // groupBox_Items
            // 
            this.groupBox_Items.Controls.Add(this.btn_privious);
            this.groupBox_Items.Controls.Add(this.btn_update);
            this.groupBox_Items.Controls.Add(this.btn_close);
            this.groupBox_Items.Controls.Add(this.btn_add);
            this.groupBox_Items.Controls.Add(this.txt_item_name);
            this.groupBox_Items.Controls.Add(this.lbl_item_name);
            this.groupBox_Items.Controls.Add(this.btn_delete);
            this.groupBox_Items.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Items.Location = new System.Drawing.Point(25, 212);
            this.groupBox_Items.Name = "groupBox_Items";
            this.groupBox_Items.Size = new System.Drawing.Size(429, 363);
            this.groupBox_Items.TabIndex = 10;
            this.groupBox_Items.TabStop = false;
            this.groupBox_Items.Text = "Items";
            // 
            // btn_privious
            // 
            this.btn_privious.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_privious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_privious.Location = new System.Drawing.Point(51, 265);
            this.btn_privious.Name = "btn_privious";
            this.btn_privious.Size = new System.Drawing.Size(212, 40);
            this.btn_privious.TabIndex = 15;
            this.btn_privious.Text = "Privious Window";
            this.btn_privious.UseVisualStyleBackColor = true;
            this.btn_privious.Click += new System.EventHandler(this.btn_privious_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(172, 206);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 40);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(287, 265);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(91, 40);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(47, 206);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 40);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_item_name
            // 
            this.txt_item_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_name.Location = new System.Drawing.Point(131, 92);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.Size = new System.Drawing.Size(251, 29);
            this.txt_item_name.TabIndex = 13;
            this.txt_item_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_item_name_KeyPress);
            // 
            // lbl_item_name
            // 
            this.lbl_item_name.AutoSize = true;
            this.lbl_item_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_name.Location = new System.Drawing.Point(6, 95);
            this.lbl_item_name.Name = "lbl_item_name";
            this.lbl_item_name.Size = new System.Drawing.Size(100, 22);
            this.lbl_item_name.TabIndex = 9;
            this.lbl_item_name.Text = "Item Name";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(287, 206);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 40);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(803, 52);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 23);
            this.lbl_username.TabIndex = 18;
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
            this.lbl_timer.Location = new System.Drawing.Point(803, 86);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 23);
            this.lbl_timer.TabIndex = 19;
            this.lbl_timer.Text = "Timer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.groupBox_Items);
            this.Controls.Add(this.listview_item);
            this.Controls.Add(this.lbl_head);
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_item)).EndInit();
            this.groupBox_Items.ResumeLayout(false);
            this.groupBox_Items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.ListView listview_item;
        private System.Windows.Forms.ErrorProvider errorProvider_item;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox_Items;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_item_name;
        private System.Windows.Forms.Label lbl_item_name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Timer timer_tool;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_privious;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

