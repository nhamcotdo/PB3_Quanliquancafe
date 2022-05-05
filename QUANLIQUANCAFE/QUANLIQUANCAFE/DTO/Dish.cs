using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Dish
    {
        public string DishID { get; set; }
        public string DishName { get; set; }   
        public string Price { get; set; }
        public Dish(DataRow dr)
        {
            DishID = dr["DishID"].ToString();
            DishName = dr["DishName"].ToString();
            Price = dr["Price"].ToString();
        }
    }
}
