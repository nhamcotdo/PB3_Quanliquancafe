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
        public int Value { get; set; }
        public bool Percent { get; set; }
        public bool Active { get; set; }

        public Discount(DataRow dr)
        {
            DiscountID = dr["DiscountID"].ToString();
            DisCountName = dr["DisCountName"].ToString();
            Value = (int)dr["Value"];
            Percent = Convert.ToBoolean(dr["Percent"].ToString().Trim());
            Active = Convert.ToBoolean(dr["Active"].ToString().Trim());
        }
        public Discount()
        {
        }
        public override string ToString()
        {
            return DisCountName;
        }
    }
}
