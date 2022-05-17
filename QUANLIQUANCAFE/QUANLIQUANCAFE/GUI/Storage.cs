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

namespace QUANLIQUANCAFE.GUI
{
    public partial class Storage : Form
    {

        public delegate void Mydel();
        public Mydel d;
        private int count = 0;
        //Quanli bll = new Quanli();
        public Storage()
        {
            InitializeComponent();
            LoadComponent();

        }
        public void LoadComponent()
        {
            AddDatagrid();
            AddcbbUnit();
        }
        public void AddcbbUnit()
        {
            cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Kg" });
            cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Bịch" });
            cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Thùng" });
            cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Hộp" });
            cbbUnit.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "Quả" });
        }
        public void AddDatagrid()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [Storage]";
            dt = DBHelper.Instance.GetRecords(query);
            dataGridView1.DataSource = dt;
            AddDataheader();
            AddDataWidth();
        }
        public void AddDataheader()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn vị";
            dataGridView1.Columns[4].HeaderText = "Giá";
            dataGridView1.Columns[5].HeaderText = "Ngày nhập";
        }
        public void AddDataWidth()
        {
            dataGridView1.Columns[4].Width = 150;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                txtPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cbbUnit.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value);
            }
        }

        private void butIncrease_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                int a = Convert.ToInt16(txtQuantity.Text);
                a++;
                txtQuantity.Text = a.ToString();
            }
        }

        private void butDecrease_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                int a = Convert.ToInt16(txtQuantity.Text);
                a--;
                txtQuantity.Text = a.ToString();
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            //string Warning = "";
            //if (dataGridView1.SelectedRows.Count == 0) MessageBox.Show(Warning);
            DialogResult result = MessageBox.Show("Bạn có muốn lưu lại mặt hàng này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int price = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                string unit = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string quantity = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string time = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                Quanli.Instance.UpdateStorage(id, name, quantity, unit, price, time);
            }
            LoadComponent();
        }
    }
}
