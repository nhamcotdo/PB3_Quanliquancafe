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
        private List<Button> ListButtonBan(int w, string mkv, Color c, Color c1)
        {
            List<Ban> listBan = BanDAL.Instance.LayDanhSachBanTheoKhuVuc(mkv);

            List<Button> listButton = new List<Button>();
            for (int i = 0; i < listBan.Count; i++)
            {
                if (listBan[i].MaKV == mkv)
                {
                    Button b = new Button();
                    b.Text = listBan[i].TenBan;
                    b.Width = w / 3 - 10;
                    b.Height = 50;
                    int mg = (int)(w - b.Width * 3) / 6;
                    b.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Name = listBan[i].MaBan;
                    if (listBan[i].TrangThai == true)
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



        public List<FlowLayoutPanel> ListPanelKV(int w, Color c, Color c1)
        {
            List<FlowLayoutPanel> listPanel = new List<FlowLayoutPanel>();
            List<KV> listKV = KVDAL.Instance.LayDanhSachKV();

            foreach (KV item in listKV)
            {
                //creat panel for each KV
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Width = w;
                p.AutoSize = true;
                p.BackColor = Color.FromArgb(255, 255, 255);
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                p.Name = item.MaKV;
                p.Tag = item;
                //creat label for each KV
                Label l = new Label();
                l.Text = item.TenKV;
                l.Font = new Font("Arial", 12, FontStyle.Bold);
                l.Width = w;
                l.Height = 50;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                l.Name = item.MaKV;
                //add label to panel
                p.Controls.Add(l);
                //add button  to each panel, ench line 3 button
                foreach (Button btn in ListButtonBan(w, item.MaKV, c, c1))
                {
                    p.Controls.Add(btn);

                }

                listPanel.Add(p);
            }

            return listPanel;
        }
        public List<Ban> LayDanhSachBanTheoMaKV(string MKV = "")
        {
            return BanDAL.Instance.LayDanhSachBanTheoKhuVuc(MKV);
        }
        public List<Order> GetListOrderByTableID(string id)
        {
            return OrderDAL.Instance.GetListOrderByTableID(id);
        }
        public void MoveTable(string oldTable, string newTable)
        {
            BanDAL.Instance.MoveTable(oldTable, newTable);
        }
        public List<Ban> LayDanhSachBanTrong()
        {
            return BanDAL.Instance.LayDanhSachBanTrong();
        }

























































































































































        //ĐỨc//248






















































































































































        //Linh//399





































































































































































    }
}//566
