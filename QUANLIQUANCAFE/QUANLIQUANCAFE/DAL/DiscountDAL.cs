using QUANLIQUANCAFE.DAL;
using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QUANLIQUANCAFE.BLL
{
    public class DiscountDAL
    {
        private static DiscountDAL instance;

        public static DiscountDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DiscountDAL();
                return instance;
            }
            private set => instance = value;
        }
        private DiscountDAL() { }

        public List<Discount> GetAllDiscount(bool Active = true)
        {
            List<Discount> list = new List<Discount>();

            if (Active)
            {
                foreach (DataRow item in DBHelper.Instance.GetRecords("SELECT * FROM Discount where Active = N'true'").Rows)
                {
                    //Console.WriteLine("1" + item["Type"].ToString() + "1");
                    list.Add(new Discount(item));
                }
            }
            else
            {
                foreach (DataRow item in DBHelper.Instance.GetRecords("SELECT * FROM Discount").Rows)
                {
                    //Console.WriteLine("1" + item["Type"].ToString() + "1");
                    list.Add(new Discount(item));
                }
            }
            return list;
        }

        public Discount GetDiscountByID(string discountID)
        {
            return new Discount(DBHelper.Instance.GetRecords("SELECT * FROM Discount WHERE DiscountID = '" + discountID + "'").Rows[0], true);
        }
        public string GetLastID()
        {
            return DBHelper.Instance.GetRecords(string.Format("SELECT TOP 1 DiscountID FROM Discount ORDER BY DiscountID DESC")).Rows[0][0].ToString();
        }

        public void AddOrUpdateDiscount(Discount discount)
        {
            try
            {
                DBHelper.Instance.ExecuteDB(string.Format("INSERT INTO Discount VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')",
                    discount.DiscountID, discount.DisCountName, discount.Value, discount.DisCountNameEn, discount.Percent, discount.Active));
            }
            catch (Exception e)
            {
                DBHelper.Instance.ExecuteDB(string.Format("UPDATE Discount SET DiscountID = N'{0}', DisCountName = N'{1}', Value = N'{2}', [Percent] = N'{3}', Active = N'{4}' WHERE DiscountID = N'{5}'",
                    discount.DiscountID, discount.DisCountName, discount.Value, discount.Percent, discount.Active, discount.DiscountID));
                Console.WriteLine(string.Format("UPDATE Discount SET DiscountID = N'{0}', DisCountName = N'{1}', Value = N'{2}', [Percent] = N'{3}', Active = N'{4}' WHERE DiscountID = N'{5}'",
                    discount.DiscountID, discount.DisCountName, discount.Value, discount.Percent, discount.Active, discount.DiscountID));

            }
        }
    }
}