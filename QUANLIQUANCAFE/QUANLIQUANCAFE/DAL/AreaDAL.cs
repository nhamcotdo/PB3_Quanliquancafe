using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class AreaDAL
    {
        private static AreaDAL instance;

        public static AreaDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AreaDAL();
                return instance;
            }
            set => instance = value;
        }
        private AreaDAL() { }
        public List<Area> GetListArea()
        {
            List<Area> list = new List<Area>();
            string query = "SELECT * FROM [Area]";
            DataTable data = DBHelper.Instance.GetRecords(query);
            foreach (DataRow item in data.Rows)
            {
                Area Area = new Area(item);
                list.Add(Area);
            }
            return list;
        }
    }
}
