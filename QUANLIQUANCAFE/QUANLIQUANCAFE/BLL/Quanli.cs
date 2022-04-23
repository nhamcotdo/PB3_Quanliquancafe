using QUANLIQUANCAFE.DAL;
using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
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
        private List<Button> ListButtonBan(int w, string mkv, Color c)
        {
            List<Ban> listBan = DB.Instance.GetAllListBan();
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
                    b.Name = listBan[i].MaBan;
                    if (listBan[i].TrangThai == true)
                    {
                        b.BackColor = Color.Green;
                    }
                    else
                    {
                        b.BackColor = c;
                    }
                    //b.Click += new EventHandler(b_Click);
                    listButton.Add(b);
                }
            }
            return listButton;

        }

        public List<FlowLayoutPanel> ListPanelKV(int w, Color c)
        {
            List<FlowLayoutPanel> listPanel = new List<FlowLayoutPanel>();
            List<KV> listKV = DB.Instance.GetAllListKV();

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
                //p.Click += new EventHandler(p_Click);
                //creat label for each KV
                Label l = new Label();
                l.Text = item.TenKV;
                l.Font = new Font("Arial", 12, FontStyle.Bold);
                l.Width = w;
                l.Height = 50;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                l.Name = item.MaKV;
                //l.Click += new EventHandler(p_Click);
                //add label to panel
                p.Controls.Add(l);
                Button b = new Button();
                b.Text = "Thêm bàn";
                b.Width = w / 3 - 10;
                b.Height = 50;
                int mg = (int)(w - b.Width * 3) / 6;
                b.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
                b.Name = "btnThemBan" + item.MaKV;
                b.BackColor = Color.White;
                //b.Click += new EventHandler(b_Click);
                p.Controls.Add(b);
                //add button  to each panel, ench line 3 button
                foreach (Button btn in ListButtonBan(w, item.MaKV, c))
                {
                    p.Controls.Add(btn);
                }

                listPanel.Add(p);
            }

            return listPanel;
        }

























































































































































        //ĐỨc//248






















































































































































        //Linh//399





































































































































































    }
}//566
