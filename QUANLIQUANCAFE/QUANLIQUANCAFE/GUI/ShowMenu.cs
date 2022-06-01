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
    public partial class ShowMenu : Form
    {
        public delegate void Mydel();
        public Mydel d;
        private int count = 0;
        public ShowMenu()
        {
            InitializeComponent();
            addDatagrid();
            addcbbDishGroup();
            Design();
            GenLang();
        }

        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter("showmenu.txt"))
            {
                foreach (Control i in panel1.Controls)
                {
                    if (!(i is ComboBox))
                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }
            }
        }

        public void addDatagrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
            new DataColumn("ID món"),
            new DataColumn("Tên món"),
            new DataColumn("Giá"),
            new DataColumn("Nhóm món"),
            new DataColumn("Size"),
            });
            string query = "SELECT * FROM [Menu]";
            dt = DBHelper.Instance.GetRecords(query);
            dataGridView1.DataSource = dt;
        }
        public void addcbbDishGroup()
        {
            cbbDishGroup.Items.Add(new CBBItem { Value = "0", Text = "Tất cả" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "1", Text = "Cà Phê Phin" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "2", Text = "Trà" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "3", Text = "Freeze" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "4", Text = "Phindi" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "5", Text = "Cà phê Espresso" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "6", Text = "Bánh" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "7", Text = "Thức uống khác" });
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
                    i.ForeColor = ColorTranslator.FromHtml(label[0]);
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
