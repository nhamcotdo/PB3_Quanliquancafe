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
    public class OrderDAL
    {
        static private OrderDAL instance;

        static public OrderDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private OrderDAL() { }
        public List<Order> GetListOrderByTableID(string ID)
        {
            List<Order> list = new List<Order>();
            string query = "SELECT TenMon, SoLuong, DonGia " +
                "FROM DatMon as D inner join" +
                " Ban as B" +
                " on D.MaBan = B.MaBan inner join " +
                " DoAn as A " +
                " on A.MaMon = D.MaMon" +
                " WHERE D.MaBan = '" + ID + "'";
            DataTable data = DBHelper.Instance.GetRecords(query);
            //MessageBox.Show(data.Rows.Count.ToString());
            foreach (DataRow item in data.Rows)
            {
                Order order = new Order(item);
                list.Add(order);
            }
            return list;
        }

    }
}
