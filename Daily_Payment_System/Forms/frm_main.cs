using Daily_Payment_System.Config;
using Daily_Payment_System.Forms.Product;
using Daily_Payment_System.Msg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Payment_System.Forms
{
    public partial class frm_main : Form
    {
        private frm_exchange_rate exchange_rate;
        private frm_add_rate add_rate;
        private frm_message message;
        private frm_product_list product_List;
        private frm_add_product add_product;
        private frm_connection_config frm_connection;

        public frm_main()
        {
            InitializeComponent();
            initChildForm();
        }

        private void initChildForm()
        {
            
        }

        private void ShowMessageBox()
        {
            message = new frm_message();
            message.MdiParent = this;
            message.Show();
        }

        private void tsm_exchange_rate_Click(object sender, EventArgs e)
        {
            exchange_rate = new frm_exchange_rate();
            exchange_rate.MdiParent = this;
            exchange_rate.NotifyMainFormToOpenChildForm2 += NotifyMainFormToOpenChildForm2;
            exchange_rate.ShowMessageBox += ShowMessageBox;
            exchange_rate.Show();
        }

        private void NotifyMainFormToOpenChildForm2()
        {
            add_rate = new frm_add_rate();
            add_rate.MdiParent = this;
            add_rate.Show();
        }

        private void sub_tsm_product_Click(object sender, EventArgs e)
        {
            product_List = new frm_product_list();
            product_List.MdiParent = this;
            product_List.NotifyMainFormToOpenChildForm2 += NotifyMainFormToOpenForm2;
            product_List.TransfEvent += TransfEvent;
            product_List.Show();
        }

        private void NotifyMainFormToOpenForm2()
        {
            add_product = new frm_add_product();
            add_product.MdiParent = this;
            add_product.Show();
        }

        private void TransfEvent(vw_select_product product)
        {
            add_product = new frm_add_product(product);
            add_product.MdiParent = this;
            add_product.Show();
        }


        private void sub_tsm_change_database_Click(object sender, EventArgs e)
        {
            frm_connection = new frm_connection_config();
            frm_connection.MdiParent = this;
            frm_connection.Show();
        }
    }
}
