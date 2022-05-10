﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{

    public class BillDAL
    {
        private static BillDAL instance;
        public static BillDAL Instance
        {
            get { if (instance == null) instance = new BillDAL(); return instance; }
            private set { instance = value; }

        }
        private BillDAL() { }

        public void Pay(string tableID, string billID)
        {

        }

        public string GetLastBillID()
        {
            //get last bill id
            if (DBHelper.Instance.GetRecords("SELECT * FROM Bill").Rows.Count == 0)
                return "0000";
            return DBHelper.Instance.GetRecords("SELECT * FROM Bill").Rows[DBHelper.Instance.GetRecords("SELECT * FROM Bill").Rows.Count - 1]["ID"].ToString();
        }
    }
}
