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

namespace Daily_Payment_System.Forms
{
    public partial class frm_add_rate : Form
    {
        
        public frm_add_rate()
        {
            InitializeComponent();
        }

        private void frm_add_rate_Load(object sender, EventArgs e)
        {
           
        }
      
        private bool saveExchangeRate()
        {
            bool result = false;
            try
            {
                tbl_daily_rate rate = new tbl_daily_rate();
                rate.b_sale_out = Convert.ToDecimal(msk_1_sale_out.Text.Trim());
                rate.b_buy_in = Convert.ToDecimal(msk_1_buy_in.Text.Trim());
                rate.s_sale_out = Convert.ToDecimal(msk_2_sale_out.Text.Trim());
                rate.s_buy_in = Convert.ToDecimal(msk_2_buy_in.Text.Trim());
                rate.create_date = DateTime.Now.Date;
                ConstantField.entities.tbl_daily_rate.Add(rate);
                result = ConstantField.entities.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                MsgBox.showWarning(ex.Message);
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveExchangeRate())
            {
                MsgBox.showInfor("ប្រតិបត្តិការទទួលបានជោគជ័យ");
            }
        }
    }
}
