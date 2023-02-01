using Daily_Payment_System.Config;
using Daily_Payment_System.Forms.Category;
using Daily_Payment_System.Forms.Product;
using Daily_Payment_System.Forms.Stock;
using Daily_Payment_System.Forms.Suplier;
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

        private frm_category_list frm_category;
        private frm_add_category add_category;

        private frm_suplier_list suplier_list;
        private frm_add_suplier add_suplier;

        private frm_stock_list stock_list;
        private frm_add_stock stock;

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

        private void sub_tsm_category_Click(object sender, EventArgs e)
        {
            frm_category = new frm_category_list();
            frm_category.MdiParent = this;
            frm_category.openAddCategoryForm += openAddCategoryForm;
            frm_category.editCatgory += editCatgory;
            frm_category.Show();
        }

        private void editCatgory(tbl_category category)
        {
            add_category = new frm_add_category(category);
            add_category.MdiParent = this;
            add_category.Show();
        }

        private void openAddCategoryForm()
        {
            add_category = new frm_add_category();
            add_category.MdiParent = this;
            add_category.Show();
        }

        private void sub_tsm_supplier_Click(object sender, EventArgs e)
        {
            suplier_list = new frm_suplier_list();
            suplier_list.MdiParent = this;
            suplier_list.openAddSuplierForm += openAddSuplierForm;
            suplier_list.editSuplier += editCatgory;
            suplier_list.Show();
        }

        private void editCatgory(tbl_supplier supplier)
        {
            add_suplier = new frm_add_suplier(supplier);
            add_suplier.MdiParent = this;
            add_suplier.Show();
        }

        private void openAddSuplierForm()
        {
            add_suplier = new frm_add_suplier();
            add_suplier.MdiParent = this;
            add_suplier.Show();
        }

        private void sub_tsm_stock_Click(object sender, EventArgs e)
        {
          
        }

        private void openProductListForm()
        {
            product_List = new frm_product_list();
            product_List.SelectProductEvent += SelectProductEvent;
            product_List.btnAdd.Visible = false;
            product_List.dgvProduct.Columns["col_edit"].Visible = false;
            product_List.dgvProduct.Columns["col_img"].Visible = false;
            product_List.dgvProduct.Columns["col_select"].Visible = true;
            product_List.MdiParent = this;
            product_List.Show();
        }

        private void SelectProductEvent(vw_select_product product)
        {
            stock.Close();
            stock = new frm_add_stock(product);
            stock.MdiParent = this;
            stock.Show();
            stock.openProductListForm += openProductListForm;
            product_List.Close();
        }

        private void sub_tsm_stock_infor_Click(object sender, EventArgs e)
        {
            stock_list = new frm_stock_list();
            stock_list.MdiParent = this;
            stock_list.Show();
        }

        private void sub_tsm_add_stock_Click(object sender, EventArgs e)
        {
            stock = new frm_add_stock();
            stock.MdiParent = this;
            stock.openProductListForm += openProductListForm;
            stock.Show();
        }
    }
}
