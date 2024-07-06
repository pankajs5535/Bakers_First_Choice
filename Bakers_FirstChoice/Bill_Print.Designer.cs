
namespace Bakers_FirstChoice
{
    partial class Bill_Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Print));
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_head = new System.Windows.Forms.Label();
            this.timer_tool = new System.Windows.Forms.Timer(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btn_bill_print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(782, 84);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(59, 23);
            this.lbl_timer.TabIndex = 41;
            this.lbl_timer.Text = "Timer";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(782, 44);
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
            this.lbl_head.Location = new System.Drawing.Point(335, 35);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(414, 64);
            this.lbl_head.TabIndex = 39;
            this.lbl_head.Text = "Bakers First Choice";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bakers_FirstChoice.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(59, 287);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 365);
            this.reportViewer1.TabIndex = 42;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(264, 187);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(255, 26);
            this.txt_phone.TabIndex = 43;
            // 
            // btn_bill_print
            // 
            this.btn_bill_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill_print.Location = new System.Drawing.Point(525, 187);
            this.btn_bill_print.Name = "btn_bill_print";
            this.btn_bill_print.Size = new System.Drawing.Size(138, 29);
            this.btn_bill_print.TabIndex = 44;
            this.btn_bill_print.Text = "Phone No";
            this.btn_bill_print.UseVisualStyleBackColor = true;
            this.btn_bill_print.Click += new System.EventHandler(this.btn_bill_print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // Bill_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_bill_print);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_head);
            this.Name = "Bill_Print";
            this.Text = "Bill_Print";
            this.Load += new System.EventHandler(this.Bill_Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Timer timer_tool;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_bill_print;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}