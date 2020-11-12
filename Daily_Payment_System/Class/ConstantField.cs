﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Payment_System.Class
{
    class ConstantField
    {
        public const byte CODE_MSG_INFO = 1;
        public const byte CODE_MSG_WARNING = 2;
        public const byte CODE_MSG_ERROR = 3;
        public const byte CODE_MSG_QUESTION = 4;

        public const string TITLE_MSG_INFO = "Information";
        public const string TITLE_MSG_WARNING = "Warning";
        public const string TITLE_MSG_ERROR = "Error";
        public const string TITLE_MSG_QUESTION = "Question";

        public static Image ICON_MSG_INFO = Properties.Resources.infor;
        public static Image ICON_MSG_WARNINIG = Properties.Resources.warning;
        public static Image ICON_MSG_ERROR = Properties.Resources.error;
        public static Image ICON_MSG_QUESTION = Properties.Resources.question;

    }
}