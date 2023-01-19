﻿using Daily_Payment_System.Class;
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
    public partial class frm_product_list : Form
    {
        public frm_product_list()
        {
            InitializeComponent();
        }

        private void frm_product_list_Load(object sender, EventArgs e)
        {
            Setting.dataGridViewStyle(dgvProduct);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_add_product add_product = new frm_add_product();
            add_product.MdiParent = this;
            add_product.Show();
            add_product.Focus();
        }
    }
}
