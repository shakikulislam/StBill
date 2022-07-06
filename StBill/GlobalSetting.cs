using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StBill.Properties;

namespace StBill
{
    public class GlobalSetting
    {
        //Variable
        public static string EmpUserName;
        public static string EmpName;
        public static string DateFormat = "dd-MMM-yy";
        public static string DateFormatView = "MMM-yy";

        //Method
        public static DateTime GetFirstDate(DateTime date)
        {
            var yearMonth = Convert.ToDateTime(date.ToString("Y"));
            return yearMonth;
        }
    }
}
