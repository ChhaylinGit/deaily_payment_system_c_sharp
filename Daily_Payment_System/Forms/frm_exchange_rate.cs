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
    public partial class frm_exchange_rate : Form
    {
        public Action NotifyMainFormToOpenChildForm2;
        public frm_exchange_rate()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NotifyMainFormToOpenChildForm2();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            new frm_message().ShowDialog();
        }
    }
}
