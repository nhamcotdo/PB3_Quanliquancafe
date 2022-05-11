using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Discount
    {
        public string DiscountID { get; set; }
        public string DisCountName { get; set; }
        public string Value { get; set; }

        public Discount(DataRow dr)
        {
            DiscountID = dr["DiscountID"].ToString();
            DisCountName = dr["DisCountName"].ToString();
            Value = dr["Value"].ToString();
        }
        public Discount()
        {
        }
    }
}
