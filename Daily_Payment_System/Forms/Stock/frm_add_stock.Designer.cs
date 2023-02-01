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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInvDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInvCode = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.radDollar = new System.Windows.Forms.RadioButton();
            this.radRiel = new System.Windows.Forms.RadioButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.col_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_lr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_spl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_spl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unit_prie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
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
            this.cboSuplier.Location = new System.Drawing.Point(79, 16);
            this.cboSuplier.Name = "cboSuplier";
            this.cboSuplier.Size = new System.Drawing.Size(340, 32);
            this.cboSuplier.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "អ្នកផ្គត់ផ្អង់";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "លេខវិក័យប័ត្រ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "តម្លៃ/ឯកតា";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Daily_Payment_System.Properties.Resources.save_24px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(642, 4);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1207, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // picProduct
            // 
            this.picProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Image = global::Daily_Payment_System.Properties.Resources.no_image;
            this.picProduct.Location = new System.Drawing.Point(308, 18);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(117, 119);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 12;
            this.picProduct.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.lblSelectProduct);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.picProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 143);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(93, 93);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(35, 24);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "N/A";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProduct.Location = new System.Drawing.Point(93, 45);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(35, 24);
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
            this.label6.Location = new System.Drawing.Point(15, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "ប្រភេទទំនិញ";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(79, 59);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(340, 32);
            this.txtQTY.TabIndex = 14;
            this.txtQTY.ValidatingType = typeof(int);
            this.txtQTY.TextChanged += new System.EventHandler(this.txtQTY_TextChanged);
            this.txtQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQTY_KeyPress);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(79, 102);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(340, 32);
            this.txtUnitPrice.TabIndex = 15;
            this.txtUnitPrice.ValidatingType = typeof(int);
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "កាលបរិច្ឆេទ";
            // 
            // dtpInvDate
            // 
            this.dtpInvDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvDate.Location = new System.Drawing.Point(228, 48);
            this.dtpInvDate.Name = "dtpInvDate";
            this.dtpInvDate.Size = new System.Drawing.Size(181, 32);
            this.dtpInvDate.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(451, 126);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtInvCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpInvDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 106);
            this.panel2.TabIndex = 18;
            // 
            // txtInvCode
            // 
            this.txtInvCode.Location = new System.Drawing.Point(22, 48);
            this.txtInvCode.Name = "txtInvCode";
            this.txtInvCode.Size = new System.Drawing.Size(181, 32);
            this.txtInvCode.TabIndex = 18;
            this.txtInvCode.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "ចំនួនទំនិញ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel3.Size = new System.Drawing.Size(451, 398);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.radDollar);
            this.panel4.Controls.Add(this.radRiel);
            this.panel4.Controls.Add(this.lblTotalPrice);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cboSuplier);
            this.panel4.Controls.Add(this.txtQTY);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtUnitPrice);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(10, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 245);
            this.panel4.TabIndex = 20;
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
            this.btnAdd.Location = new System.Drawing.Point(320, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(99, 38);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "បន្ថែមថ្មី";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radDollar
            // 
            this.radDollar.AutoSize = true;
            this.radDollar.Checked = true;
            this.radDollar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radDollar.Location = new System.Drawing.Point(79, 194);
            this.radDollar.Name = "radDollar";
            this.radDollar.Size = new System.Drawing.Size(55, 28);
            this.radDollar.TabIndex = 22;
            this.radDollar.TabStop = true;
            this.radDollar.Text = "ដុល្លា";
            this.radDollar.UseVisualStyleBackColor = true;
            // 
            // radRiel
            // 
            this.radRiel.AutoSize = true;
            this.radRiel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radRiel.Location = new System.Drawing.Point(162, 194);
            this.radRiel.Name = "radRiel";
            this.radRiel.Size = new System.Drawing.Size(54, 28);
            this.radRiel.TabIndex = 6;
            this.radRiel.Text = "រៀល";
            this.radRiel.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(79, 145);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(340, 30);
            this.lblTotalPrice.TabIndex = 21;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "តម្លៃសរុប";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvStock);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(451, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.panel5.Size = new System.Drawing.Size(756, 524);
            this.panel5.TabIndex = 21;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_delete,
            this.col_lr,
            this.col_pro_id,
            this.col_pro_name,
            this.col_category,
            this.col_spl_id,
            this.col_spl_name,
            this.col_qty,
            this.col_unit_prie,
            this.col_total,
            this.col_currency});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 10);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(746, 448);
            this.dgvStock.TabIndex = 5;
            this.dgvStock.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvStock_RowsAdded);
            this.dgvStock.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvStock_RowsRemoved);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 458);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel7.Size = new System.Drawing.Size(746, 56);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.btnSave);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(746, 46);
            this.panel8.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(126, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 30);
            this.label10.TabIndex = 23;
            this.label10.Text = "0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "តម្លៃសរុបចុងក្រោយ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(451, 524);
            this.panel6.TabIndex = 22;
            // 
            // col_delete
            // 
            this.col_delete.HeaderText = "";
            this.col_delete.Name = "col_delete";
            this.col_delete.ReadOnly = true;
            this.col_delete.Text = "លុប";
            this.col_delete.UseColumnTextForButtonValue = true;
            this.col_delete.Width = 50;
            // 
            // col_lr
            // 
            this.col_lr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_lr.DefaultCellStyle = dataGridViewCellStyle26;
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
            // col_spl_id
            // 
            this.col_spl_id.DataPropertyName = "spl_id";
            this.col_spl_id.HeaderText = "spl_id";
            this.col_spl_id.Name = "col_spl_id";
            this.col_spl_id.ReadOnly = true;
            this.col_spl_id.Visible = false;
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
            // col_qty
            // 
            this.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_qty.DataPropertyName = "qty";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_qty.DefaultCellStyle = dataGridViewCellStyle27;
            this.col_qty.HeaderText = "ចំនួនទំនិញ";
            this.col_qty.Name = "col_qty";
            this.col_qty.ReadOnly = true;
            this.col_qty.Width = 94;
            // 
            // col_unit_prie
            // 
            this.col_unit_prie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_unit_prie.DataPropertyName = "unit_price";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_unit_prie.DefaultCellStyle = dataGridViewCellStyle28;
            this.col_unit_prie.HeaderText = "តម្លៃ/ឯកតា";
            this.col_unit_prie.Name = "col_unit_prie";
            this.col_unit_prie.ReadOnly = true;
            this.col_unit_prie.Width = 92;
            // 
            // col_total
            // 
            this.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_total.DataPropertyName = "total_price";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_total.DefaultCellStyle = dataGridViewCellStyle29;
            this.col_total.HeaderText = "តម្លៃសរុប";
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            this.col_total.Width = 83;
            // 
            // col_currency
            // 
            this.col_currency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_currency.DataPropertyName = "currency";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_currency.DefaultCellStyle = dataGridViewCellStyle30;
            this.col_currency.HeaderText = "រូបិយបណ្ណ";
            this.col_currency.Name = "col_currency";
            this.col_currency.ReadOnly = true;
            this.col_currency.Width = 89;
            // 
            // frm_add_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 546);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.statusStrip1);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInvDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtInvCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.RadioButton radRiel;
        private System.Windows.Forms.RadioButton radDollar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewButtonColumn col_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pro_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_spl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_spl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unit_prie;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_currency;
    }
}