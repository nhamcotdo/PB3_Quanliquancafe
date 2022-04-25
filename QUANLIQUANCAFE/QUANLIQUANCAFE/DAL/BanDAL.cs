using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class BanDAL
    {
        static private BanDAL instance;

        static public BanDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BanDAL();
                return instance;
            }
            private set => instance = value;
        }
        private BanDAL() { }
        public List<Ban> LayDanhSachBanTheoKhuVuc(string mkv = "")
        {
            List<Ban> list = new List<Ban>();
            string query = "SELECT * FROM dbo.Ban WHERE MaKV = N'" + mkv + "'";
            if (mkv == "")
                query = "SELECT * FROM dbo.Ban";
            DataTable data = DBHelper.Instance.GetRecords(query);
            foreach (DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                list.Add(ban);
            }
            return list;
        }
        public List<Ban> LayDanhSachBanTrong()
        {
            List<Ban> list = new List<Ban>();
            string query = "SELECT * FROM dbo.Ban where TrangThai = N'false'";
            DataTable data = DBHelper.Instance.GetRecords(query);
            foreach (DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                list.Add(ban);
            }
            return list;
        }
        public void MoveTable(string oldTable, string newTable)
        {
            string query = string.Format("UPDATE dbo.DatMon SET MaBan = N'{0}' WHERE MaBan = N'{1}'", newTable, oldTable);
            DBHelper.Instance.ExecuteDB(query);
            query = string.Format("UPDATE dbo.Ban SET TrangThai = N'{0}' WHERE MaBan = N'{1}'", "false", oldTable);
            DBHelper.Instance.ExecuteDB(query);
            query = string.Format("UPDATE dbo.Ban SET TrangThai = N'{0}' WHERE MaBan = N'{1}'", "true", newTable);
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}
