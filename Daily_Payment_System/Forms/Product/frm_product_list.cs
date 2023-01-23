
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daily_Payment_System.Class;
using Daily_Payment_System.Forms.Setting;

namespace Daily_Payment_System.Forms.Product
{
    public partial class frm_product_list : Form
    {
        public frm_product_list()
        {
            InitializeComponent();
        }
        frm_view_product_image frm_View_Product;
        frm_loading frm = new frm_loading();

        public Action NotifyMainFormToOpenChildForm2;
        public delegate void TransfDelegate(vw_select_product product);
        public event TransfDelegate TransfEvent;

        private void frm_product_list_Load(object sender, EventArgs e)
        {
            Class.Settings.dataGridViewStyle(dgvProduct);
            this.dgvProduct.Columns["col_img"].DefaultCellStyle.NullValue = Properties.Resources.no_image;
        }

        private void frm_product_list_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(showProduct);
            frm.Show();
            thread.Start("");
        }

        private void showProduct(object search)
        {
            var query = Utils.GetProducts();
            if (!string.IsNullOrEmpty(search.ToString()))
            {
                query = query.Where(f => f.pro_name.ToLower().Contains(search.ToString().ToLower()) || f.category.ToLower().Contains(search.ToString().ToLower())).ToList();
            }
            this.BeginInvoke((MethodInvoker)(() =>
            {
                dgvProduct.DataSource = query;
                frm.Hide();
            }));
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (NotifyMainFormToOpenChildForm2 != null)
            {
                NotifyMainFormToOpenChildForm2();
            }
        }

        private void dgvProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Settings.DataGridViewRowNum(dgvProduct, "col_lr");
        }

      
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgvProduct.Columns["col_img"].Index)
                {
                    Byte[] bytes = (byte[])dgvProduct.Rows[e.RowIndex].Cells["col_img"].Value;
                    string proName = dgvProduct.Rows[e.RowIndex].Cells["col_pro_name"].Value.ToString();
                    frm_View_Product = new frm_view_product_image(bytes, proName);
                    frm_View_Product.Show();
                }else if (e.ColumnIndex == dgvProduct.Columns["col_edit"].Index)
                {
                    var product = new vw_select_product
                    {
                        pro_id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["col_pro_id"].Value),
                        cat_id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["col_cat_id"].Value),
                        pro_name = dgvProduct.Rows[e.RowIndex].Cells["col_pro_name"].Value.ToString(),
                        image = (byte[])dgvProduct.Rows[e.RowIndex].Cells["col_img"].Value
                };
                    TransfEvent(product);
                }
            }
        }

        private void dgvProduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.Cursor = (e.ColumnIndex == dgvProduct.Columns["col_img"].Index && e.RowIndex > -1) ? Cursors.Hand : Cursors.Default;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    Thread thread = new Thread(showProduct);
                    frm.Show();
                    thread.Start(txtSearch.Text.Trim());
                }
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    Thread thread = new Thread(showProduct);
                    frm.Show();
                    thread.Start("");
                }
            }
        }
    }
}
