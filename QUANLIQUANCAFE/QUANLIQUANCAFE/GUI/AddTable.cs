using QUANLIQUANCAFE.BLL;
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
    public partial class AddTable : Form
    {
        public delegate void Mydel();
        public Mydel d;
        Quanli bll = new Quanli();
        public AddTable()
        {
            InitializeComponent();
            foreach (Area item in Quanli.Instance.GetListArea())
            {
                cbbArea.Items.Add(new CBBItem(item.AreaName, item.AreaID));
            }
            Design();
            GenLang();
        }
        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter("addtable.txt"))
            {
                foreach (Control i in this.Controls)
                {
                    if (!(i is TextBox || i is ComboBox || i is NumericUpDown || i is DataGridView))
                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên bàn");
                return;
            }

            bool check = false;
            foreach (Area item in Quanli.Instance.GetListArea())
            {
                if (cbbArea.Text == item.AreaName)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                //confirm
                DialogResult result = MessageBox.Show("Khu vực bạn nhập không tồn tại! \n" +
                    "Bạn có muốn thêm khu vực mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string TableID = Quanli.Instance.NewAreaID();
                    cbbArea.Items.Add(new CBBItem(cbbArea.Text, TableID));
                    cbbArea.SelectedIndex = cbbArea.Items.Count - 1;
                    Quanli.Instance.AddArea(cbbArea.Text, TableID);
                    return;
                }
                else
                {
                    return;
                }

            }

            Quanli.Instance.AddTable(txtName.Text, (cbbArea.SelectedItem as CBBItem).Value.ToString());
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            foreach (Control i in this.Controls)
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
                else if (i is ComboBox | i is TextBox)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }

            }

        }
    }
}
