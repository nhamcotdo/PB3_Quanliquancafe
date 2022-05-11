using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Bill
    {
        public string BillID { get; set; }
        public DateTime TimeCheckOut { get; set; }
        public int TotalBill { get; set; }
        public string DiscountID { get; set; }
        public int OtherFee { get; set; }
        public string TableID { get; set; }
        public string StaffID { get; set; }

        public Bill(DataRow dr)
        {
            BillID = dr["BillID"].ToString();
            TimeCheckOut = (DateTime)dr["TimeCheckOut"];
            TotalBill = (int)dr["TotalBill"];
            DiscountID = dr["DiscountID"].ToString();
            OtherFee = (int)dr["OtherFee"];
            TableID = dr["TableID"].ToString();
            StaffID = dr["StaffID"].ToString();
        }
        public Bill()
        {
        }
    }
}
