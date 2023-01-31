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
        private tbl_supplier supplier = new tbl_supplier();
        public frm_add_suplier()
        {
            InitializeComponent();
        }

        public frm_add_suplier(tbl_supplier supplier)
        {
            InitializeComponent();
            this.supplier = supplier;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(btnSave.Tag) == 0)
            {
                if (!duplicate())
                {
                    save();
                }
                else
                {
                    MsgBox.showWarning(string.Format(ConstantField.DUPLICATE,"អ្នកផ្គត់ផ្គង់នេះ"));
                }
            }
            else
            {
                if (!duplicate())
                {
                    if (MsgBox.showQuestion(ConstantField.TEXT_MSG_ASK_FOR_UPDATE))
                    {
                        update();
                    }
                }
                else
                {
                    MsgBox.showWarning(string.Format(ConstantField.DUPLICATE, "អ្នកផ្គត់ផ្គង់នេះ"));
                }
            }
        }
        private void save()
        {
            try
            {
                tbl_supplier supplier = new tbl_supplier();
                supplier.spl_name = txtSuplier.Text.Trim();
                supplier.place = txtPlace.Text.Trim();
                supplier.status = chkStatus.Checked;
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
            try
            {
                tbl_supplier supplier = ConstantField.entities.tbl_supplier.Where(f => f.spl_id == this.supplier.spl_id).SingleOrDefault();
                supplier.spl_name = txtSuplier.Text.Trim();
                supplier.place = txtPlace.Text.Trim();
                supplier.status = chkStatus.Checked;
                supplier.edit_date = DateTime.Now;
                ConstantField.entities.SaveChanges();
                MsgBox.showInfor(ConstantField.TEXT_MSG_INFO);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool duplicate()
        {
            bool result = false;
            var query = ConstantField.entities.tbl_supplier.Where(f => f.spl_name.ToLower().Equals(txtSuplier.Text.ToLower()) && f.spl_id != supplier.spl_id).ToList();
            result = query.Count > 0;
            return result;
        }

        private void frm_add_suplier_Load(object sender, EventArgs e)
        {
            if (this.supplier.spl_id != 0)
            {
                txtSuplier.Text = supplier.spl_name;
                txtPlace.Text = supplier.place;
                chkStatus.Checked = supplier.status;
                btnSave.Tag = 1;
            }
        }
    }
}
