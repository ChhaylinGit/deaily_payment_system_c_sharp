using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

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
                constr = "metadata=res://*/DPS_Model.csdl|res://*/DPS_Model.ssdl|res://*/DPS_Model.msl;provider=System.Data.SqlClient;provider connection string='data source ="+ConstantField.SERVER_IP+"; initial catalog = "+ConstantField.DATABASE+"; user id = "+ConstantField.USER+"; password = "+ConstantField.PASSWORD+"; MultipleActiveResultSets = True; App = EntityFramework'";
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

        public static Image CovertImage(Byte[] photo)
        {
            Image newimg;
            using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newimg = Image.FromStream(ms, true);
            }
            return newimg;
        }


        public static void DataGridViewRowNum(DataGridView dataGridView,string colName)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Cells[colName].Value = i + 1;
            }
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
            //dgv.RowTemplate.Height = 90;
            dgv.TabIndex = 0;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = System.Drawing.Color.White;
        }
        public static Bitmap RotateImage(Image image, float angle)
        {
            return RotateImage(image, new PointF((float)image.Width / 2, (float)image.Height / 2), angle);
        }

        /// <summary>
        /// Creates a new Image containing the same image only rotated
        /// </summary>
        /// <param name="image">The <see cref="System.Drawing.Image"/> to rotate</param>
        /// <param name="offset">The position to rotate from.</param>
        /// <param name="angle">The amount to rotate the image, clockwise, in degrees</param>
        /// <returns>A new <see cref="System.Drawing.Bitmap"/> of the same size rotated.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if <see cref="image"/> is null.</exception>
        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }


    }
}
