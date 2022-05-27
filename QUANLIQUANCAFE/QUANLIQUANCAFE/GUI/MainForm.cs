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
        Staff staff;
        string langnow = "vi";
        string lang = "vi";

        public MainForm(Staff Role)
        {
            staff = Role;
            InitializeComponent();
            LoadComponent();
            LoadDishGroup();
            if (!Quanli.Instance.GetAccountByStaffID(staff.StaffID).Role)
            {
                quảnLíToolStripMenuItem.Enabled = false;
            }
            lbNameNV.Text = staff.StaffName;
        }
        private void LoadComponent()
        {
            int w = this.flowLayoutTable.Width;
            //add Area to flowLayoutPanel
            flowLayoutTable.Controls.Clear();
            Quanli.Instance.d = new Quanli.Mydel(btnTable_Click);
            foreach (FlowLayoutPanel i in Quanli.Instance.ListPanelArea(w, c, c1))
            {
                this.flowLayoutTable.Controls.Add(i);
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
            if (langnow == lang)
                return;
            langnow = lang;
            if (lang == "en")
            {

                foreach (ToolStripMenuItem i in menuStrip1.Items)
                {
                    i.Text = Quanli.Instance.TranslateText(i.Text, "vi", "en");
                    foreach (ToolStripMenuItem j in i.DropDownItems)
                    {
                        j.Text = Quanli.Instance.TranslateText(j.Text, "vi", "en");
                    }
                }

                // đổi ngôn ngữ button
                btnOrder.Text = "Order";
                btnPay.Text = "Pay";
                btnMove.Text = "Move";
                btnMerge.Text = "Merge";
                btnAdd.Text = "Add";
                btnDel.Text = "Delete";

                //đổi ngôn ngữ Danh sách bàn
                label1.Text = "List Table";
                foreach (FlowLayoutPanel i in flowLayoutTable.Controls)
                {

                    foreach (Control j in i.Controls)
                    {
                        j.Text = Quanli.Instance.TranslateText(j.Text, "vi", "en");
                    }


                }
                MessageBox.Show("Language has been changed successfully!");
            }
            else
            {
                foreach (ToolStripMenuItem i in menuStrip1.Items)
                {
                    i.Text = Quanli.Instance.TranslateText(i.Text, "en", "vi");
                    foreach (ToolStripMenuItem j in i.DropDownItems)
                    {
                        j.Text = Quanli.Instance.TranslateText(j.Text, "en", "vi");
                    }
                }

                btnOrder.Text = "Gọi món";
                btnPay.Text = "Thanh toán";
                btnMove.Text = "Chuyển bàn";
                btnMerge.Text = "Gộp bàn";
                btnAdd.Text = "Thêm món";
                btnDel.Text = "Xóa món";

                label1.Text = "Danh sách bàn";
                foreach (FlowLayoutPanel i in flowLayoutTable.Controls)
                {

                    foreach (Control j in i.Controls)
                    {
                        j.Text = Quanli.Instance.TranslateText(j.Text, "en", "vi");
                    }


                }


                MessageBox.Show("Đổi ngôn ngữ thành công!");
            }
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
            foreach (Control i in flowLayoutTable.Controls)
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
            dataGridView1.Columns[0].HeaderText = "Tên món";
            dataGridView1.Columns[1].HeaderText = "Số lượng";
            dataGridView1.Columns[2].HeaderText = "Đơn giá";
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

        // đổi ngôn ngữ
        private void ToolStripMenuITiengViet_Click(object sender, EventArgs e)
        {
            lang = "vi";

            LoadComponent();
        }

        private void ToolStripMenuItemenglish_Click(object sender, EventArgs e)
        {
            lang = "en";
            LoadComponent();
        }


        private void toolstripChangeInfo_Click(object sender, EventArgs e)
        {
            new ChangeInfo(staff).Show(); //Todo: lopws staffDAL, getstaff by ID

        }





















































































































































        // ĐỨc//254


        void LoadDishGroup()
        {
            cbbDishGroup.Items.Clear();
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
        private void btnPay_Click(object sender, EventArgs e)
        {
            PaymentForm f = new PaymentForm(lbTableName.Tag.ToString(), staff);
            f.d = new PaymentForm.Mydel(LoadComponent);
            f.Show();
        }
        private void IFStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IFStaff().Show();
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
            this.Controls.Find(lbTableName.Tag.ToString(), true)[0].BackColor = c1;
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage f = new Storage();
            f.d = new Storage.Mydel(LoadDishGroup);
            f.Show();
        }

        private void thuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BillManagement().Show();
        }
        private void khoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Storage().Show();
        }

        private void DiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DiscountManagement().Show();
        }


    }


}//665

