using QUANLIQUANCAFE.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{

    public class Order
    {
        public string DishName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Order(DataRow dr)
        {
            if (Quanli.Instance.langnow == "vi")
                DishName = dr["DishName"].ToString();
            else
                DishName = dr["DishNameEng"].ToString();
            Quantity = (int)dr["Quantity"];
            Price = (int)dr["Price"];
        }
    }
}
