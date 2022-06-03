using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLIQUANCAFE.BLL;
using QUANLIQUANCAFE.DTO;
using QUANLIQUANCAFE.DAL;
using System.IO;

namespace QUANLIQUANCAFE.GUI
{
    public partial class Storage : Form
    {

        public delegate void Mydel();
        public Mydel d;
        public Storage()
        {
            InitializeComponent();
            LoadComponent();
            Design();
            Quanli.Instance.LoadLang(this);

        }
        void Design()
        {
            string[] background;
            string[] button;
            string[] label;
            string[] textbox;
            using (StreamReader sr = new StreamReader("config.txt"))
            {
                background = sr.ReadLine().Split(';');
                button = sr.ReadLine().Split(';');
                label = sr.ReadLine().Split(';');
                textbox = sr.ReadLine().Split(';');
            }
            if (background[0] == "Color")
            {
                this.BackColor = ColorTranslator.FromHtml(background[1]);
                this.BackgroundImage = null;
            }
            else
            {
                this.BackgroundImage = Image.FromFile(background[1]);
            }
            foreach (Control i in pnHeader.Controls)
            {
                if (i is Button)
                {
                    i.BackColor = ColorTranslator.FromHtml(button[0]);
                    i.ForeColor = ColorTranslator.FromHtml(button[1]);
                }
                else if (i is Label)
                {
                    i.ForeColor = ColorTranslator.FromHtml(label[1]);
                }
                else if (i is TextBox | i is NumericUpDown | i is DateTimePicker | i is ComboBox)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }
            }

        }
        public void LoadComponent()
        {
            AddDatagrid();
            AddcbbUnit();
            AddHeading();
        }
        public void AddcbbUnit()
        {
            int count = 0;
            if (Quanli.Instance.langnow == "vi")
            {
                cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Kg" });
                cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Thùng" });
                cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Bao" });
                cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Khác" });
            }
            else
            {
                cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Kg" });
                cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Box" });
                cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Bag" });
                cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Other" });
            }
        }
        public void AddHeading()
        {
            if (Quanli.Instance.langnow == "vi")
            {
                Infotxt.Text = "Thông tin nguyên liệu";
            }
            else
            {
                Infotxt.Text = "Grocery Information";
            }
            if (txtID.Text != "")
            {
                if (Quanli.Instance.langnow == "vi")
                {
                    Infotxt.Text = "Nhập/ Xuất kho";
                }
                else
                {
                    Infotxt.Text = "Check in/ Check out";
                }
            }


        }
        public void AddDatagrid()
        {
            dataGridView1.DataSource = Quanli.Instance.GetDataStorage();
            AddDataheader();
        }
        public void AddDataheader()
        {
            if (Quanli.Instance.langnow == "vi")
            {
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Tên";
                dataGridView1.Columns[2].HeaderText = "Số lượng";
                dataGridView1.Columns[3].HeaderText = "Đơn vị";
                dataGridView1.Columns[4].HeaderText = "Giá";
                dataGridView1.Columns[5].HeaderText = "Ngày nhập";
            }
            else
            {
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].HeaderText = "Quantity";
                dataGridView1.Columns[3].HeaderText = "Unit";
                dataGridView1.Columns[4].HeaderText = "Price";
                dataGridView1.Columns[5].HeaderText = "Date Check In";
            }
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            int OldQuantity, AddQuantity, NewQuantity;

            string id = txtID.Text;
            string datetime = DateTime.Now.ToString();
            int price = Convert.ToInt32(txtPrice.Text);
            string unit = cbbUnit.Text;
            string name = txtName.Text;
            string time = dateTimePicker1.Value.Date.ToString();
            MessageBox.Show(time);

            if (!Quanli.Instance.CheckDatetime(id, datetime))
            {
                AddQuantity = Convert.ToInt32(numericUpDown1.Value);
                OldQuantity = Convert.ToInt32(Quanli.Instance.GetQuantityByID(id));
                NewQuantity = (OldQuantity + AddQuantity);
                Quanli.Instance.UpdateStorage(id, name, NewQuantity.ToString(), unit, price, time);
            }
            else
            {
                AddQuantity = Convert.ToInt32(numericUpDown1.Value);
                Quanli.Instance.AddStorage(id, name, AddQuantity.ToString(), unit, price, time);
            }
            LoadComponent();
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                txtPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cbbUnit.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                numericUpDown1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value);
            }
        }
        private void UpdateBut_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (Quanli.Instance.langnow == "vi")
            {
                result = MessageBox.Show("Bạn có muốn lưu lại mặt hàng này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                result = MessageBox.Show("Do you want to save this item", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (result == DialogResult.Yes)
            {
                int price = Convert.ToInt32(txtPrice.Text);
                string unit = cbbUnit.Text;
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = txtName.Text;
                string quantity = numericUpDown1.Value.ToString();
                string time = dateTimePicker1.Value.ToString();

                Quanli.Instance.UpdateStorage(id, name, quantity, unit, price, time);
            }
            LoadComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int OldQuantity, SubQuantity, NewQuantity;

            string id = txtID.Text;
            string datetime = DateTime.Now.ToString();
            int price = Convert.ToInt32(txtPrice.Text);
            string unit = cbbUnit.Text;
            string name = txtName.Text;
            string time = dateTimePicker1.Value.Date.ToString();
            MessageBox.Show(time);

            if (!Quanli.Instance.CheckDatetime(id, datetime))
            {
                SubQuantity = Convert.ToInt32(numericUpDown1.Value);
                OldQuantity = Convert.ToInt32(Quanli.Instance.GetQuantityByID(id));
                NewQuantity = (OldQuantity - SubQuantity);
                if (NewQuantity < 0)
                {
                    if (Quanli.Instance.langnow == "en")
                    {
                        MessageBox.Show("Quantity is not enough");
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không đủ");
                    }
                }
                Quanli.Instance.UpdateStorage(id, name, NewQuantity.ToString(), unit, price, time);
            }
            else
            {
                SubQuantity = Convert.ToInt32(numericUpDown1.Value);
                Quanli.Instance.AddStorage(id, name, SubQuantity.ToString(), unit, price, time);
            }
            LoadComponent();
        }

        private void cbbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUnit.SelectedIndex == 3)
            {
                OtherUnit.Visible = true;
            }
            else
            {
                OtherUnit.Visible = false;
            }
        }
        private void OtherUnit_TextChanged(object sender, EventArgs e)
        {
            int value = Quanli.Instance.GetUnitValue();
            cbbUnit.Items.Add(new CBBItem { Value = value.ToString(), Text = OtherUnit.Text });
        }
    }
}