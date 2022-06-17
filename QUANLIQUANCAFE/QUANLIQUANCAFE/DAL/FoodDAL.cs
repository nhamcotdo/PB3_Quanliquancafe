using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class FoodDAL
    {
        private static FoodDAL instance;
        public static FoodDAL Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAL();
                return instance;
            }
            set { instance = value; }
        }

        private FoodDAL()
        {

        }
        public List<Dish> GetFoodByGroupID(string id)
        {
            List<Dish> list = new List<Dish>();
            string query = "select * from Menu where GroupID='" + id + "'";
            DataTable data = DBHelper.Instance.GetRecords(query);
            foreach (DataRow item in data.Rows)
            {
                Dish food = new Dish(item);
                list.Add(food);
            }
            return list;
        }
    }
}