using QUANLIQUANCAFE.DTO;
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
        public Staff GetStaffByStaffID(string StaffID)
        {
            return new Staff(DBHelper.Instance.GetRecords("SELECT *  FROM dbo.Staff WHERE StaffID = '" + StaffID + "'").Rows[0]);
        }
        public Staff fLogin(string account, string passWord)
        {
            if (DBHelper.Instance.GetRecords("SELECT * FROM dbo.Account WHERE Account = '" + account + "' AND Password = '" + passWord + "'").Rows.Count > 0)
            {
                return GetStaffByStaffID(DBHelper.Instance.GetRecords("SELECT * FROM dbo.Account WHERE Account = '" + account + "' AND Password = '" + passWord + "'").Rows[0]["StaffID"].ToString());
            }
            else
            {
                return null;
            }
        }
        public AccountDTO GetAccountByStaffID(string StaffID)
        {
            return new AccountDTO(DBHelper.Instance.GetRecords("SELECT * FROM dbo.Account WHERE StaffID = '" + StaffID + "'").Rows[0]);
        }

        public void ChangeInfo(AccountDTO accountDTO)
        {
            DBHelper.Instance.ExecuteDB("UPDATE dbo.Account SET Account = '" + accountDTO.Account + "', Password = '" + accountDTO.Password + "' WHERE StaffID = '" + accountDTO.StaffID + "'");
        }
    }
}