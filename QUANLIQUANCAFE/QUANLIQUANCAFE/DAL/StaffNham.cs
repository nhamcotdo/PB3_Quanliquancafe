using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class StaffNham
    {
        private static StaffNham instance;
        public static StaffNham Instance
        {
            get
            {
                if (instance == null) instance = new StaffNham();
                return instance;
            }
            private set { instance = value; }

        }
        private StaffNham() { }

        public void ChangeInfo(Staff staff)
        {
            DBHelper.Instance.ExecuteDB(string.Format("Update Staff set StaffName = N'{0}', PhoneNumber = N'{1}', Address = N'{2}', DateIn = N'{3}', Sex = N'{4}' where StaffID = N'{5}'", staff.StaffName, staff.PhoneNumber, staff.Address, staff.DateIn, staff.Sex, staff.StaffID));
        }
    }
}