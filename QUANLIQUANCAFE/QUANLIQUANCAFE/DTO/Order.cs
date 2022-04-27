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
            DishName = dr["DishName"].ToString();
            Quantity = (int)dr["Quantity"];
            Price = (int)dr["Price"];
        }
    }
}
