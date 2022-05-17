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

        public List<Discount> GetAllDiscount()
        {
            List<Discount> list = new List<Discount>();
            foreach (DataRow item in DBHelper.Instance.GetRecords("SELECT * FROM Discount").Rows)
            {
                //Console.WriteLine("1" + item["Type"].ToString() + "1");
                list.Add(new Discount(item));
            }
            return list;
        }
    }
}