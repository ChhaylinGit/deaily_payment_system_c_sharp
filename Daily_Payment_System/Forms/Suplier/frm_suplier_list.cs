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
                query = query.Where(f => f.spl_name.ToLower().Contains(search.ToString().ToLower())).ToList();
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
    }
}
