using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAL();
                return instance;
            }
            private set { instance = value; }

        }
        private AccountDAL() { }
        public int fLogin(string account, string passWord)
        {
            DataTable result = DBHelper.Instance.GetRecords("SELECT Role FROM dbo.Account WHERE Account=N'" + account + "' AND Password=N'" + passWord + "'");
            if (result.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                return Convert.ToInt16(Convert.ToBoolean(result.Rows[0]["Role"]));
            }
        }
    }
}