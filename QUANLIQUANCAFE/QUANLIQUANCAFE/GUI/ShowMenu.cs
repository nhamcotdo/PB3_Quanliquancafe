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
using System.IO;

namespace QUANLIQUANCAFE.GUI
{
    public partial class ShowMenu : Form
    {
        public delegate void Mydel();
        public Mydel d;
        private int count = 0;
        public ShowMenu()
        {
            InitializeComponent();
            Quanli.Instance.LoadLang(this);
            LoadComponent();
        }
        public void LoadComponent()
        {
            addDatagrid();
            addcbbDishGroup();
            Design();
        }
        public void addDatagrid()
        {
            DataTable dt = new DataTable();
            if (Quanli.Instance.langnow == "vi")
            {

                dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID món"),
                new DataColumn("Tên món"),
                new DataColumn("Giá"),
                new DataColumn("Nhóm món"),
                new DataColumn("Size"),
                });
            }
            else
            {
                dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("Dish ID"),
                new DataColumn("Dish Name"),
                new DataColumn("Dish Price"),
                new DataColumn("Dish Group"),
                new DataColumn("Size"),
                });
            }
            dataGridView1.DataSource = Quanli.Instance.GetDataDish();
        }
        public void addcbbDishGroup()
        {
            int value = 0;
            if (Quanli.Instance.langnow == "vi")
            {
                cbbDishGroup.Items.Add(new CBBItem { Value = (value++).ToString(), Text = "Tất cả" });
                foreach (DishGroup item in Quanli.Instance.GetGroupName())
                {
                    cbbDishGroup.Items.Add(new CBBItem { Value = (value++).ToString(), Text = item.GroupName });
                }
            }
            else
            {
                cbbDishGroup.Items.Add(new CBBItem { Value = (value++).ToString(), Text = "All" });
                foreach (DataRow item in Quanli.Instance.GetGroupNameInEng().Rows)
                {
                    cbbDishGroup.Items.Add(new CBBItem { Value = (value++).ToString(), Text = item[""] });
                }
            }

            cbbDishGroup.SelectedItem = 0;
        }
        private void butAddDish_Click(object sender, EventArgs e)
        {
            AddDish f = new AddDish();
            f.d = new AddDish.Mydel(addDatagrid);
            f.Show();
            d();
        }

        private void butDelDish_Click(object sender, EventArgs e)
        {
            if (Quanli.Instance.langnow == "vi")
            {
                string Warning = "Bạn chưa chọn món để xóa";
                if (dataGridView1.SelectedRows.Count == 0) MessageBox.Show(Warning);
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            Quanli.Instance.DelDish(row.Cells[0].Value.ToString());
                        }
                    }
                    addDatagrid();
                }
            }
            else
            {
                string Warning = "You have not selected a dish to delete";
                if (dataGridView1.SelectedRows.Count == 0) MessageBox.Show(Warning);
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this dish?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            Quanli.Instance.DelDish(row.Cells[0].Value.ToString());
                        }
                    }
                    addDatagrid();
                }
            }
        }

        private void cbbDishGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query;
            if (cbbDishGroup.SelectedIndex.Equals(0))
            {
                query = string.Format("Select * from [Menu]");
            }
            else
            {
                string groupID = "G00" + cbbDishGroup.SelectedIndex.ToString();
                query = string.Format("Select * from [Menu] where GroupID = N'{0}'", groupID);
            }
            dt.Columns.AddRange(new DataColumn[] {
            new DataColumn("ID món"),
            new DataColumn("Tên món"),
            new DataColumn("Giá"),
            new DataColumn("Nhóm món"),
            new DataColumn("Size"),
            });
            dt = DBHelper.Instance.GetRecords(query);
            dataGridView1.DataSource = dt;
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
            foreach (Control i in panel1.Controls)
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
                else if (i is TextBox | i is ComboBox)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }

            }

        }
    }
}
