using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    public class TableDAL
    {
        static private TableDAL instance;

        static public TableDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAL();
                return instance;
            }
            private set => instance = value;
        }
        private TableDAL() { }
        public List<Table> GetListTableByAreaID(string AreaID = "")
        {
            List<Table> list = new List<Table>();
            string query = "SELECT * FROM [Table] WHERE AreaID = N'" + AreaID + "'";
            if (AreaID == "")
                query = "SELECT * FROM [Table]";
            DataTable data = DBHelper.Instance.GetRecords(query);
            foreach (DataRow item in data.Rows)
            {
                Table Table = new Table(item);
                list.Add(Table);
            }
            return list;
        }
        public void MoveTable(string oldTable, string newTable, bool isMergered = false)
        {
            string query = string.Format("UPDATE [Order] SET TableID = N'{0}' WHERE TableID = N'{1}'", newTable, oldTable);
            DBHelper.Instance.ExecuteDB(query);
            query = string.Format("UPDATE [Table] SET Status = N'{0}' WHERE TableID = N'{1}'", "true", newTable);
            DBHelper.Instance.ExecuteDB(query);
            if (!isMergered)
            {
                query = string.Format("UPDATE [Table] SET Status = N'{0}' WHERE TableID = N'{1}'", "false", oldTable);
                DBHelper.Instance.ExecuteDB(query);
            }
            else
            {
                query = string.Format("UPDATE [Table] SET Status = N'{0}' WHERE TableID = N'{1}'", "true", oldTable);
                DBHelper.Instance.ExecuteDB(query);

                string queryCheck = string.Format("Select * from Table where TableID = N'{0}' and Merge like '%{1}%'", newTable, oldTable);
                DataTable check = DBHelper.Instance.GetRecords(queryCheck);
                if (check.Rows.Count == 0)
                {
                    query = string.Format("UPDATE [Table] SET Merge = concat(Merge, N',{0}') WHERE TableID = N'{1}'", oldTable, newTable);
                    DBHelper.Instance.ExecuteDB(query);
                }
            }

        }
        public bool IsFreeTable(string TableID)
        {
            string query = string.Format("SELECT * FROM [Table] WHERE TableID = N'{0}'", TableID);
            DataTable data = DBHelper.Instance.GetRecords(query);
            if (data.Rows.Count > 0)
            {
                Table Table = new Table(data.Rows[0]);
                return Table.Status == false;
            }
            return false;
        }
    }
}
