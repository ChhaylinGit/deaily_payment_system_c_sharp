using Daily_Payment_System.Class;
using Daily_Payment_System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Payment_System.Forms.Product
{
    public partial class frm_add_product : Form
    {
        private string imagePath = "";
        private Bitmap image = null;
        private float angle = 90.0f;
        public vw_select_product product = new vw_select_product();

       

        public frm_add_product()
        {
            InitializeComponent();
        }
        public frm_add_product(vw_select_product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void frm_add_product_Load(object sender, EventArgs e)
        {
            Utils.loadCategory(cboCategory,false);
            if(product.pro_id != 0)
            {
                cboCategory.SelectedValue = product.cat_id;
                txtProduct.Text = product.pro_name;
                picProduct.Image = product.image == null ? Properties.Resources.no_image : Settings.ConvertImage(product.image);
                btnSave.Tag = 1;
            }
        }

        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = Settings.RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private void lnlLoadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(Convert.ToInt32(lblLoadImage.Tag) == 0)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image(*.jpg; *.jpeg; *.bmp;)|*.jpg; *.jpeg; *.bmp;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    imagePath = open.FileName;
                    image = new Bitmap(imagePath);
                    picProduct.Image = (Bitmap)image.Clone();

                    //picProduct.LoadAsync(imagePath);
                    lblLoadImage.Text = KH.DELETE;
                    lblLoadImage.LinkColor = Color.Red;
                    lblLoadImage.Tag = 1;
                    btnLeft.Enabled = btnRight.Enabled = btnTop.Enabled = btnBottom.Enabled = true;
                }
            }
            else
            {
                picProduct.Image = Properties.Resources.no_image;
                lblLoadImage.Text = KH.BROWSE_IMAGE;
                lblLoadImage.LinkColor = Color.Blue;
                lblLoadImage.Tag = 0;
                btnLeft.Enabled = btnRight.Enabled = btnTop.Enabled = btnBottom.Enabled = false;
            }
        }

        private bool empty()
        {
            bool result = false;
            string str = "";
            if (string.IsNullOrEmpty(cboCategory.Text.Trim()) || cboCategory.SelectedIndex == -1)
            {
                str += "- សូមជ្រើសរើសប្រភេទទំនិញ!\n";
            }
            if (string.IsNullOrEmpty(txtProduct.Text.Trim()))
            {
                str += "- សូមបញ្ចូលឈ្មោះទំនិញ!";
            }
            if (!string.IsNullOrEmpty(str))
            {
                result = true;
                MsgBox.showWarning(str);
            }
            return result;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!empty())
            {
                if (Convert.ToInt16(btnSave.Tag) == 0)
                {
                    if (MsgBox.showQuestion(ConstantField.TEXT_MSG_ASK_FOR_INSERT))
                    {
                        save();
                        reset();
                        frm_product_list obj = (frm_product_list)Application.OpenForms["frm_product_list"];
                        obj.dgvProduct.DataSource = Utils.GetProducts();
                    }
                }
                else
                {
                    update();
                    reset();
                    frm_product_list obj = (frm_product_list)Application.OpenForms["frm_product_list"];
                    obj.dgvProduct.DataSource = Utils.GetProducts();
                }
               
            }
        }

        private void save()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                tbl_product product = new tbl_product();
                product.pro_name = txtProduct.Text.Trim();
                product.cat_id = Convert.ToInt32(cboCategory.SelectedValue);
                if (!string.IsNullOrEmpty(imagePath)) { product.image = imageToByteArray(picProduct.Image); }
                product.entry_date = DateTime.Now;
                product.status = chkStatus.Checked;
                ConstantField.entities.tbl_product.Add(product);
                ConstantField.entities.SaveChanges();
                MsgBox.showInfor(ConstantField.TEXT_MSG_INFO);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MsgBox.showWarning(ex.Message);
            }
        }

        private void update()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var query = ConstantField.entities.tbl_product.Where(f=>f.pro_id == product.pro_id).SingleOrDefault();
                query.pro_name = txtProduct.Text.Trim();
                query.cat_id = Convert.ToInt32(cboCategory.SelectedValue);
                if (!string.IsNullOrEmpty(imagePath)) { query.image = imageToByteArray(picProduct.Image); }
                query.edit_date = DateTime.Now;
                query.status = chkStatus.Checked;
                ConstantField.entities.Entry(query).State = EntityState.Modified;
                ConstantField.entities.SaveChanges();
                MsgBox.showInfor(ConstantField.TEXT_MSG_INFO);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MsgBox.showWarning(ex.Message);
            }
        }

        private void reset()
        {
            cboCategory.SelectedIndex = -1;
            txtProduct.Clear();
            picProduct.Image = Properties.Resources.no_image;
            lblLoadImage.Text = KH.BROWSE_IMAGE;
            lblLoadImage.LinkColor = Color.Blue;
            lblLoadImage.Tag = 0;
            btnLeft.Enabled = btnRight.Enabled = btnTop.Enabled = btnBottom.Enabled = false;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            RotateImage(picProduct, image, 360);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            RotateImage(picProduct, image, 180);
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            RotateImage(picProduct, image, 90);
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            RotateImage(picProduct, image, 270);
        }

        private void cboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProduct.Focus();
        }
    }
}
