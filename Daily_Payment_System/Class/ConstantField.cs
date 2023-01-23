using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Payment_System.Class
{
   public static class ConstantField
    {
        public const byte CODE_MSG_INFO = 1;
        public const byte CODE_MSG_WARNING = 2;
        public const byte CODE_MSG_ERROR = 3;
        public const byte CODE_MSG_QUESTION = 4;

        public const string TITLE_MSG_INFO = "Information";
        public const string TITLE_MSG_WARNING = "Warning";
        public const string TITLE_MSG_ERROR = "Error";
        public const string TITLE_MSG_QUESTION = "Question";

        public const string TEXT_MSG_INFO = "ប្រតិបត្តការណ៍ទទួលបានជោគជ័យ!";
        public const string TEXT_MSG_ASK_FOR_INSERT = "តើលោកអ្នកពិតជាចង់បញ្ចូលមែនឬទេ?";

        public static Image ICON_MSG_INFO = Properties.Resources.infor;
        public static Image ICON_MSG_WARNINIG = Properties.Resources.warning;
        public static Image ICON_MSG_ERROR = Properties.Resources.error;
        public static Image ICON_MSG_QUESTION = Properties.Resources.question;

        public static string SERVER_IP = Properties.Settings.Default.SERVER_IP;
        public static string DATABASE = Properties.Settings.Default.DATABASE;
        public static string USER = Properties.Settings.Default.USER;
        public static string PASSWORD = Properties.Settings.Default.PASSWORD;
        public static string CONNECTION_STRING = "Server="+ SERVER_IP + ";Database="+ DATABASE + ";User Id="+ USER + ";Password="+ PASSWORD + ";";
        public static DailyPaymentEntities entities = new DailyPaymentEntities(Settings.getConnection());

    }
}
