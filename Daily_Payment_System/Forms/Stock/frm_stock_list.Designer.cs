namespace Daily_Payment_System.Forms.Stock
{
    partial class frm_stock_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.col_lr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_st_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_spl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_spl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unit_prie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_st_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSuplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(326, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(848, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_lr,
            this.col_st_id,
            this.col_pro_id,
            this.col_spl_id,
            this.col_cat_id,
            this.col_pro_name,
            this.col_category,
            this.col_spl_name,
            this.col_place,
            this.col_qty,
            this.col_unit_prie,
            this.col_total,
            this.col_currency,
            this.col_st_date,
            this.col_sign});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(326, 0);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(848, 577);
            this.dgvStock.TabIndex = 4;
            this.dgvStock.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvStock_RowsAdded);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(99, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 32);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ស្វែងរក";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 577);
            this.panel1.TabIndex = 3;
            // 
            // col_lr
            // 
            this.col_lr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_lr.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_lr.HeaderText = "ល.រ";
            this.col_lr.Name = "col_lr";
            this.col_lr.ReadOnly = true;
            this.col_lr.Width = 57;
            // 
            // col_st_id
            // 
            this.col_st_id.DataPropertyName = "st_id";
            this.col_st_id.HeaderText = "st_id";
            this.col_st_id.Name = "col_st_id";
            this.col_st_id.ReadOnly = true;
            this.col_st_id.Visible = false;
            // 
            // col_pro_id
            // 
            this.col_pro_id.DataPropertyName = "pro_id";
            this.col_pro_id.HeaderText = "pro_id";
            this.col_pro_id.Name = "col_pro_id";
            this.col_pro_id.ReadOnly = true;
            this.col_pro_id.Visible = false;
            // 
            // col_spl_id
            // 
            this.col_spl_id.DataPropertyName = "spl_id";
            this.col_spl_id.HeaderText = "spl_id";
            this.col_spl_id.Name = "col_spl_id";
            this.col_spl_id.ReadOnly = true;
            this.col_spl_id.Visible = false;
            // 
            // col_cat_id
            // 
            this.col_cat_id.DataPropertyName = "cat_id";
            this.col_cat_id.HeaderText = "cat_id";
            this.col_cat_id.Name = "col_cat_id";
            this.col_cat_id.ReadOnly = true;
            this.col_cat_id.Visible = false;
            // 
            // col_pro_name
            // 
            this.col_pro_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_pro_name.DataPropertyName = "pro_name";
            this.col_pro_name.HeaderText = "ឈ្មោះទំនិញ";
            this.col_pro_name.Name = "col_pro_name";
            this.col_pro_name.ReadOnly = true;
            this.col_pro_name.Width = 99;
            // 
            // col_category
            // 
            this.col_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_category.DataPropertyName = "category";
            this.col_category.HeaderText = "ប្រភេទទំនិញ";
            this.col_category.Name = "col_category";
            this.col_category.ReadOnly = true;
            this.col_category.Width = 102;
            // 
            // col_spl_name
            // 
            this.col_spl_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_spl_name.DataPropertyName = "spl_name";
            this.col_spl_name.HeaderText = "អ្នកផ្គត់ផ្គង់";
            this.col_spl_name.Name = "col_spl_name";
            this.col_spl_name.ReadOnly = true;
            this.col_spl_name.Width = 89;
            // 
            // col_place
            // 
            this.col_place.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_place.DataPropertyName = "place";
            this.col_place.HeaderText = "ទីតាំងហាង";
            this.col_place.Name = "col_place";
            this.col_place.ReadOnly = true;
            this.col_place.Width = 93;
            // 
            // col_qty
            // 
            this.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_qty.DataPropertyName = "qty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_qty.HeaderText = "ចំនួនទំនិញ";
            this.col_qty.Name = "col_qty";
            this.col_qty.ReadOnly = true;
            this.col_qty.Width = 94;
            // 
            // col_unit_prie
            // 
            this.col_unit_prie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_unit_prie.DataPropertyName = "unit_price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_unit_prie.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_unit_prie.HeaderText = "តម្លៃ/ឯកតា";
            this.col_unit_prie.Name = "col_unit_prie";
            this.col_unit_prie.ReadOnly = true;
            this.col_unit_prie.Width = 92;
            // 
            // col_total
            // 
            this.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_total.DataPropertyName = "total_price";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_total.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_total.HeaderText = "តម្លៃសរុប";
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            this.col_total.Width = 83;
            // 
            // col_currency
            // 
            this.col_currency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_currency.DataPropertyName = "currency";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_currency.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_currency.HeaderText = "រូបិយបណ្ណ";
            this.col_currency.Name = "col_currency";
            this.col_currency.ReadOnly = true;
            this.col_currency.Width = 89;
            // 
            // col_st_date
            // 
            this.col_st_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_st_date.DataPropertyName = "st_date";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.col_st_date.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_st_date.HeaderText = "កាលបរិច្ឆេទចូលស្តុក";
            this.col_st_date.Name = "col_st_date";
            this.col_st_date.ReadOnly = true;
            this.col_st_date.Width = 142;
            // 
            // col_sign
            // 
            this.col_sign.DataPropertyName = "sign";
            this.col_sign.HeaderText = "sign";
            this.col_sign.Name = "col_sign";
            this.col_sign.ReadOnly = true;
            this.col_sign.Visible = false;
            // 
            // cboSuplier
            // 
            this.cboSuplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSuplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuplier.FormattingEnabled = true;
            this.cboSuplier.Location = new System.Drawing.Point(99, 98);
            this.cboSuplier.Name = "cboSuplier";
            this.cboSuplier.Size = new System.Drawing.Size(196, 32);
            this.cboSuplier.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "អ្នកផ្គត់ផ្អង់";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "ប្រភេទទំនិញ";
            // 
            // cboCategory
            // 
            this.cboCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(99, 56);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(196, 32);
            this.cboCategory.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboCategory);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboSuplier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 151);
            this.panel2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 81);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 32);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "ចាប់ពី";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "ដល់";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(210, 31);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 32);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, -2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 28);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "កាលបរិច្ឆេទចូលស្តុក";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.DataPropertyName = "image";
            this.dataGridViewImageColumn1.HeaderText = "រូបភាព";
            this.dataGridViewImageColumn1.Image = global::Daily_Payment_System.Properties.Resources.no_image;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Daily_Payment_System.Properties.Resources.search_24px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(221, 238);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(99, 38);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "ស្វែងរក";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // frm_stock_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 577);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frm_stock_list";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_stock_list";
            this.Load += new System.EventHandler(this.frm_stock_list_Load);
            this.Shown += new System.EventHandler(this.frm_stock_list_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_st_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_spl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pro_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_spl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unit_prie;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_st_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sign;
        private System.Windows.Forms.ComboBox cboSuplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}