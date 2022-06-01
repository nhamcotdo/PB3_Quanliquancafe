using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class DishGroupDAL
    {
        private static DishGroupDAL instance;
        public static DishGroupDAL Instance
        {
            get
            {
                if (instance == null) instance = new DishGroupDAL();
                return instance;
            }
            set { instance = value; }
        }
        private DishGroupDAL()
        {

        }

        public List<DishGroup> GetListDishGroup()
        {
            List<DishGroup> list = new List<DishGroup>();
            string query = "select * from DishGroup";
            DataTable data = DBHelper.Instance.GetRecords(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new DishGroup(item));
            }

            return list;
        }
    }
}