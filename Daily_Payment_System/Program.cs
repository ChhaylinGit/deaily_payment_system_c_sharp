using Daily_Payment_System.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Daily_Payment_System.Class;
using Daily_Payment_System.Config;

namespace Daily_Payment_System
{
    static class Program
    {
        private static bool connectionSuccess()
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(ConstantField.CONNECTION_STRING);
            try
            {
                connection.Open();
                result = true;
            }
            catch (Exception ex)
            {
                MsgBox.showError(ex.ToString());
            }
            finally
            {
                connection.Close();   
            }
            return result;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (connectionSuccess())
            {
                Application.Run(new frm_main());
            }
            else {
                Application.Run(new frm_connection_config());
            }
            
        }
    }
}
