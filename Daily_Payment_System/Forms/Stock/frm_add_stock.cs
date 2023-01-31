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
            tbl_stock stock = new tbl_stock();
            stock.pro_id = product.pro_id;
            stock.spl_id = Convert.ToInt32(cboSuplier.SelectedValue);
            stock.qty = Convert.ToInt32(txtQTY.Text);
            stock.unit_price = Convert.ToDecimal(txtUnitPrice.Text);
            stock.st_date = DateTime.Now;
            ConstantField.entities.tbl_stock.Add(stock);
            ConstantField.entities.SaveChanges();
        }

        private void frm_add_stock_Load(object sender, EventArgs e)
        { 
           
        }

        private void loadData()
        {
            var query = Utils.GetSuplier();
            this.BeginInvoke((MethodInvoker)(() =>
            {
                lblProduct.Text = product.pro_name;
                lblCategory.Text = product.category;
                picProduct.Image = product.image == null ? Properties.Resources.no_image : Settings.ConvertImage(product.image);
                cboSuplier.DataSource = query;
                cboSuplier.DisplayMember = "spl_name";
                cboSuplier.ValueMember = "spl_id";
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
    }
}
