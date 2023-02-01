namespace Daily_Payment_System.Forms.Suplier
{
    partial class frm_suplier_list
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvSuplier = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_lr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_spl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_spl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_entry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_edit_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuplier)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 64);
            this.panel1.TabIndex = 6;
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
            this.btnAdd.Location = new System.Drawing.Point(773, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(99, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "បន្ថែមថ្មី";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(67, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
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
            // dgvSuplier
            // 
            this.dgvSuplier.AllowUserToAddRows = false;
            this.dgvSuplier.AllowUserToDeleteRows = false;
            this.dgvSuplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_edit,
            this.col_lr,
            this.col_spl_id,
            this.col_spl,
            this.col_tel,
            this.col_place,
            this.col_entry_date,
            this.col_status,
            this.col_edit_date});
            this.dgvSuplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuplier.Location = new System.Drawing.Point(0, 64);
            this.dgvSuplier.Name = "dgvSuplier";
            this.dgvSuplier.ReadOnly = true;
            this.dgvSuplier.Size = new System.Drawing.Size(884, 349);
            this.dgvSuplier.TabIndex = 7;
            this.dgvSuplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuplier_CellClick);
            this.dgvSuplier.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSuplier_RowsAdded);
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
            // col_spl_id
            // 
            this.col_spl_id.DataPropertyName = "spl_id";
            this.col_spl_id.HeaderText = "spl_id";
            this.col_spl_id.Name = "col_spl_id";
            this.col_spl_id.ReadOnly = true;
            this.col_spl_id.Visible = false;
            // 
            // col_spl
            // 
            this.col_spl.DataPropertyName = "spl_name";
            this.col_spl.HeaderText = "អ្នកផ្គត់ផ្គង់";
            this.col_spl.Name = "col_spl";
            this.col_spl.ReadOnly = true;
            // 
            // col_tel
            // 
            this.col_tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_tel.DataPropertyName = "tel";
            this.col_tel.HeaderText = "លេខទូរសព្ទ";
            this.col_tel.Name = "col_tel";
            this.col_tel.ReadOnly = true;
            this.col_tel.Width = 97;
            // 
            // col_place
            // 
            this.col_place.DataPropertyName = "place";
            this.col_place.HeaderText = "ទីតាំង";
            this.col_place.Name = "col_place";
            this.col_place.ReadOnly = true;
            // 
            // col_entry_date
            // 
            this.col_entry_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_entry_date.DataPropertyName = "entry_date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.col_entry_date.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_entry_date.HeaderText = "កាលបរិច្ឆេទបញ្ចូល";
            this.col_entry_date.Name = "col_entry_date";
            this.col_entry_date.ReadOnly = true;
            this.col_entry_date.Width = 133;
            // 
            // col_status
            // 
            this.col_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_status.DataPropertyName = "status";
            this.col_status.HeaderText = "ស្ថានភាព";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            this.col_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_status.Width = 84;
            // 
            // col_edit_date
            // 
            this.col_edit_date.DataPropertyName = "edit_date";
            this.col_edit_date.HeaderText = "edit_date";
            this.col_edit_date.Name = "col_edit_date";
            this.col_edit_date.ReadOnly = true;
            this.col_edit_date.Visible = false;
            // 
            // frm_suplier_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 435);
            this.Controls.Add(this.dgvSuplier);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frm_suplier_list";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_suplier_list";
            this.Load += new System.EventHandler(this.frm_suplier_list_Load);
            this.Shown += new System.EventHandler(this.frm_suplier_list_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.DataGridView dgvSuplier;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn col_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_spl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_spl;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_entry_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_edit_date;
    }
}