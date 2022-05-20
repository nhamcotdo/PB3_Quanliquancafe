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
            //select MergeList

            foreach (string id in DBHelper.Instance.GetRecords(String.Format("SELECT MergeList FROM [Table] WHERE TableID = '{0}'", ID)).Rows[0][0].ToString().Split(',').Distinct())
            {
                DataTable data = DBHelper.Instance.GetRecords("SELECT DishName, Quantity, Price " +
                    "FROM [Order] as D inner join" +
                    " [Table] as B" +
                    " on D.TableID = B.TableID inner join " +
                    " [Menu] as A " +
                    " on A.DishID = D.DishID" +
                    " WHERE D.TableID = '" + id + "'");
                foreach (DataRow item in data.Rows)
                {
                    Order order = new Order(item);
                    list.Add(order);
                }
            }
            return list;
        }



        public void Order(string TableID, string dishID, int quantity)
        {

            DataTable qtt = DBHelper.Instance.GetRecords("SELECT Quantity FROM [Order] WHERE TableID = '" + TableID + "' AND DishID = '" + dishID + "'");
            if (qtt.Rows.Count > 0)
            {
                int q = int.Parse(qtt.Rows[0]["Quantity"].ToString());
                q += quantity;
                if (q > 0)
                    DBHelper.Instance.ExecuteDB("UPDATE [Order] SET Quantity = '" + q + "' WHERE TableID = '" + TableID + "' AND DishID = '" + dishID + "'");
                else
                    DBHelper.Instance.ExecuteDB("DELETE FROM [Order] WHERE TableID = '" + TableID + "' AND DishID = '" + dishID + "'");
                DBHelper.Instance.ExecuteDB("UPDATE [Table] SET Status = '" + true + "' WHERE TableID = '" + TableID + "'");
            }
            else
            {
                if (quantity <= 0)
                    return;
                DBHelper.Instance.ExecuteDB(string.Format("INSERT INTO [Order] VALUES ('{0}', '{1}', '{2}')", TableID, dishID, quantity));
                DBHelper.Instance.ExecuteDB("UPDATE [Table] SET Status = '" + true + "' WHERE TableID = '" + TableID + "'");
            }
        }
    }
}
