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

namespace Daily_Payment_System.Forms.Suplier
{
    public partial class frm_suplier_list : Form
    {
        public Action openAddSuplierForm;
        public delegate void OnEditSuplier(tbl_supplier supplier);
        public event OnEditSuplier editSuplier;
        frm_loading frm = new frm_loading();
        public frm_suplier_list()
        {
            InitializeComponent();
        }

        private void showSuplier(object search)
        {
            var query = Utils.GetSuplier();
            if (!string.IsNullOrEmpty(search.ToString()))
            {
                query = query.Where(f => f.spl_name.ToLower().Contains(search.ToString().ToLower()) || f.place.ToLower().Contains(search.ToString().ToLower())).ToList();
            }
            this.BeginInvoke((MethodInvoker)(() =>
            {
                dgvSuplier.DataSource = query;
                frm.Hide();
            }));
        }

        private void frm_suplier_list_Load(object sender, EventArgs e)
        {
            Class.Settings.dataGridViewStyle(dgvSuplier);
        }

        private void frm_suplier_list_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(showSuplier);
            frm.Show();
            thread.Start("");
        }

        private void dgvSuplier_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Settings.DataGridViewRowNum(dgvSuplier, "col_lr");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (openAddSuplierForm != null)
            {
                openAddSuplierForm();
            }
        }

        private void dgvSuplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgvSuplier.Columns["col_edit"].Index)
                {
                    tbl_supplier supplier = new tbl_supplier
                    {
                        spl_id = Convert.ToInt32(dgvSuplier.CurrentRow.Cells["col_spl_id"].Value),
                        spl_name = dgvSuplier.CurrentRow.Cells["col_spl"].Value.ToString(),
                        place = dgvSuplier.CurrentRow.Cells["col_place"].Value.ToString(),
                        status = Convert.ToBoolean(dgvSuplier.CurrentRow.Cells["col_status"].Value)
                    };
                    editSuplier(supplier);
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    Thread thread = new Thread(showSuplier);
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
                    Thread thread = new Thread(showSuplier);
                    frm.Show();
                    thread.Start("");
                }
            }
        }
    }
}
