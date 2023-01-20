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

namespace Daily_Payment_System.Forms.Product
{
    public partial class frm_view_product_image : Form
    {
        private Byte[] bytes;
        private string title;
        public frm_view_product_image(Byte[] bytes,string title)
        {
            InitializeComponent();
            this.bytes = bytes;
            this.title = title;
        }

        private void frm_view_product_image_Load(object sender, EventArgs e)
        {
            this.Text = this.title;
            picProduct.Image = this.bytes != null ? Setting.CovertImage(this.bytes) : Properties.Resources.no_image;
        }
    }
}
