using Daily_Payment_System.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Payment_System.Config
{
    public partial class frm_connection_config : Form
    {
        public frm_connection_config()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(myThread);
            thread.Start();
        }

        private void myThread()
        {
            btnTestConnection.Invoke(new MethodInvoker(delegate { Cursor = Cursors.WaitCursor; btnTestConnection.Enabled = false; btnTestConnection.Text = "Connecting..."; }));
            if (Setting.testConnectionSuccess(txtServerIP.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text))
            {
                MsgBox.showInfor("Connection Success!");
            }
            else
            {
                MsgBox.showError("Connection Faild!");
            }
            btnTestConnection.Invoke(new MethodInvoker(delegate { Cursor = Cursors.Default; btnTestConnection.Enabled = true; btnTestConnection.Text = "Test Connection"; }));
        }
    }
}
