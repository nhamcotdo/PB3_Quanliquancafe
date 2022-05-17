using QUANLIQUANCAFE.DTO;
using System;
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

        public void Pay(Bill bill)
        {
            DBHelper.Instance.ExecuteDB(String.Format("INSERT INTO Bill VALUES('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}')", bill.BillID, bill.TimeCheckOut, bill.TotalBill, bill.DiscountID, bill.OtherFee, bill.TableID, bill.StaffID));
            foreach (Order i in OrderDAL.Instance.GetListOrderByTableID(bill.TableID))
            {
                DBHelper.Instance.ExecuteDB(String.Format("Insert into Data VALUES('{0}', N'{1}', N'{2}', N'{3}')", bill.BillID, i.DishName, i.Quantity, bill.TimeCheckOut));
            }
            DBHelper.Instance.ExecuteDB(String.Format("Delete from [Order] where TableID = '{0}'", bill.TableID));
            DBHelper.Instance.ExecuteDB(string.Format("Update [Table] set Status = 'false' where TableID = '{0}'", bill.TableID));
        }

        public List<BillView> SelectBillByDate(DateTime from, DateTime to)
        {
            DBHelper.Instance.GetRecords(string.Format("Select Bill.BillID, Bill.TimeCheckOut, Bill.TotalBill Staff.StaffName from Bill, Staff where and Bill.StaffID = Staff.StaffID and TimeCheckOut between '{0}' and '{1}'", from, to));
        }

        public string GetLastBillID()
        {
            //get last bill id
            if (DBHelper.Instance.GetRecords("SELECT * FROM Bill").Rows.Count == 0)
                return "0000";
            return DBHelper.Instance.GetRecords("SELECT * FROM Bill").Rows[DBHelper.Instance.GetRecords("SELECT * FROM Bill").Rows.Count - 1]["BillID"].ToString();
        }
    }
}
