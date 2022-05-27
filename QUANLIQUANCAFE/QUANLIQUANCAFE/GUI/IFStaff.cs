using QUANLIQUANCAFE.BLL;
using QUANLIQUANCAFE.DAL;
using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLIQUANCAFE.GUI
{
    public partial class IFStaff : Form
    {
        public delegate void MyDel();
        public MyDel d;
        public IFStaff()
        {
            InitializeComponent();
            GUI();
        }

        public void GUI()
        {
            AddDatagrid();
        }
        public void AddDatagrid()
        {
            DataTable dt = new DataTable();
            string query = "SELECT staff.staffID, staff.staffname, staff.phonenumber,staff.address,staff.datein, staff.shiftId,staff.sex, account.[account], account.password FROM [Staff] left join account on staff.staffid = account.staffid";
            dt = DBHelper.Instance.GetRecords(query);
            dataGridView1.DataSource = dt;
            AddDataHeader();
        }
        public void AddDataHeader()
        {
            dataGridView1.Columns[0].HeaderText="ID";
            dataGridView1.Columns[1].HeaderText="Họ Tên";
            dataGridView1.Columns[2].HeaderText="Số điện thoại";
            dataGridView1.Columns[3].HeaderText="Địa chỉ";
            dataGridView1.Columns[4].HeaderText="Ngày Sinh";
            dataGridView1.Columns[5].HeaderText="Ca làm việc";
            dataGridView1.Columns[6].HeaderText="Giới tính";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtHT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtSDT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtDC.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtShift.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()))
                    rdbMale.Checked=true;
                else
                    rdbFeMale.Checked=true;
                txtTK.Text=dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtPassWord.Text=dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string Name = txtHT.Text;
            int Phone = Convert.ToInt32(txtSDT.Text);
            string Address = txtDC.Text;
            DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Value);
            string ShiftID = txtShift.Text;
            bool sex = true;
            if (rdbFeMale.Checked)
            {
                sex=false;
            }

            string account = txtTK.Text;
            string password = txtPassWord.Text;
            Quanli.Instance.InsertStaff(id, Name, Phone, Address, dateTime, ShiftID, sex);
            Quanli.Instance.InsertAccount(id, account, password);
            AddDatagrid();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thay đổi thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string id = txtID.Text;
                string Name = txtHT.Text;
                int Phone = Convert.ToInt32(txtSDT.Text);
                string Address = txtDC.Text;
                DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Value);
                string ShiftID = txtShift.Text;
                bool sex = true;
                if (rdbFeMale.Checked)
                {
                    sex=false;
                }
                string account = txtTK.Text;
                string password = txtPassWord.Text;
                Quanli.Instance.UpdateStaff(id, Name, Phone, Address, dateTime, ShiftID, sex);
                Quanli.Instance.UpdateAccount(id, account, password);
            }
            AddDatagrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Warning = "Bạn chưa chọn thông tin để xóa";
            if (dataGridView1.SelectedRows.Count == 0) MessageBox.Show(Warning);
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        Quanli.Instance.DelStaff(row.Cells[0].Value.ToString());
                    }
                }
                AddDatagrid();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
