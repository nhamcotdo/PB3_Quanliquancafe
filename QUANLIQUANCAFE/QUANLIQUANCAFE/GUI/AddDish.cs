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
    public partial class AddDish : Form
    {
        public delegate void Mydel();
        public Mydel d;
        public AddDish()
        {
            InitializeComponent();
            LoadComponent();
            Quanli.Instance.LoadLang(this);
        }



        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter("adddish.txt"))
            {
                foreach (Control i in panel1.Controls)
                {
                    if (!(i is TextBox || i is ComboBox || i is NumericUpDown || i is DataGridView))
                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }
            }
        }
        public void LoadComponent()
        {
            AddcbbGroup();
            AddcbbSize();
            Design();
        }
        public void AddcbbGroup()
        {
            int value = 0;
            if (Quanli.Instance.langnow == "vi")
            {
                foreach (DishGroup i in Quanli.Instance.GetGroupName())
                {
                    cbbGroup.Items.Add(new CBBItem { Value = (value++).ToString(), Text = i.GroupName });
                }
            }
            else
            {
                foreach (DataRow i in Quanli.Instance.GetGroupNameInEng().Rows)
                {
                    cbbGroup.Items.Add(new CBBItem { Value = (value++).ToString(), Text = i["GroupNameInEng"].ToString() });
                }
            }
        }
        public void AddcbbSize()
        {
            int value = 0;
            if (Quanli.Instance.langnow == "vi")
            {
                cbbSize.Items.Add(new CBBItem { Value = (value++).ToString(), Text = "Cỡ 1" });
                cbbSize.Items.Add(new CBBItem { Value = (value++).ToString(), Text = "Cỡ 2" });
                cbbSize.Items.Add(new CBBItem { Value = (value++).ToString(), Text = "Cỡ 3" });
            }
            else
            {
                cbbSize.Items.Add(new CBBItem { Value = (value++).ToString(), Text = "Small size" });
                cbbSize.Items.Add(new CBBItem { Value = (value++).ToString(), Text = "Normal size" });
                cbbSize.Items.Add(new CBBItem { Value = (value++).ToString(), Text = "Big size" });
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (Quanli.Instance.langnow == "vi")
            {
                if (txtDishID.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập ID món");
                    return;
                }

                if (txtDishName.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên món");
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập giá");
                    return;
                }
                Quanli.Instance.AddDish(txtDishName.Text, txtDishID.Text, Convert.ToInt32(txtPrice.Text), cbbGroup.SelectedItem.ToString(), cbbSize.SelectedItem.ToString());
                d();
                this.Dispose();
            }
            else
            {
                if (txtDishID.Text == "")
                {
                    MessageBox.Show("You haven't enter ID of dish");
                    return;
                }

                if (txtDishName.Text == "")
                {
                    MessageBox.Show("You haven't enter name of dish");
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("You haven't enter price of dish");
                    return;
                }
                Quanli.Instance.AddDish(txtDishName.Text, txtDishID.Text, Convert.ToInt32(txtPrice.Text), cbbGroup.SelectedItem.ToString(), cbbSize.SelectedItem.ToString());
                d();
                this.Dispose();
            }
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
                else if (i is ComboBox | i is TextBox)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }

            }

        }
    }
}
