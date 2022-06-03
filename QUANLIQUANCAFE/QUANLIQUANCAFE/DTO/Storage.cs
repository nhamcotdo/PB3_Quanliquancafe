using QUANLIQUANCAFE.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Storage
    {
        public string GrocID { get; set; }
        public string GrocName { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
        public DateTime DateCheckIn { get; set; }

        public Storage(DataRow dr)
        {
            GrocID = dr["GrocID"].ToString();
            if (Quanli.Instance.langnow == "vi")
                GrocName = dr["GrocName"].ToString();
            else
                GrocName = dr["GrocNameInEng"].ToString();
            Quantity = Convert.ToInt32(dr["Quantity"].ToString());
            Unit = dr["Unit"].ToString();
            Price = Convert.ToInt32(dr["Price"].ToString());
            DateCheckIn = Convert.ToDateTime(dr["TimeCheckIn"].ToString());
        }
    }


}
