using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Staff
    {
        public string StaffID { get; set; }
        public string StaffName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateIn { get; set; }
        public string ShiftID { get; set; }
        public bool Sex { get; set; }

        public Staff(DataRow dr)
        {
            StaffID = dr["StaffID"].ToString();
            StaffName = dr["StaffName"].ToString();
            PhoneNumber = dr["PhoneNumber"].ToString();
            Address = dr["Address"].ToString();
            DateIn = Convert.ToDateTime(dr["DateIn"]);
            ShiftID = dr["ShiftID"].ToString();
            Sex = Convert.ToBoolean(dr["Sex"].ToString());
        }
        public Staff()
        {

        }
    }
}
