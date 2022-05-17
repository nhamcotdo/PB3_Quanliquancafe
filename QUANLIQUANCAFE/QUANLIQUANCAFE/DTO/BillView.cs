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
        String BillID { get; set; }
        String TimeCheckOut { get; set; }
        int TotalBill { get; set; }
        string StaffName { get; set; }
        public BillView(DataRow row)
        {
            BillID = row["BillID"].ToString();
            TimeCheckOut = row["TimeCheckOut"].ToString();
            TotalBill = (int)row["TotalBill"];
            StaffName = row["StaffName"].ToString();
        }
    }
}
