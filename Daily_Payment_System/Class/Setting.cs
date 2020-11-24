using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Daily_Payment_System.Class
{
    class Setting
    {
        public static SqlConnection connection = new SqlConnection(ConstantField.CONNECTION_STRING);

        public static bool testConnectionSuccess(string SERVER_IP,string DATABASE,string USER,string PASSWORD)
        {
            bool result = false;
            SqlConnection sqlConnection = new SqlConnection("Server=" + SERVER_IP + ";Database=" + DATABASE + ";User Id=" + USER + ";Password=" + PASSWORD + ";");
            try
            {
                sqlConnection.Open();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return result;
        }

        public static string getConnection()
        {
            string constr = "";
            try
            {
                //constr = @"metadata=res://*/DPS_Model.csdl|res://*/DPS_Model.csdl|res://*/DPS_Model.csdl;provider=System.Data.SqlClient;provider connection string=';data source=" + ConstantField.SERVER_IP + ";initial catalog=" + ConstantField.DATABASE + ";persist security info=True;user id=" + ConstantField.USER + ";password=" + ConstantField.PASSWORD + ";MultipleActiveResultSets=True;App=EntityFramework;Connection Timeout=500'";
                //constr = @"metadata=res://*/DPS_Model.csdl|res://*/DPS_Model.ssdl|res://*/DPS_Model.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=DailyPayment;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework&quot;";
                constr = "metadata=res://*/DPS_Model.csdl|res://*/DPS_Model.ssdl|res://*/DPS_Model.msl;provider=System.Data.SqlClient;provider connection string='data source =.; initial catalog = DailyPayment; user id = sa; password = 123456; MultipleActiveResultSets = True; App = EntityFramework'";
            }
            catch (Exception ex)
            {
                MsgBox.showWarning(ex.Message);
            }
            return constr;
        }

        public static void saveConnection(string serverip,string database,string user,string password)
        {
            Properties.Settings.Default.SERVER_IP = serverip;
            Properties.Settings.Default.DATABASE = database;
            Properties.Settings.Default.USER = user;
            Properties.Settings.Default.PASSWORD = password;
            Properties.Settings.Default.Save();
        }
    }
}
