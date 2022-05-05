using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class DishDAL
    {
        private static DishDAL instance;

        public static DishDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DishDAL();
                return instance;
            }
            set => instance = value;
        }
        private DishDAL() { }
        public List<Dish> GetListArea()
        {
            List<Dish> list = new List<Dish>();
            DataTable data = DBHelper.Instance.GetRecords("SELECT * FROM [Area]");
            foreach (DataRow item in data.Rows)
            {
                Dish dish = new Dish(item);
                list.Add(dish);
            }
            return list;
        }

        public void AddDish(string dishID, string dishName, int price, string group, string size)
        {
            string query = string.Format("INSERT INTO [Menu] VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", dishID, dishName, price, group, size);
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}
