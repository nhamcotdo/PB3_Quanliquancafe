using QUANLIQUANCAFE.BLL;
using QUANLIQUANCAFE.DAL;
using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLIQUANCAFE.GUI
{
    public partial class MainForm : Form
    {
        //Nhâm
        Quanli bll = new Quanli();
        Color c = Color.FromArgb(0, 255, 255);// Bàn trống
        Color c1 = Color.FromArgb(255, 255, 0);// Bàn đang được đặt

        public MainForm()
        {
            InitializeComponent();

            LoadComponent();
        }
        private void LoadComponent()
        {
            int w = this.flowLayout1.Width;
            //add KV to flowLayoutPanel
            foreach (FlowLayoutPanel i in bll.ListPanelKV(w, c, c1))
            {
                foreach (Control j in i.Controls)
                {
                    if (j is Button)
                    {
                        j.Click += new EventHandler(btnTable_Click);
                    }
                }
                this.flowLayout1.Controls.Add(i);
            }
            foreach (Ban i in bll.LayDanhSachBanTrong())
            {
                cbbtenban.Items.Add(new CBBItem(i.TenBan, i.MaBan));
            }
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetListOrderByTableID((sender as Button).Name);
            lbTenBan.Text = (sender as Button).Text;
            lbTenBan.Tag = (sender as Button).Name;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (cbbtenban.SelectedItem != null && lbTenBan.Tag != null && dataGridView1.Rows.Count > 0)
            {
                bll.MoveTable(lbTenBan.Tag.ToString(), ((CBBItem)cbbtenban.SelectedItem).Value.ToString());
                //change color
                foreach (Control i in flowLayout1.Controls)
                {
                    if (i is FlowLayoutPanel)
                    {
                        foreach (Control j in i.Controls)
                        {
                            if (j is Button)
                            {
                                if (((Button)j).Name == lbTenBan.Tag.ToString())
                                {
                                    (j as Button).BackColor = c;
                                }
                                else if (((Button)j).Name == ((CBBItem)cbbtenban.SelectedItem).Value.ToString())
                                {
                                    (j as Button).BackColor = c1;
                                }

                            }
                        }
                    }
                }
                lbTenBan.Text = ((CBBItem)cbbtenban.SelectedItem).Text;
                lbTenBan.Tag = ((CBBItem)cbbtenban.SelectedItem).Value;
                dataGridView1.DataSource = bll.GetListOrderByTableID(((CBBItem)cbbtenban.SelectedItem).Value);
            }
        }








































































































































































































        // ĐỨc//254








































































































































































































































        // Linh//487

















































































































































































    }//665
}
