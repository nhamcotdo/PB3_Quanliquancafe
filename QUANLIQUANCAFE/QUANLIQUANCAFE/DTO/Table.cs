﻿using QUANLIQUANCAFE.DAL;
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
        public string TableNameInEng { get; set; }
        public bool Status { get; set; }
        public List<string> Merge { get; set; }
        public string MergeString { get; set; }


        public Table(DataRow dr)
        {
            TableID = dr["TableID"].ToString();
            AreaID = dr["AreaID"].ToString();
            TableName = dr["TableName"].ToString();
            TableNameInEng = dr["TableNameInEng"].ToString();
            Status = (bool)dr["Status"];
            Merge = dr["MergeList"].ToString().Split(',').ToList();
            MergeString = dr["MergeList"].ToString();
        }
        public Table(string ID)
        {
            Table temp = TableDAL.Instance.GetTableByID(ID);
            TableID = temp.TableID;
            AreaID = temp.AreaID;
            TableName = temp.TableName;
            Status = temp.Status;
            Merge = temp.Merge;
        }
    }
}
