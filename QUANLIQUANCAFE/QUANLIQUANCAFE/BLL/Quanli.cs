using QUANLIQUANCAFE.DAL;
using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Collections;

namespace QUANLIQUANCAFE.BLL
{
    public class Quanli
    {
        //Nhâm
        public delegate void Mydel(object sender, EventArgs e);
        public Mydel d;
        private static Quanli instance;

        public static Quanli Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Quanli();
                }
                return instance;
            }
            set => instance = value;
        }

        public Bill GetBillByID(string billID)
        {
            return BillDAL.Instance.GetBillByID(billID);
        }

        public List<Bill> GetListBillByYearMonth(int Year, int Month = 0)
        {
            return BillDAL.Instance.GetListBillByYearMonth(Year, Month);

        }

        public List<BillView> SelectBillByDate(DateTime from, DateTime to)
        {
            return BillDAL.Instance.SelectBillByDate(from, to);
        }

        public void Pay(Bill bill)
        {
            BillDAL.Instance.Pay(bill);



        }

        public DataTable GetListOrderByBillID(string billID)
        {
            return BillDAL.Instance.GetListOrderByBillID(billID);
        }

        public void AddOrUpdateDiscount(Discount discount)
        {
            DiscountDAL.Instance.AddOrUpdateDiscount(discount);
        }

        public void ChangeInfo(Staff staff, AccountDTO accountDTO)
        {
            AccountDAL.Instance.ChangeInfo(accountDTO);
            StaffNham.Instance.ChangeInfo(staff);
        }

        //Table
        private List<Button> ListButtonTable(int w, string AreaID, Color c, Color c1)
        {
            List<Table> listTable = TableDAL.Instance.GetListTableByAreaID(AreaID);

            List<Button> listButton = new List<Button>();
            for (int i = 0; i < listTable.Count; i++)
            {
                if (listTable[i].AreaID == AreaID)
                {
                    Button b = new Button();
                    b.Text = listTable[i].TableName;
                    b.Width = w / 3 - 10;
                    b.Height = 50;
                    int mg = (int)(w - b.Width * 3) / 6;
                    b.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Name = listTable[i].TableID;
                    if (listTable[i].Status == true)
                    {
                        b.BackColor = c1;
                    }
                    else
                    {
                        b.BackColor = c;
                        //b.Text += "\n Bàn trống";
                    }
                    b.Click += new EventHandler(d);

                    listButton.Add(b);

                }

            }
            return listButton;

        }

        public Discount GetDiscountByID(string discountID)
        {
            return DiscountDAL.Instance.GetDiscountByID(discountID);
        }

        public Table GetTableByID(string tableID)
        {
            return TableDAL.Instance.GetTableByID(tableID);
        }

        public List<Area> GetListArea()
        {
            return AreaDAL.Instance.GetListArea();
        }


        public List<FlowLayoutPanel> ListPanelArea(int w, Color c, Color c1)
        {
            List<FlowLayoutPanel> listPanel = new List<FlowLayoutPanel>();
            List<Area> listArea = AreaDAL.Instance.GetListArea();

            foreach (Area item in listArea)
            {
                //creat panel for each Area
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Width = w;
                p.AutoSize = true;
                p.BackColor = Color.FromArgb(255, 255, 255);
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                p.Name = item.AreaID;
                p.Tag = item;
                //creat label for each Area
                Label l = new Label();
                l.Text = item.AreaName;
                l.Font = new Font("Arial", 12, FontStyle.Bold);
                l.Width = w;
                l.Height = 50;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                l.Name = item.AreaID;
                //add label to panel
                p.Controls.Add(l);
                //add button  to each panel, ench line 3 button
                foreach (Button btn in ListButtonTable(w, item.AreaID, c, c1))
                {
                    p.Controls.Add(btn);

                }

                listPanel.Add(p);
            }

            return listPanel;
        }
        public List<Table> GetListTableByAreaID(string AreaID = "")
        {
            return TableDAL.Instance.GetListTableByAreaID(AreaID);
        }
        public List<Order> GetListOrderByTableID(string id)
        {
            return OrderDAL.Instance.GetListOrderByTableID(id);
        }
        public void MoveTable(string oldTable, string newTable, bool isMerge = false)
        {
            TableDAL.Instance.MoveTable(oldTable, newTable, isMerge);
        }
        public bool IsFreeTable(string id)
        {
            return TableDAL.Instance.IsFreeTable(id);
        }
        public void DeleteTable(string id)
        {
            TableDAL.Instance.DeleteTable(id);
        }
        public String NewTableID()
        {
            string lastID = TableDAL.Instance.GetLastTableID();
            string lastIDNumber = lastID.Substring(lastID.Length - 2, 2);
            int lastIDNumberInt = int.Parse(lastIDNumber);
            lastIDNumberInt++;
            string newIDNumber = lastIDNumberInt.ToString();
            if (newIDNumber.Length == 1)
            {
                newIDNumber = "0" + newIDNumber;
            }
            return lastID.Substring(0, 2) + newIDNumber;
        }
        public string NewBillID()
        {
            string s = (Convert.ToInt32(BillDAL.Instance.GetLastBillID()) + 1).ToString();
            while (s.Length < 4)
            {
                s = "0" + s;
            }
            return s;
        }
        public void AddTable(string name, string areaID)
        {
            string ID = NewTableID();
            TableDAL.Instance.AddTable(ID, name, areaID);
        }
        public string NewAreaID()
        {
            string lastID = AreaDAL.Instance.GetLastAreaID();//0001
            string newID = "";
            if (lastID == "")
            {
                newID = "0001";
            }
            else
            {
                int id = int.Parse(lastID.Substring(2, lastID.Length - 2)) + 1;
                newID = id.ToString();
                if (newID.Length == 1)
                {
                    newID = "000" + newID;
                }
                else if (newID.Length == 2)
                {
                    newID = "00" + newID;
                }
            }

            return newID;
        }
        public void AddArea(string name, string ID = "")
        {
            if (ID == "")
            {
                ID = NewAreaID();
            }
            AreaDAL.Instance.AddArea(ID, name);
        }
        public List<Discount> GetAllDiscount(bool Active = true)
        {
            return DiscountDAL.Instance.GetAllDiscount(Active);
        }
        public string TranslateText(string input, string from, string to)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
            from, to, Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }
        public string NewDiscountID()
        {
            string s = "00" + (Convert.ToInt32(DiscountDAL.Instance.GetLastID()) + 1).ToString();
            return s.Substring(s.Length - 3, 3);
        }



































        //ĐỨc//248


        public Staff fLogin(string account, string passWord)
        {
            return AccountDAL.Instance.fLogin(account, passWord);
        }
        public AccountDTO GetAccountByStaffID(string id)
        {
            return AccountDAL.Instance.GetAccountByStaffID(id);
        }












































































































































        //Linh//399

        public void AddDish(string DishID, string DishName, int price, string group, string size)
        {
            DishDAL.Instance.AddDish(DishID, DishName, price, group, size);
        }
        public void DelDish(string id)
        {
            DishDAL.Instance.DelDish(id);
        }


        public void Order(string TableID, string DishID, int Quantity)
        {
            OrderDAL.Instance.Order(TableID, DishID, Quantity);
        }
        public void UpdateStorage(string grocID, string grocName, string quantity, string unit, int price, string dateCheckIn)
        {
            StorageDAL.Instance.Update(grocID, grocName, quantity, unit, price, dateCheckIn);
        }

        public bool CheckDatetime(string id, string datetime)
        {
            if (StorageDAL.Instance.CheckID(id))
                return StorageDAL.Instance.CheckDateTime(datetime);
            return false;
        }
        public int GetQuantityByID(string id)
        {
            return StorageDAL.Instance.GetQuantityByID(id);
        }
        public void AddStorage(string grocID, string grocName, string quantity, string unit, int price, string dateCheckIn)
        {
            StorageDAL.Instance.AddStorage(grocID, grocName, quantity, unit, price, dateCheckIn);
        }
    }






















































































































































}//566