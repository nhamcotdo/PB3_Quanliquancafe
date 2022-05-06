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
        public List<Food> GetFoodByGroupID(string id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Menu where GroupID='" + id + "'";
            DataTable data = DBHelper.Instance.GetRecords(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
    }
}