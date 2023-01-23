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

        private bool empty()
        {
            bool result = false;
            string message = "";
            if (string.IsNullOrEmpty(txtServerIP.Text.Trim()))
            {
                message += "- សូមបញ្ចូលSERVER_IP\n";
            }
            if (string.IsNullOrEmpty(txtDatabase.Text.Trim()))
            {
                message += "- សូមបញ្ចូលDATABASE\n";
            }
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                message += "- សូមបញ្ចូលUSER\n";
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                message += "- សូមបញ្ចូលPASSWORD";
            }
            if (!string.IsNullOrEmpty(message))
            {
                result = true;
                MsgBox.showWarning(message);
            }
            return result;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (!empty())
            {
                Thread thread = new Thread(testConnectionThread);
                thread.Start();
            }
        }

        private void testConnectionThread()
        {
            btnTestConnection.Invoke(new MethodInvoker(delegate { Cursor = Cursors.WaitCursor; btnTestConnection.Enabled = false; btnSave.Enabled = false; btnTestConnection.Text = "Connecting..."; }));
            if (Settings.testConnectionSuccess(txtServerIP.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text))
            {
                MsgBox.showInfor("Connection Success!");
            }
            else
            {
                MsgBox.showError("Connection Faild!");
            }
            btnTestConnection.Invoke(new MethodInvoker(delegate { Cursor = Cursors.Default; btnTestConnection.Enabled = true; btnSave.Enabled = true; btnTestConnection.Text = "Test Connection"; }));
        }

        private void saveConnectionThread()
        {
            btnSave.Invoke(new MethodInvoker(delegate { Cursor = Cursors.WaitCursor; btnSave.Enabled = false; btnTestConnection.Enabled = false; btnSave.Text = "Saving..."; }));
            if (Settings.testConnectionSuccess(txtServerIP.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text))
            {
                btnSave.Invoke(new MethodInvoker(delegate { Cursor = Cursors.Default; btnTestConnection.Enabled = false; btnSave.Text = "Connected"; }));
                Settings.saveConnection(txtServerIP.Text.Trim(), txtDatabase.Text.Trim(), txtUser.Text.Trim(), txtPassword.Text.Trim());
                MsgBox.showInfor("Connection Success!");
            }
            else
            {
                btnSave.Invoke(new MethodInvoker(delegate { Cursor = Cursors.Default; btnSave.Enabled = true; btnTestConnection.Enabled = true; btnSave.Text = "រក្សាទុក"; }));
                MsgBox.showError("Connection Faild!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!empty())
            {
                Thread thread = new Thread(saveConnectionThread);
                thread.Start();
            }
        }
          
    }
}
