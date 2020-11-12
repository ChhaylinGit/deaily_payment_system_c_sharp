﻿using System;
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

        public frm_main()
        {
            InitializeComponent();
            initChildForm();
        }

        private void initChildForm()
        {
            exchange_rate = new frm_exchange_rate();
            exchange_rate.MdiParent = this;
            exchange_rate.NotifyMainFormToOpenChildForm2 += NotifyMainFormToOpenChildForm2;
        }

        private void tsm_exchange_rate_Click(object sender, EventArgs e)
        {
            exchange_rate.Show();
        }

        private void NotifyMainFormToOpenChildForm2()
        {
            add_rate = new frm_add_rate();
            add_rate.MdiParent = this;
            add_rate.Show();
        }
    }
}
