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
            string query = "SELECT DishName, Quantity, Price " +
                "FROM [Order] as D inner join" +
                " [Table] as B" +
                " on D.TableID = B.TableID inner join " +
                " [Menu] as A " +
                " on A.DishID = D.DishID" +
                " WHERE D.TableID = '" + ID + "'";
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
