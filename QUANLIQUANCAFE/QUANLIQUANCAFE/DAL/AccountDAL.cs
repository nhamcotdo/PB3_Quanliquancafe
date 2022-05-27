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
        //public void UpdateStaff(string StaffID, string Account, string PassWord)
        //{
        //    DBHelper.Instance.ExecuteDB("UPDATE [Staff] SET STAFFID=N'{0}',ACCOUNT=N'{1}',PASSWORD=N'{2}'", StaffID, Account, PassWord);
        //}

        public void InsertAccount(string StaffID, string Account, string PassWord)
        {
            string query = string.Format("Insert into Account values ('{0}','{1}','{2}',0)", StaffID, Account, PassWord);
            DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateAccount(string StaffID, string Account, string PassWord)
        {
            string query = string.Format("UPDATE [Account] SET Account = N'{0}', Password=N'{1}' WHERE StaffID=N'{2}' ", Account, PassWord, StaffID);
            DBHelper.Instance.ExecuteDB(query);
        }
        public void CheckAccount(string StaffID)
        {

            string query = string.Format("SELECT COUNT (StaffID) From [Account] WHERE StaffID =N'{0}'", StaffID);
            DBHelper.Instance.ExecuteDB(query);

        }

        public void DelStaff(string StaffID)
        {
            DBHelper.Instance.ExecuteDB(string.Format("DELETE FROM [Account] WHERE [StaffID] = N'{0}'", StaffID));
        }
    }
}