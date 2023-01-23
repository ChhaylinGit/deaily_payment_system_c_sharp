namespace Daily_Payment_System.Forms.Product
{
    partial class frm_product_list
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.col_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_lr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_entry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_img = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Daily_Payment_System.Properties.Resources.new_copy_24px;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(991, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(99, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "បន្ថែមថ្មី";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 32);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ស្វែងរក";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_edit,
            this.col_lr,
            this.col_pro_id,
            this.col_pro_name,
            this.col_cat_id,
            this.col_category,
            this.col_entry_date,
            this.col_img});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 64);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(1102, 489);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellMouseEnter);
            this.dgvProduct.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProduct_RowsAdded);
            // 
            // col_edit
            // 
            this.col_edit.HeaderText = "";
            this.col_edit.Name = "col_edit";
            this.col_edit.ReadOnly = true;
            this.col_edit.Text = "កែប្រែ";
            this.col_edit.UseColumnTextForButtonValue = true;
            this.col_edit.Width = 70;
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
            // col_pro_id
            // 
            this.col_pro_id.DataPropertyName = "pro_id";
            this.col_pro_id.HeaderText = "pro_id";
            this.col_pro_id.Name = "col_pro_id";
            this.col_pro_id.ReadOnly = true;
            this.col_pro_id.Visible = false;
            // 
            // col_pro_name
            // 
            this.col_pro_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_pro_name.DataPropertyName = "pro_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_pro_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_pro_name.HeaderText = "ឈ្មោះទំនិញ";
            this.col_pro_name.Name = "col_pro_name";
            this.col_pro_name.ReadOnly = true;
            this.col_pro_name.Width = 99;
            // 
            // col_cat_id
            // 
            this.col_cat_id.DataPropertyName = "cat_id";
            this.col_cat_id.HeaderText = "cat_id";
            this.col_cat_id.Name = "col_cat_id";
            this.col_cat_id.ReadOnly = true;
            this.col_cat_id.Visible = false;
            // 
            // col_category
            // 
            this.col_category.DataPropertyName = "category";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_category.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_category.HeaderText = "ប្រភេទទំនិញ";
            this.col_category.Name = "col_category";
            this.col_category.ReadOnly = true;
            // 
            // col_entry_date
            // 
            this.col_entry_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_entry_date.DataPropertyName = "entry_date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.col_entry_date.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_entry_date.HeaderText = "កាលបរិច្ឆេទបញ្ចូល";
            this.col_entry_date.Name = "col_entry_date";
            this.col_entry_date.ReadOnly = true;
            this.col_entry_date.Width = 133;
            // 
            // col_img
            // 
            this.col_img.DataPropertyName = "image";
            this.col_img.HeaderText = "រូបភាព";
            this.col_img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_img.Name = "col_img";
            this.col_img.ReadOnly = true;
            this.col_img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_img.Width = 70;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1102, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
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
            // frm_product_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frm_product_list";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "បញ្ចីរាយនាមទំនិញ";
            this.Load += new System.EventHandler(this.frm_product_list_Load);
            this.Shown += new System.EventHandler(this.frm_product_list_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewButtonColumn col_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pro_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_entry_date;
        private System.Windows.Forms.DataGridViewImageColumn col_img;
    }
}