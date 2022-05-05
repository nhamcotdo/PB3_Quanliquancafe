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
        public int Price { get; set; }
        public string GroupID { get; set; }
        public string SizeID { get; set; }
        public Dish(DataRow dr)
        {
            DishID = dr["DishID"].ToString();
            DishName = dr["DishName"].ToString();
            Price = Convert.ToInt32(dr["Price"]);
            GroupID = dr["GroupID"].ToString();
            SizeID = dr["SizeID"].ToString();
        }
    }
}
