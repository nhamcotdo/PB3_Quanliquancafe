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


        public MainForm(bool Role)
        {
            InitializeComponent();
            LoadComponent();
            LoadDishGroup();
            if (!Role)
            {
                quảnLíToolStripMenuItem.Enabled = false;
            }

        }
        private void LoadComponent()
        {
            int w = this.flowLayout1.Width;
            //add Area to flowLayoutPanel
            flowLayout1.Controls.Clear();
            Quanli.Instance.d = new Quanli.Mydel(btnTable_Click);
            foreach (FlowLayoutPanel i in Quanli.Instance.ListPanelArea(w, c, c1))
            {
                this.flowLayout1.Controls.Add(i);
            }
            cbbTableName.Items.Clear();
            foreach (DTO.Table i in Quanli.Instance.GetListTableByAreaID())
            {
                cbbTableName.Items.Add(new CBBItem(i.TableName, i.TableID));
            }
            cbbTableName.SelectedIndex = 0;
            lbTableName.Text = (cbbTableName.SelectedItem as CBBItem).Text;
            lbTableName.Tag = (cbbTableName.SelectedItem as CBBItem).Value;
            LoadOrder(lbTableName.Tag.ToString());
        }
        void LoadOrder(string tableID)
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[] {
                new DataColumn("Tên món", typeof(string)),
                new DataColumn("Số lượng", typeof(string)),
                new DataColumn("Đơn giá", typeof(string)),
                new DataColumn("Thành tiền", typeof(int))
            });

            foreach (Order i in Quanli.Instance.GetListOrderByTableID(tableID))
            {
                data.Rows.Add(i.DishName, i.Quantity, i.Price, i.Price * i.Quantity);
            }
            dataGridView1.DataSource = data;
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            LoadOrder((sender as Button).Name.ToString());
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
                            if (Quanli.Instance.IsFreeTable(j.Name))
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
            if (!Quanli.Instance.IsFreeTable(((CBBItem)cbbTableName.SelectedItem).Value))
            {
                MessageBox.Show("Bàn đang có khách");
                return;
            }
            //kiểm tra xem có bàn nào được chọn không
            if (lbTableName.Tag != null && dataGridView1.Rows.Count > 0)
            {
                //chuyển dữ liệu
                Quanli.Instance.MoveTable(lbTableName.Tag.ToString(), ((CBBItem)cbbTableName.SelectedItem).Value.ToString());
                StatusTable();
                lbTableName.Text = ((CBBItem)cbbTableName.SelectedItem).Text;
                lbTableName.Tag = ((CBBItem)cbbTableName.SelectedItem).Value;
                dataGridView1.DataSource = Quanli.Instance.GetListOrderByTableID(((CBBItem)cbbTableName.SelectedItem).Value);
            }
        }
        // Gộp hóa đơn từ bàn chọn trong combox vào vào đang hiển thị
        private void btnMerge_Click(object sender, EventArgs e)
        {
            //chuyển dữ liệu
            Quanli.Instance.MoveTable(((CBBItem)cbbTableName.SelectedItem).Value.ToString(), lbTableName.Tag.ToString(), true);
            StatusTable();
            dataGridView1.DataSource = Quanli.Instance.GetListOrderByTableID(lbTableName.Tag.ToString());

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Table selectedTable = new Table(lbTableName.Tag.ToString());
            if (selectedTable.Status)
            {
                MessageBox.Show("Bàn đang có khách! Không thể xóa");
                return;
            }
            // messagebox confirm
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Quanli.Instance.DeleteTable(lbTableName.Tag.ToString());
                LoadComponent();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTable f = new AddTable();
            f.d = new AddTable.Mydel(LoadComponent);
            f.Show();
        }














































































































































































































        // ĐỨc//254


        void LoadDishGroup()
        {
            List<DishGroup> listDishGroup = DishGroupDAL.Instance.GetListDishGroup();
            foreach (DishGroup i in listDishGroup)
            {
                cbbDishGroup.Items.Add(new CBBItem(i.GroupName.TrimEnd(), i.GroupID));
            }
            cbbDishGroup.SelectedIndex = 0;
        }

        void LoadFoodListByDishGroupID(string id)
        {
            cbbFoodMenu.Items.Clear();
            List<Food> listFood = FoodDAL.Instance.GetFoodByGroupID(id);
            foreach (Food i in listFood)
            {
                Console.WriteLine(i.DishName);
                cbbFoodMenu.Items.Add(new CBBItem(i.DishName, i.DishID));
            }
            cbbFoodMenu.SelectedIndex = 0;
        }

        private void cbbDishGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            LoadFoodListByDishGroupID((cbbDishGroup.SelectedItem as CBBItem).Value);
        }










































































































































































































        // Linh//487

        private void button2_Click(object sender, EventArgs e)
        {
            string Warning = "Bạn chưa chọn món để xóa";
            if (dataGridView1.SelectedRows.Count == 0) MessageBox.Show(Warning);
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Quanli.Instance.DelDish(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    LoadComponent();
                }
            }
        }

        private void editMenu_cCick(object sender, EventArgs e)
        {
            ShowMenu f = new ShowMenu();
            f.d = new ShowMenu.Mydel(LoadDishGroup);
            f.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Quanli.Instance.Order(lbTableName.Tag.ToString(), (cbbFoodMenu.SelectedItem as CBBItem).Value, (int)numericUpDown1.Value);
            LoadOrder(lbTableName.Tag.ToString());
        }
    }//665
}
