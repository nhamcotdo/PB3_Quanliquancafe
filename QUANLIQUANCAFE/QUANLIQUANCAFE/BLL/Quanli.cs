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

namespace QUANLIQUANCAFE.BLL
{
    public class Quanli
    {
        //Nhâm
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
                    listButton.Add(b);
                }
            }
            return listButton;

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
        public List<Table> GetListTableByAreaIDID(string AreaID = "")
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













































































































































        //ĐỨc//248






















































































































































        //Linh//399





































































































































































    }
}//566
