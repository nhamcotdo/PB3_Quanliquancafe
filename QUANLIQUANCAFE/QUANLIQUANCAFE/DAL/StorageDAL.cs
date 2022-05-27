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

        public bool CheckID(string id)
        {
            string query = string.Format("SELECT * FROM [STORAGE] WHERE GrocID = N'{0}'", id);
            return DBHelper.Instance.GetRecords(query).Rows.Count > 0;
        }

        public bool CheckDateTime(string datetime)
        {
            DateTime time = Convert.ToDateTime(datetime);
            string query = string.Format("SELECT * FROM [STORAGE] WHERE TimeCheckIn = N'{0}'", time.Date);
            return DBHelper.Instance.GetRecords(query).Rows.Count > 0;
        }

        public int GetQuantityByID(string id)
        {
            int quant;
            string query = string.Format("Select Quantity from [STORAGE] WHERE GrocID = N'{0}'", id);
            quant = Convert.ToInt32(DBHelper.Instance.GetRecords(query).Rows[0][0].ToString());
            return quant;
        }

        public void AddStorage(string grocID, string grocName, string quantity, string unit, int price, string dateCheckIn)
        {
            string query = string.Format("Insert into [STORAGE] values (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')", grocID, grocName, quantity, unit, price, dateCheckIn);
            DBHelper.Instance.ExecuteDB(query);
        }
        public void AddStorageWithBatch(string grocID, string grocName, string quantity, string unit, int price, string dateCheckIn, int batch)
        {
            string query = string.Format("Insert into [STORAGE] values (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}')", grocID, grocName, quantity, unit, price, dateCheckIn, batch);
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}
