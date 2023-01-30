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

namespace Daily_Payment_System.Forms.Suplier
{
    public partial class frm_add_suplier : Form
    {
        public frm_add_suplier()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btnSave.Tag) == 0)
            {
                save();
            }
            else
            {
                update();
            }
        }
        private void save()
        {
            try
            {
                tbl_supplier supplier = new tbl_supplier();
                supplier.spl_name = txtSuplier.Text.Trim();
                supplier.place = txtPlace.Text.Trim();
                supplier.entry_date = DateTime.Now;
                ConstantField.entities.tbl_supplier.Add(supplier);
                ConstantField.entities.SaveChanges();
                MsgBox.showInfor(ConstantField.TEXT_MSG_INFO);
                frm_suplier_list obj = (frm_suplier_list)Application.OpenForms["frm_suplier_list"];
                obj.dgvSuplier.DataSource = Utils.GetSuplier();
                txtSuplier.Clear();
                txtPlace.Clear();
                txtSuplier.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void update()
        {

        }
    }
}
