using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class StaffDAL
    {
        private static StaffDAL instance;
        public static StaffDAL Instance
        {
            get
            {
                if (instance == null) instance = new StaffDAL();
                return instance;
            }
            private set { instance = value; }

        }
        private StaffDAL() { }

        public void ChangeInfo(Staff staff)
        {
            DBHelper.Instance.ExecuteDB(string.Format("Update Staff set StaffName = N'{0}', PhoneNumber = N'{1}', Address = N'{2}', DateIn = N'{3}', Sex = N'{4}' where StaffID = N'{5}'", staff.StaffName, staff.PhoneNumber, staff.Address, staff.DateIn, staff.Sex, staff.StaffID));
        }
        //public void UpdateStaff(Staff staff)
        //{
        //    DBHelper.Instance.ExecuteDB(string.Format("UPDATE [Staff] SET STAFFID=N'{0}',STAFFNAME=N'{1}',PHONE=N'{2}',ADDRESS=N'{3}',DATE=N'{4}',SHIFTID=N'{5}',SEX=N'{6}'", staff.StaffID, staff.StaffName, staff.PhoneNumber, staff.Address, staff.DateIn, staff.ShiftID, staff.Sex));
        //}

        public void UpdateStaff(string StaffID, string StaffName, int PhoneNumber, string Address, DateTime DateIn, string ShiftID, bool Sex)
        {
            string query = string.Format("UPDATE [Staff] SET STAFFNAME=N'{0}',PHONENUMBER=N'{1}',ADDRESS=N'{2}',DateIn=N'{3}',SHIFTID=N'{4}',SEX=N'{5}' WHERE StaffID=N'{6}'", StaffName, PhoneNumber, Address, DateIn, ShiftID, Sex, StaffID);
            DBHelper.Instance.ExecuteDB(query);
        }

        public void InsertStaff(string StaffID, string StaffName, int PhoneNumber, string Address, DateTime DateIn, string ShiftID, bool Sex)
        {
            string query = string.Format("Insert into Staff values('{0}',N'{1}','{2}',N'{3}',CONVERT(date, '{4}'),'{5}',{6})", StaffID, StaffName, PhoneNumber, Address, DateIn.ToString("yyyyMMdd"), ShiftID, Sex ? 1 : 0);
            DBHelper.Instance.ExecuteDB(query);

        }
        public void DelStaff(string StaffID)
        {
            DBHelper.Instance.ExecuteDB(string.Format("DELETE FROM [Staff] WHERE [StaffID] = N'{0}'", StaffID));
        }


    }
}