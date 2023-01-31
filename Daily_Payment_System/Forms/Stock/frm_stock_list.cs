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

namespace Daily_Payment_System.Forms.Stock
{
    public partial class frm_stock_list : Form
    {
        frm_loading frm = new frm_loading();

        public frm_stock_list()
        {
            InitializeComponent();
        }

        private void showStock(object search)
        {
            var query = Utils.GetStock();
            if (!string.IsNullOrEmpty(search.ToString()))
            {
                query = query.Where(f => f.pro_name.ToLower().Contains(search.ToString().ToLower()) || f.category.ToLower().Contains(search.ToString().ToLower())).ToList();
            }
            this.BeginInvoke((MethodInvoker)(() =>
            {
                dgvStock.DataSource = query;
                frm.Hide();
            }));
        }


        private void frm_stock_list_Load(object sender, EventArgs e)
        {
            Class.Settings.dataGridViewStyle(dgvStock);
        }

        private void frm_stock_list_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(showStock);
            frm.Show();
            thread.Start("");
        }

        private void dgvStock_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Settings.DataGridViewRowNum(dgvStock, "col_lr");
        }
    }
}
