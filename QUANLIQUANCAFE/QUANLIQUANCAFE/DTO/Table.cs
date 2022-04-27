using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Table
    {
        public string TableID { get; set; }
        public string AreaID { get; set; }
        public string TableName { get; set; }
        public bool Status { get; set; }
        public List<string> Merge { get; set; }

        public Table(DataRow dr)
        {
            TableID = dr["TableID"].ToString();
            AreaID = dr["AreaID"].ToString();
            TableName = dr["TableName"].ToString();
            Status = (bool)dr["Status"];
            Merge = dr["Merge"].ToString().Split(',').ToList();
        }
    }
}
