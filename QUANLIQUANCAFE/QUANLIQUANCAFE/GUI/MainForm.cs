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
            //add Area to flowLayoutPanel
            foreach (FlowLayoutPanel i in bll.ListPanelArea(w, c, c1))
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
            cbbTableName.Items.Clear();
            foreach (DTO.Table i in bll.GetListTableByAreaIDID())
            {
                cbbTableName.Items.Add(new CBBItem(i.TableName, i.TableID));
            }
            cbbTableName.SelectedIndex = 0;
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[] {
                new DataColumn("Tên món", typeof(int)),
                new DataColumn("Số lượng", typeof(string)),
                new DataColumn("Đơn giá", typeof(string)),
                new DataColumn("Thành tiền", typeof(int))
            });

            foreach (Order i in bll.GetListOrderByTableID((sender as Button).Name))
            {
                data.Rows.Add(i.DishName, i.Quantity, i.Price, i.Price * i.Quantity);
            }
            dataGridView1.DataSource = data;
            lbTableName.Text = (sender as Button).Text;
            lbTableName.Tag = (sender as Button).Name;
        }
        private void StatusTable()
        {
            foreach (Control i in flowLayout1.Controls)
            {
                if (i is FlowLayoutPanel)
                {
                    foreach (Control j in i.Controls)
                    {
                        if (j is Button)
                        {
                            if (bll.IsFreeTable(j.Name))
                            {
                                ((Button)j).BackColor = c;
                            }
                            else
                            {
                                ((Button)j).BackColor = c1;
                            }
                        }
                    }
                }
            }
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            //kiểm tra bàn đang được chọn có trống không
            if (!bll.IsFreeTable(((CBBItem)cbbTableName.SelectedItem).Value))
            {
                MessageBox.Show("Bàn đang có khách");
                return;
            }
            //kiểm tra xem có bàn nào được chọn không
            if (lbTableName.Tag != null && dataGridView1.Rows.Count > 0)
            {
                //chuyển dữ liệu
                bll.MoveTable(lbTableName.Tag.ToString(), ((CBBItem)cbbTableName.SelectedItem).Value.ToString());
                StatusTable();
                lbTableName.Text = ((CBBItem)cbbTableName.SelectedItem).Text;
                lbTableName.Tag = ((CBBItem)cbbTableName.SelectedItem).Value;
                dataGridView1.DataSource = bll.GetListOrderByTableID(((CBBItem)cbbTableName.SelectedItem).Value);
            }
        }
        // Gộp hóa đơn từ bàn chọn trong combox vào vào đang hiển thị
        private void btnMerge_Click(object sender, EventArgs e)
        {
            //chuyển dữ liệu
            bll.MoveTable(((CBBItem)cbbTableName.SelectedItem).Value.ToString(), lbTableName.Tag.ToString(), true);
            StatusTable();
            dataGridView1.DataSource = bll.GetListOrderByTableID(lbTableName.Tag.ToString());

        }












































































































































































































        // ĐỨc//254








































































































































































































































        // Linh//487

















































































































































































    }//665
}
