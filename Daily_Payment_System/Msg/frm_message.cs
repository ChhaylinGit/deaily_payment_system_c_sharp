using Daily_Payment_System.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Payment_System.Msg
{
    public partial class frm_message : Form
    {
        private string messageContent = "";
        public bool ok = false;

        public frm_message()
        {
            InitializeComponent();
        }

        private void initMessageTitle(byte messageType)
        {
            switch (messageType)
            {
                case ConstantField.CODE_MSG_INFO:
                    lblMessageTitle.Text = ConstantField.TITLE_MSG_INFO;
                    break;
                case ConstantField.CODE_MSG_WARNING:
                    lblMessageTitle.Text = ConstantField.TITLE_MSG_WARNING;
                    break;
                case ConstantField.CODE_MSG_ERROR:
                    lblMessageTitle.Text = ConstantField.TITLE_MSG_ERROR;
                    break;
                case ConstantField.CODE_MSG_QUESTION:
                    lblMessageTitle.Text = ConstantField.TITLE_MSG_QUESTION;
                    break;
            }
        }

        private void initMessageIcon(byte messageType)
        {
            switch (messageType)
            {
                case ConstantField.CODE_MSG_INFO:
                    picIcon.Image = ConstantField.ICON_MSG_INFO;
                    break;
                case ConstantField.CODE_MSG_WARNING:
                    picIcon.Image = ConstantField.ICON_MSG_WARNINIG;
                    break;
                case ConstantField.CODE_MSG_ERROR:
                    picIcon.Image = ConstantField.ICON_MSG_ERROR;
                    break;
                case ConstantField.CODE_MSG_QUESTION:
                    picIcon.Image = ConstantField.ICON_MSG_QUESTION;
                    break;
            }
        }

        public frm_message(byte messageType,string messageContent)
        {
            InitializeComponent();
            this.messageContent = messageContent;
            initMessageTitle(messageType);
            initMessageIcon(messageType);
        }

        private void frm_message_Load(object sender, EventArgs e)
        {
            lblMessageContent.Text = this.messageContent;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ok = true;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
