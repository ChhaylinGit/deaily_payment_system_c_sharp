using Daily_Payment_System.Msg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Payment_System.Class
{
    class MsgBox
    {
        private static frm_message frm;

        public static void showInfor(string messageContent)
        {
            frm = new frm_message(ConstantField.CODE_MSG_INFO, messageContent);
            frm.ShowDialog();
        }

        public static void showWarning(string messageContent)
        {
            frm = new frm_message(ConstantField.CODE_MSG_WARNING, messageContent);
            frm.ShowDialog();
        }

        public static void showError(string messageContent)
        {
            frm = new frm_message(ConstantField.CODE_MSG_ERROR, messageContent);
            frm.ShowDialog();
        }
        public static bool showQuestion(string messageContent)
        {
            frm = new frm_message(ConstantField.CODE_MSG_QUESTION, messageContent);
            frm.btnExit.Visible = true;
            frm.ShowDialog();
            return frm.ok;
        }

    }
}
