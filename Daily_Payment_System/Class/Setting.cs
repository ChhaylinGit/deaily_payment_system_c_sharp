using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public static void dataGridViewStyle(DataGridView dgv)
        {
            DataGridViewCellStyle sty_1 = new DataGridViewCellStyle();
            DataGridViewCellStyle sty_2 = new DataGridViewCellStyle();
            DataGridViewCellStyle sty_3 = new DataGridViewCellStyle();

            sty_1.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(224)), Convert.ToInt32(Convert.ToByte(224)), Convert.ToInt32(Convert.ToByte(224)));
            sty_1.Font = new System.Drawing.Font("Khmer OS Content", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
            sty_1.ForeColor = System.Drawing.SystemColors.WindowText;
            sty_1.SelectionBackColor = System.Drawing.Color.LightBlue;
            sty_1.SelectionForeColor = System.Drawing.Color.Black;
            sty_1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            sty_2.BackColor = System.Drawing.SystemColors.Control;
            sty_2.Font = new System.Drawing.Font("Khmer OS Content", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
            sty_2.ForeColor = System.Drawing.SystemColors.WindowText;
            sty_2.SelectionBackColor = System.Drawing.Color.LightBlue;
            sty_2.SelectionForeColor = System.Drawing.Color.Black;
            sty_2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            sty_3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sty_3.BackColor = System.Drawing.SystemColors.Control;
            sty_3.Font = new System.Drawing.Font("Khmer OS Content", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
            sty_3.ForeColor = System.Drawing.SystemColors.WindowText;
            sty_3.SelectionBackColor = System.Drawing.Color.LightBlue;
            sty_3.SelectionForeColor = System.Drawing.Color.Black;
            sty_3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.RowsDefaultCellStyle = sty_2;
            dgv.AlternatingRowsDefaultCellStyle = sty_1;
            dgv.ColumnHeadersDefaultCellStyle = sty_3;
            dgv.RowHeadersDefaultCellStyle = sty_3;
            dgv.ColumnHeadersHeight = 36;
            dgv.RowHeadersWidth = 45;
            dgv.RowTemplate.Height = 36;
            dgv.TabIndex = 0;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = System.Drawing.Color.White;
        }

    }
}
