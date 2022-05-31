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
        Quanli bll = new Quanli();
        public AddDish()
        {
            InitializeComponent();
            AddcbbGroup();
            AddcbbSize();
            Design();
        }
        public void AddcbbGroup()
        {
            cbbGroup.Items.Add(new CBBItem { Value = "0", Text = "G001" });
            cbbGroup.Items.Add(new CBBItem { Value = "1", Text = "G002" });
            cbbGroup.Items.Add(new CBBItem { Value = "2", Text = "G003" });
            cbbGroup.Items.Add(new CBBItem { Value = "3", Text = "G004" });
            cbbGroup.Items.Add(new CBBItem { Value = "4", Text = "G005" });
            cbbGroup.Items.Add(new CBBItem { Value = "5", Text = "G006" });
        }
        public void AddcbbSize()
        {
            cbbSize.Items.Add(new CBBItem { Value = "0", Text = "S1" });
            cbbSize.Items.Add(new CBBItem { Value = "1", Text = "S2" });
            cbbSize.Items.Add(new CBBItem { Value = "2", Text = "S3" });
        }

        private void butOK_Click(object sender, EventArgs e)
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
                else if (i is ComboBox | i is TextBox)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }

            }

        }
    }
}
