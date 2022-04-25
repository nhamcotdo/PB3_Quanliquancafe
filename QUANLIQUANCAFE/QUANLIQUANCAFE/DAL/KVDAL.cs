using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class KVDAL
    {
        private static KVDAL instance;

        public static KVDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KVDAL();
                return instance;
            }
            set => instance = value;
        }
        private KVDAL() { }
        public List<KV> LayDanhSachKV()
        {
            List<KV> list = new List<KV>();
            string query = "SELECT * FROM dbo.KhuVuc";
            DataTable data = DBHelper.Instance.GetRecords(query);
            foreach (DataRow item in data.Rows)
            {
                KV kv = new KV(item);
                list.Add(kv);
            }
            return list;
        }
    }
}
