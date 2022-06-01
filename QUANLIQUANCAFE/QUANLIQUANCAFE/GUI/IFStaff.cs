using QUANLIQUANCAFE.BLL;
using QUANLIQUANCAFE.DAL;
using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int count = 0;
        public IFStaff()
        {
            InitializeComponent();
            GUI();
            GenLang();
        }

        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter("ifstaff.txt"))
            {
                foreach (Control i in grbTT.Controls)
                {
                    if (!(i is TextBox || i is ComboBox || i is NumericUpDown || i is DataGridView || i is DateTimePicker))
                        sw.WriteLine(i.Name + ":" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }
                foreach (Control i in grbCN.Controls)
                {
                    if (!(i is TextBox || i is ComboBox || i is NumericUpDown || i is DataGridView || i is DateTimePicker))
                        sw.WriteLine(i.Name + ":" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));

                }
            }
        }

        public void GUI()
        {
            AddDatagrid();
            AddcbbCA();
            Design();
        }

        public void AddcbbCA()
        {
            cbbCA.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "SA01 " });
            cbbCA.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "SA02" });
            cbbCA.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "CH01" });
            cbbCA.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "CH02 " });
            cbbCA.Items.Add(new CBBItem { Value = (count++).ToString(), Text = "TO01 " });
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
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Họ Tên";
            dataGridView1.Columns[2].HeaderText = "Số điện thoại";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[5].HeaderText = "Ca làm việc";
            dataGridView1.Columns[6].HeaderText = "Giới tính";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                txtID.ReadOnly = true;
                txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtHT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtSDT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtDC.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cbbCA.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()))
                    rdbMale.Checked = true;
                else
                    rdbFeMale.Checked = true;
                txtTK.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtPassWord.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string Name = txtHT.Text;
            int Phone = Convert.ToInt32(txtSDT.Text);
            string Address = txtDC.Text;
            DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Value);
            string ShiftID = cbbCA.Text;
            bool sex = true;
            if (rdbFeMale.Checked)
            {
                sex = false;
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
                string ShiftID = cbbCA.Text;
                bool sex = true;
                if (rdbFeMale.Checked)
                {
                    sex = false;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnNewID_Click(object sender, EventArgs e)
        {
            txtID.Text = Quanli.Instance.NewStaffID();
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
            foreach (Control i in grbTT.Controls)
            {
                if (i is Button)
                {
                    i.BackColor = ColorTranslator.FromHtml(button[0]);
                    i.ForeColor = ColorTranslator.FromHtml(button[1]);
                }
                else if (i is Label)
                {
                    i.ForeColor = ColorTranslator.FromHtml(label[0]);
                }
                else if (i is TextBox)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }
                else if (i is ComboBox)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }

            }
            foreach (Control i in grbCN.Controls)
            {
                if (i is Button | i is RadioButton)
                {
                    i.BackColor = ColorTranslator.FromHtml(button[0]);
                    i.ForeColor = ColorTranslator.FromHtml(button[1]);
                }
            }

        }
    }
}
