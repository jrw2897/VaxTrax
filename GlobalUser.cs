using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaxTrax_2._0_
{
    class GlobalUser
    {
        private static string v_UserID = "";

        public static string UserID
        {
            get { return v_UserID; }
            set { v_UserID = value; }
        }

        private static string v_Password = "";

        public static string Password
        {
            get { return v_Password; }
            set { v_Password = value; }
        }
    }
}
