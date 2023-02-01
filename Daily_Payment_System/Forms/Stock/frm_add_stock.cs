using Daily_Payment_System.Class;
using Daily_Payment_System.Forms.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Daily_Payment_System.Forms.Stock
{
    public partial class frm_add_stock : Form
    {
        frm_loading frm = new frm_loading();
        public Action openProductListForm;
        public vw_select_product product = new vw_select_product();

        public frm_add_stock()
        {
            InitializeComponent();
        }

        public frm_add_stock(vw_select_product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            using (TransactionScope trc = new TransactionScope())
            {
                try
                {
                    tbl_invoice invoice = new tbl_invoice();
                    invoice.inv_code = txtInvCode.Text.Trim();
                    invoice.inv_date = dtpInvDate.Value.Date;
                    invoice.entry_date = DateTime.Now;
                    ConstantField.entities.tbl_invoice.Add(invoice);
                    ConstantField.entities.SaveChanges();

                    tbl_invoice_detail invoice_detail = new tbl_invoice_detail();
                    invoice_detail.inv_id = invoice.inv_id;
                    invoice_detail.pro_id = product.pro_id;
                    invoice_detail.cur_id = getCurrencyValue();
                    invoice_detail.spl_id = Convert.ToInt32(cboSuplier.SelectedValue);
                    invoice_detail.qty = Convert.ToInt32(txtQTY.Text);
                    invoice_detail.unit_price = Convert.ToDecimal(txtUnitPrice.Text);
                    ConstantField.entities.tbl_invoice_detail.Add(invoice_detail);
                    ConstantField.entities.SaveChanges();
                    trc.Complete();
                    trc.Dispose();
                    MsgBox.showInfor(ConstantField.TEXT_MSG_INFO);
                }
                catch (Exception ex)
                {
                    trc.Dispose();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int getCurrencyValue()
        {
            int result = 0;
            if (radRiel.Checked)
            {
                result = 1;
            }else if (radDollar.Checked)
            {
                result = 2;
            }
            return result;
        }

        private string getCurrencyText()
        {
            string result = "";
            if (radRiel.Checked)
            {
                result = radRiel.Text;
            }
            else if (radDollar.Checked)
            {
                result = radDollar.Text;
            }
            return result;
        }

        private void frm_add_stock_Load(object sender, EventArgs e)
        {
            Class.Settings.dataGridViewStyle(dgvStock);
        }

        private void loadData()
        {
            var query = Utils.GetSuplier();
            this.BeginInvoke((MethodInvoker)(() =>
            {
                if(this.product.pro_id != 0)
                {
                    lblProduct.Text = product.pro_name;
                    lblCategory.Text = product.category;
                    picProduct.Image = product.image == null ? Properties.Resources.no_image : Settings.ConvertImage(product.image);
                    panel4.Enabled = true;
                }
                cboSuplier.DataSource = query;
                cboSuplier.DisplayMember = "spl_name";
                cboSuplier.ValueMember = "spl_id";
                cboSuplier.SelectedIndex = -1;
                frm.Hide();
            }));
        }

        private void lblSelectProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(openProductListForm != null)
            {
                openProductListForm();
            }
        }

        private void frm_add_stock_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(loadData);
            frm.Show();
            thread.Start();
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&& e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as MaskedTextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool empty()
        {
            bool result = true;
            
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvStock.Rows.Add(null,null, product.pro_id, product.pro_name, product.category, cboSuplier.SelectedValue, cboSuplier.Text, txtQTY.Text, txtUnitPrice.Text, lblTotalPrice.Text,getCurrencyText());
            lblProduct.Text = "";
            lblCategory.Text = "";
            picProduct.Image = Properties.Resources.no_image;
            panel4.Enabled = false;
        }

        private void dgvStock_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Settings.DataGridViewRowNum(dgvStock, "col_lr");
            btnSave.Enabled = dgvStock.RowCount > 0;
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQTY.Text.Trim()) && !string.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                lblTotalPrice.Text = (Convert.ToDecimal(txtQTY.Text) * Convert.ToDecimal(txtUnitPrice.Text)).ToString("#,###");
            }
            else
            {
                lblTotalPrice.Text = "0";
            }
        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQTY.Text.Trim()) && !string.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                lblTotalPrice.Text = (Convert.ToDecimal(txtQTY.Text) * Convert.ToDecimal(txtUnitPrice.Text)).ToString("#,###");
            }
            else
            {
                lblTotalPrice.Text = "0";
            }
        }

        private void dgvStock_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Settings.DataGridViewRowNum(dgvStock, "col_lr");
            btnSave.Enabled = dgvStock.RowCount > 0;
        }
    }
}
