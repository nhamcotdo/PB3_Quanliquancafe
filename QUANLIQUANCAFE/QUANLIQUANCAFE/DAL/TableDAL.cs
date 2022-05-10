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
            DBHelper.Instance.ExecuteDB(string.Format("UPDATE [Order] SET TableID = N'{0}' WHERE TableID = N'{1}'", newTable, oldTable));
            DBHelper.Instance.ExecuteDB(string.Format("UPDATE [Table] SET Status = N'{0}' WHERE TableID = N'{1}'", "true", newTable));
            if (!isMergered)
            {
                DBHelper.Instance.ExecuteDB(string.Format("UPDATE [Table] SET Status = N'{0}' WHERE TableID = N'{1}'", "false", oldTable));
            }
            else
            {
                DBHelper.Instance.ExecuteDB(string.Format("UPDATE [Table] SET Status = N'{0}' WHERE TableID = N'{1}'", "true", oldTable));
                DataTable check = DBHelper.Instance.GetRecords(string.Format("Select * from [Table] where TableID = N'{0}' and MergeList like '%{1}%'", newTable, oldTable));
                if (check.Rows.Count == 0)
                {
                    DBHelper.Instance.ExecuteDB(string.Format("UPDATE [Table] SET MergeList = concat(MergeList, N',{0}') WHERE TableID = N'{1}'", oldTable, newTable));
                }
            }

        }
        public bool IsFreeTable(string TableID)
        {
            DataTable data = DBHelper.Instance.GetRecords(string.Format("SELECT * FROM [Table] WHERE TableID = N'{0}'", TableID));
            if (data.Rows.Count > 0)
            {
                Table Table = new Table(data.Rows[0]);
                return Table.Status == false;
            }
            return false;
        }
        public Table GetTableByID(string ID)
        {
            return new Table(DBHelper.Instance.GetRecords(string.Format("SELECT * FROM [Table] WHERE TableID = N'{0}'", ID)).Rows[0]);
        }
        public void DeleteTable(string ID)
        {
            DBHelper.Instance.ExecuteDB(string.Format("DELETE FROM [Table] WHERE TableID = N'{0}'", ID));
        }
        //get last tableID
        public string GetLastTableID()
        {
            DataTable data = DBHelper.Instance.GetRecords("SELECT TOP 1 * FROM [Table] ORDER BY TableID DESC");
            if (data.Rows.Count > 0)
            {
                Table Table = new Table(data.Rows[0]);
                return Table.TableID;
            }
            return "";
        }
        public void AddTable(string ID, string name, string areaID)
        {
            DBHelper.Instance.ExecuteDB(string.Format("INSERT INTO [Table] VALUES (N'{0}', N'{1}', N'{2}', N'{3}', '{4}')", ID, areaID, name, "false", ID));
        }
    }
}
