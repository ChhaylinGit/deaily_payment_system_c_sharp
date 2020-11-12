using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Payment_System.Class
{
    class BaseConnection : DbContext
    {
        public BaseConnection(string conn) : base(conn)
        {
            try
            {

            }

            catch (Exception ex)
            {
                //Msg.Error("Cannot connect server");
            }

        }

    }
}
