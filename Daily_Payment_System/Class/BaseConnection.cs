using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Payment_System
{
    public partial class DailyPaymentEntities : DbContext
    {
        public DailyPaymentEntities(string conn) : base(conn)
        {
            try
            {

            }

            catch (Exception ex)
            {
                
            }

        }

    }
}
