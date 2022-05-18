using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLIQUANCAFE.DTO;

namespace QUANLIQUANCAFE.DAL
{
    public class StorageDAL
    {
        static private StorageDAL instance;

        static public StorageDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StorageDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private StorageDAL() { }
        public void Update(string grocID, string grocName, string quantity, string unit, int price, string dateCheckIn)
        {
            DateTime d = Convert.ToDateTime(dateCheckIn);
            string query = string.Format("UPDATE [STORAGE] SET GrocName = N'{0}', Quantity = N'{1}',"
                         + "Unit = N'{2}', Price = N'{3}', TimeCheckIn = N'{4}' WHERE GrocID = N'{5}'", grocName, quantity, unit, price, d, grocID);
            DBHelper.Instance.ExecuteDB(query);
        }

        public bool CheckDateTime(string id, string datetime)
        {
            string query = string.Format("SELECT * FROM [STORAGE] WHERE GrocID = N'{0}'", id);
            return DBHelper.Instance.GetRecords(query).Rows.Count > 0;
        }
    }
}
