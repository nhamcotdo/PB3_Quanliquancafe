using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                DBHelper.Instance.ExecuteDB(String.Format("Insert into Data VALUES('{0}', N'{1}', N'{2}', N'{3}', N'{4}')", bill.BillID, i.DishName, i.Quantity, bill.TimeCheckOut, i.Price));
            }
            foreach (string id in DBHelper.Instance.GetRecords(String.Format("SELECT MergeList FROM [Table] WHERE TableID = '{0}'", bill.TableID)).Rows[0][0].ToString().Split(','))
            {
                DBHelper.Instance.ExecuteDB(String.Format("Delete from [Order] where TableID = '{0}'", id));
                DBHelper.Instance.ExecuteDB(string.Format("Update [Table] set Status = 'false', MergeList = N'{0}' where TableID = '{0}'", id));
            }

        }

        public List<Bill> GetListBillByYearMonth(int year, int month = 0)
        {
            List<Bill> l = new List<Bill>();
            if (month < 1 || month > 12)
            {
                foreach (DataRow row in DBHelper.Instance.GetRecords(String.Format("Select * from Bill where YEAR(TimeCheckOut) = {0}", year)).Rows)
                {
                    l.Add(new Bill(row));
                }
            }
            else
            {
                foreach (DataRow row in DBHelper.Instance.GetRecords(String.Format("Select * from Bill where MONTH(TimeCheckOut) = {0} and YEAR(TimeCheckOut) = {1}", month, year)).Rows)
                {
                    l.Add(new Bill(row));
                }
            }
            return l;

        }

        public Bill GetBillByID(string billID)
        {
            return new Bill(DBHelper.Instance.GetRecords(string.Format("Select * from Bill where BillID = '{0}'", billID)).Rows[0]);
        }

        public DataTable GetListOrderByBillID(string billID)
        {
            return DBHelper.Instance.GetRecords(string.Format("Select * from Data where BillID = '{0}'", billID));
        }

        public List<BillView> SelectBillByDate(DateTime from, DateTime to)
        {
            List<BillView> listBill = new List<BillView>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(string.Format("Select Bill.BillID, Bill.TimeCheckOut, Bill.TotalBill, Staff.StaffName from Bill, Staff where Bill.StaffID = Staff.StaffID and TimeCheckOut between '{0}' and '{1}'", from, to)).Rows)
            {
                BillView bill = new BillView(i);
                listBill.Add(bill);
            }

            return listBill;
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
