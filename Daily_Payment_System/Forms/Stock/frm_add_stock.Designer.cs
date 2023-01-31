namespace Daily_Payment_System.Forms.Stock
{
    partial class frm_add_stock
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSuplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSelectProduct = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.MaskedTextBox();
            this.txtUnitPrice = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ឈ្មោះទំនិញ";
            // 
            // cboSuplier
            // 
            this.cboSuplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSuplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuplier.FormattingEnabled = true;
            this.cboSuplier.Location = new System.Drawing.Point(112, 140);
            this.cboSuplier.Name = "cboSuplier";
            this.cboSuplier.Size = new System.Drawing.Size(243, 32);
            this.cboSuplier.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "អ្នកផ្គត់ផ្អង់";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "ចំនួនសរុប";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "តម្លៃ/ឯកតា";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Daily_Payment_System.Properties.Resources.save_24px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(255, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(99, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Image = global::Daily_Payment_System.Properties.Resources.no_image;
            this.picProduct.Location = new System.Drawing.Point(223, 15);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(93, 93);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 12;
            this.picProduct.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.lblSelectProduct);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.picProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 112);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(93, 73);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(32, 24);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "N/A";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(90, 37);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(32, 24);
            this.lblProduct.TabIndex = 15;
            this.lblProduct.Text = "N/A";
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Location = new System.Drawing.Point(6, 0);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(93, 24);
            this.lblSelectProduct.TabIndex = 14;
            this.lblSelectProduct.TabStop = true;
            this.lblSelectProduct.Text = "ជ្រើសរើសទំនិញ";
            this.lblSelectProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelectProduct_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "ប្រភេទទំនិញ";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(111, 183);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(244, 32);
            this.txtQTY.TabIndex = 14;
            this.txtQTY.ValidatingType = typeof(int);
            this.txtQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQTY_KeyPress);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(110, 222);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(244, 32);
            this.txtUnitPrice.TabIndex = 15;
            this.txtUnitPrice.ValidatingType = typeof(int);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // frm_add_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 334);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboSuplier);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_stock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_stock";
            this.Load += new System.EventHandler(this.frm_add_stock_Load);
            this.Shown += new System.EventHandler(this.frm_add_stock_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSuplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lblSelectProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.MaskedTextBox txtQTY;
        private System.Windows.Forms.MaskedTextBox txtUnitPrice;
    }
}