using Daily_Payment_System.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Payment_System.Forms.Product
{
    public partial class frm_product_list : Form
    {
        public frm_product_list()
        {
            InitializeComponent();
        }
        frm_view_product_image frm_View_Product;

        public Action NotifyMainFormToOpenChildForm2;

        private void frm_product_list_Load(object sender, EventArgs e)
        {
            Setting.dataGridViewStyle(dgvProduct);
            dgvProduct.DataSource = Utils.GetProducts();
            this.dgvProduct.Columns["col_img"].DefaultCellStyle.NullValue = Properties.Resources.no_image; ;
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
            Setting.DataGridViewRowNum(dgvProduct, "col_lr");
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
                }
            }
        }

        private void dgvProduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.Cursor = (e.ColumnIndex == dgvProduct.Columns["col_img"].Index && e.RowIndex > -1) ? Cursors.Hand : Cursors.Default;
        }
    }
}
