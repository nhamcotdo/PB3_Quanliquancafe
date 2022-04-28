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
            DataTable data = DBHelper.Instance.GetRecords("SELECT * FROM [Area]");
            foreach (DataRow item in data.Rows)
            {
                Area Area = new Area(item);
                list.Add(Area);
            }
            return list;
        }
        public string GetLastAreaID()
        {
            return DBHelper.Instance.GetRecords("SELECT TOP 1 [AreaID] FROM [Area] ORDER BY [AreaID] DESC").Rows[0][0].ToString();
        }
        public void AddArea(string AreaID, string AreaName)
        {
            string query = string.Format("INSERT INTO [Area] VALUES (N'{0}', N'{1}', N'{2}')", AreaID, AreaName, false);
            DBHelper.Instance.ExecuteDB(query);
        }

    }
}
