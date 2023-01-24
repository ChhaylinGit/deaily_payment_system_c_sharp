using Daily_Payment_System.Class;
using Daily_Payment_System.Forms.Setting;
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

namespace Daily_Payment_System.Forms.Category
{
    public partial class frm_category_list : Form
    {
        public Action openAddCategoryForm;
        public delegate void OnEditCategory(tbl_category category);
        public event OnEditCategory editCatgory;
        frm_loading frm = new frm_loading();

        public frm_category_list()
        {
            InitializeComponent();
        }
        

        private void frm_category_list_Load(object sender, EventArgs e)
        {
            Class.Settings.dataGridViewStyle(dgvCategory);
           
        }
        private void showCategory(object search)
        {
            var query = Utils.GetCategories();
            if (!string.IsNullOrEmpty(search.ToString()))
            {
                query = query.Where(f => f.category.ToLower().Contains(search.ToString().ToLower())).ToList();
            }
            this.BeginInvoke((MethodInvoker)(() =>
            {
                dgvCategory.DataSource = query;
                frm.Hide();
            }));
        }

        private void frm_category_list_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(showCategory);
            frm.Show();
            thread.Start("");
        }

        private void dgvCategory_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Settings.DataGridViewRowNum(dgvCategory, "col_lr");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (openAddCategoryForm != null)
            {
                openAddCategoryForm();
            }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if(e.ColumnIndex == dgvCategory.Columns["col_edit"].Index)
                {
                    tbl_category category = new tbl_category
                    {
                        cat_id = Convert.ToInt32(dgvCategory.CurrentRow.Cells["col_cat_id"].Value),
                        category = dgvCategory.CurrentRow.Cells["col_category"].Value.ToString(),
                        status = Convert.ToBoolean(dgvCategory.CurrentRow.Cells["col_status"].Value)
                    };
                    editCatgory(category);
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    Thread thread = new Thread(showCategory);
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
                    Thread thread = new Thread(showCategory);
                    frm.Show();
                    thread.Start("");
                }
            }
        }
    }
}
