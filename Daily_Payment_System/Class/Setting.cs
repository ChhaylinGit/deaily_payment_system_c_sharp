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
    }
}
