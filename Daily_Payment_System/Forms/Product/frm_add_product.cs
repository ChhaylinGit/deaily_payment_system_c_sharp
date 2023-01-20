using Daily_Payment_System.Class;
using Daily_Payment_System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public frm_add_product()
        {
            InitializeComponent();
        }


        private void frm_add_product_Load(object sender, EventArgs e)
        {
            Utils.loadCategory(cboCategory,false);
        }

        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = Setting.RotateImage(img, angle);
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
                  
                }
            }
            else
            {
                picProduct.Image = Properties.Resources.no_image;
                lblLoadImage.Text = KH.BROWSE_IMAGE;
                lblLoadImage.LinkColor = Color.Blue;
                lblLoadImage.Tag = 0;
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
            try
            {
                if (!empty())
                {
                    byte[] b = imageToByteArray(image);
                    tbl_product product = new tbl_product();
                    product.pro_name = txtProduct.Text.Trim();
                    product.cat_id = Convert.ToInt32(cboCategory.SelectedValue);
                    if (!string.IsNullOrEmpty(imagePath)) { product.image = imageToByteArray(picProduct.Image); }
                    product.entry_date = DateTime.Now;
                    product.status = chkStatus.Checked;
                    ConstantField.entities.tbl_product.Add(product);
                    ConstantField.entities.SaveChanges();
                    MsgBox.showInfor(ConstantField.TEXT_MSG_INFO);
                }
            }
            catch (Exception ex)
            {
                MsgBox.showWarning(ex.Message);
            }
           
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
