namespace Daily_Payment_System.Forms.Suplier
{
    partial class frm_add_suplier
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuplier = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 231);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(485, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Daily_Payment_System.Properties.Resources.save_24px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(358, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(99, 38);
            this.btnSave.TabIndex = 19;
            this.btnSave.Tag = "0";
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(91, 177);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(78, 28);
            this.chkStatus.TabIndex = 18;
            this.chkStatus.Text = "ស្ថានភាព";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "អ្នកផ្គត់ផ្គង់";
            // 
            // txtSuplier
            // 
            this.txtSuplier.Location = new System.Drawing.Point(91, 14);
            this.txtSuplier.Name = "txtSuplier";
            this.txtSuplier.Size = new System.Drawing.Size(366, 32);
            this.txtSuplier.TabIndex = 16;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(91, 52);
            this.txtPlace.Multiline = true;
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(366, 119);
            this.txtPlace.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "ទីតាំង";
            // 
            // frm_add_suplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSuplier);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_suplier";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "បន្ថែមអ្នកផ្គត់ផ្គង់";
            this.Load += new System.EventHandler(this.frm_add_suplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuplier;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label1;
    }
}