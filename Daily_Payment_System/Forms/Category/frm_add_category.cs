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

namespace Daily_Payment_System.Forms.Category
{
    public partial class frm_add_category : Form
    {
        private tbl_category category = new tbl_category();

        public frm_add_category()
        {
            InitializeComponent();
        }

        public frm_add_category(tbl_category category)
        {
            InitializeComponent();
            this.category = category;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(Convert.ToInt16(btnSave.Tag) == 0)
            {
                save();
            }
            else
            {
                if (MsgBox.showQuestion(ConstantField.TEXT_MSG_ASK_FOR_UPDATE))
                {
                    update();
                }
            }
        }

        private void save()
        {
            try
            {
                tbl_category category = new tbl_category();
                category.category = txtCategory.Text.Trim();
                category.status = chkStatus.Checked;
                category.entry_date = DateTime.Now;
                ConstantField.entities.tbl_category.Add(category);
                ConstantField.entities.SaveChanges();
                MsgBox.showInfor(ConstantField.TEXT_MSG_INFO);
                frm_category_list obj = (frm_category_list)Application.OpenForms["frm_category_list"];
                obj.dgvCategory.DataSource = Utils.GetCategories();
                txtCategory.Clear();
                txtCategory.Focus();
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
                tbl_category category = ConstantField.entities.tbl_category.Where(f => f.cat_id == this.category.cat_id).SingleOrDefault();
                category.category = txtCategory.Text.Trim();
                category.status = chkStatus.Checked;
                category.edit_date = DateTime.Now;
                ConstantField.entities.SaveChanges();
                MsgBox.showInfor(ConstantField.TEXT_MSG_INFO);
                frm_category_list obj = (frm_category_list)Application.OpenForms["frm_category_list"];
                obj.dgvCategory.DataSource = Utils.GetCategories();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_add_category_Load(object sender, EventArgs e)
        {
            if(this.category.cat_id != 0)
            {
                txtCategory.Text = category.category;
                chkStatus.Checked = category.status;
                btnSave.Tag = 1;
            }
        }
    }
}
