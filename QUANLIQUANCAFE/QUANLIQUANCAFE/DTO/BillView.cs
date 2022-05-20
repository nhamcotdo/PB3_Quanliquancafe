using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class BillView
    {
        public String BillID { get; set; }
        public String TimeCheckOut { get; set; }
        public int TotalBill { get; set; }
        public string StaffName { get; set; }
        public BillView(DataRow row)
        {
            BillID = row["BillID"].ToString();
            TimeCheckOut = row["TimeCheckOut"].ToString();
            TotalBill = (int)row["TotalBill"];
            StaffName = row["StaffName"].ToString();
        }
    }
}
