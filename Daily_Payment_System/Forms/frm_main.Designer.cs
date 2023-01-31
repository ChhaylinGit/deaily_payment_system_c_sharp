namespace Daily_Payment_System.Forms
{
    partial class frm_main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ចកចញToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_tsm_change_database = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_exchange_rate = new System.Windows.Forms.ToolStripMenuItem();
            this.ករកណតToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_printer = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_tsm_product = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_tsm_category = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_tsm_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sub_tsm_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.tsm_exchange_rate,
            this.ករកណតToolStripMenuItem,
            this.tsm_printer});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1030, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ចកចញToolStripMenuItem,
            this.sub_tsm_change_database});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 28);
            this.fileMenu.Text = "ហ្វាល់";
            // 
            // ចកចញToolStripMenuItem
            // 
            this.ចកចញToolStripMenuItem.Name = "ចកចញToolStripMenuItem";
            this.ចកចញToolStripMenuItem.Size = new System.Drawing.Size(215, 28);
            this.ចកចញToolStripMenuItem.Text = "ចាកចេញ";
            // 
            // sub_tsm_change_database
            // 
            this.sub_tsm_change_database.Name = "sub_tsm_change_database";
            this.sub_tsm_change_database.Size = new System.Drawing.Size(215, 28);
            this.sub_tsm_change_database.Text = "ប្តូរDatabase Connection";
            this.sub_tsm_change_database.Click += new System.EventHandler(this.sub_tsm_change_database_Click);
            // 
            // tsm_exchange_rate
            // 
            this.tsm_exchange_rate.Name = "tsm_exchange_rate";
            this.tsm_exchange_rate.Size = new System.Drawing.Size(87, 28);
            this.tsm_exchange_rate.Text = "អត្រាប្តូរប្រាក់";
            this.tsm_exchange_rate.Click += new System.EventHandler(this.tsm_exchange_rate_Click);
            // 
            // ករកណតToolStripMenuItem
            // 
            this.ករកណតToolStripMenuItem.Name = "ករកណតToolStripMenuItem";
            this.ករកណតToolStripMenuItem.Size = new System.Drawing.Size(75, 28);
            this.ករកណតToolStripMenuItem.Text = "ការកំណត់";
            // 
            // tsm_printer
            // 
            this.tsm_printer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_tsm_product,
            this.sub_tsm_category,
            this.sub_tsm_supplier,
            this.sub_tsm_stock});
            this.tsm_printer.Name = "tsm_printer";
            this.tsm_printer.Size = new System.Drawing.Size(79, 28);
            this.tsm_printer.Text = "សម្ភារៈព្រីន";
            // 
            // sub_tsm_product
            // 
            this.sub_tsm_product.Name = "sub_tsm_product";
            this.sub_tsm_product.Size = new System.Drawing.Size(180, 28);
            this.sub_tsm_product.Text = "ទំនិញផ្សេងៗ";
            this.sub_tsm_product.Click += new System.EventHandler(this.sub_tsm_product_Click);
            // 
            // sub_tsm_category
            // 
            this.sub_tsm_category.Name = "sub_tsm_category";
            this.sub_tsm_category.Size = new System.Drawing.Size(180, 28);
            this.sub_tsm_category.Text = "ប្រភេទទំនិញ";
            this.sub_tsm_category.Click += new System.EventHandler(this.sub_tsm_category_Click);
            // 
            // sub_tsm_supplier
            // 
            this.sub_tsm_supplier.Name = "sub_tsm_supplier";
            this.sub_tsm_supplier.Size = new System.Drawing.Size(180, 28);
            this.sub_tsm_supplier.Text = "អ្នកផ្គត់ផ្គង់";
            this.sub_tsm_supplier.Click += new System.EventHandler(this.sub_tsm_supplier_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Khmer OS Battambang", 9F);
            this.toolStrip.Location = new System.Drawing.Point(0, 36);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1030, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 711);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(1030, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // sub_tsm_stock
            // 
            this.sub_tsm_stock.Name = "sub_tsm_stock";
            this.sub_tsm_stock.Size = new System.Drawing.Size(180, 28);
            this.sub_tsm_stock.Text = "ស្តុកទំនិញ";
            this.sub_tsm_stock.Click += new System.EventHandler(this.sub_tsm_stock_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 733);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frm_main";
            this.ShowIcon = false;
            this.Text = "Wing Deaily Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsm_exchange_rate;
        private System.Windows.Forms.ToolStripMenuItem ករកណតToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចកចញToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_printer;
        private System.Windows.Forms.ToolStripMenuItem sub_tsm_product;
        private System.Windows.Forms.ToolStripMenuItem sub_tsm_change_database;
        private System.Windows.Forms.ToolStripMenuItem sub_tsm_category;
        private System.Windows.Forms.ToolStripMenuItem sub_tsm_supplier;
        private System.Windows.Forms.ToolStripMenuItem sub_tsm_stock;
    }
}



