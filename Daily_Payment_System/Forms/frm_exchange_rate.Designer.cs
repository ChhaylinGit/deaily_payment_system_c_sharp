namespace Daily_Payment_System.Forms
{
    partial class frm_exchange_rate
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
            this.dgvRate = new System.Windows.Forms.DataGridView();
            this.col_lr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_1_sale_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_1_buy_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_2_sale_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_2_buy_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRate
            // 
            this.dgvRate.AllowUserToAddRows = false;
            this.dgvRate.AllowUserToDeleteRows = false;
            this.dgvRate.BackgroundColor = System.Drawing.Color.White;
            this.dgvRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_lr,
            this.col_1_sale_out,
            this.col_1_buy_in,
            this.col_2_sale_out,
            this.col_2_buy_in,
            this.col_date});
            this.dgvRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRate.Location = new System.Drawing.Point(0, 57);
            this.dgvRate.Name = "dgvRate";
            this.dgvRate.ReadOnly = true;
            this.dgvRate.Size = new System.Drawing.Size(845, 363);
            this.dgvRate.TabIndex = 0;
            // 
            // col_lr
            // 
            this.col_lr.HeaderText = "ល.រ";
            this.col_lr.Name = "col_lr";
            this.col_lr.ReadOnly = true;
            // 
            // col_1_sale_out
            // 
            this.col_1_sale_out.HeaderText = "1/.លក់ចេញ";
            this.col_1_sale_out.Name = "col_1_sale_out";
            this.col_1_sale_out.ReadOnly = true;
            // 
            // col_1_buy_in
            // 
            this.col_1_buy_in.HeaderText = "1/.ទិញចូល";
            this.col_1_buy_in.Name = "col_1_buy_in";
            this.col_1_buy_in.ReadOnly = true;
            // 
            // col_2_sale_out
            // 
            this.col_2_sale_out.HeaderText = "2/.លក់ចេញ";
            this.col_2_sale_out.Name = "col_2_sale_out";
            this.col_2_sale_out.ReadOnly = true;
            // 
            // col_2_buy_in
            // 
            this.col_2_buy_in.HeaderText = "2/.ទិញចូល";
            this.col_2_buy_in.Name = "col_2_buy_in";
            this.col_2_buy_in.ReadOnly = true;
            // 
            // col_date
            // 
            this.col_date.HeaderText = "កាលបរិច្ឆេទ";
            this.col_date.Name = "col_date";
            this.col_date.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(845, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnShowDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDateEnd);
            this.panel1.Controls.Add(this.dtpDateStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 57);
            this.panel1.TabIndex = 3;
            // 
            // btnShowDate
            // 
            this.btnShowDate.Location = new System.Drawing.Point(303, 13);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(70, 30);
            this.btnShowDate.TabIndex = 5;
            this.btnShowDate.Text = "បង្ហាញ";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ដល់";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.CustomFormat = "dd-MM-yyyy";
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEnd.Location = new System.Drawing.Point(195, 14);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(102, 28);
            this.dtpDateEnd.TabIndex = 3;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.CustomFormat = "dd-MM-yyyy";
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateStart.Location = new System.Drawing.Point(53, 14);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(102, 28);
            this.dtpDateStart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ចាប់ពី";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(763, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "បន្ថែមថ្មី";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frm_exchange_rate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 442);
            this.Controls.Add(this.dgvRate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_exchange_rate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "អត្រាប្តូប្រាក់ប្រចាំថ្ងៃ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_1_sale_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_1_buy_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_2_sale_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_2_buy_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
    }
}