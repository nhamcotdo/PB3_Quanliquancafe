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
    public partial class DiscountManagement : Form
    {
        public DiscountManagement()
        {
            InitializeComponent();
            GUI();
            Design();

            Quanli.Instance.LoadLang(this);
        }
        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter(this.Name + ".txt"))
            {
                foreach (Control i in panel1.Controls)
                {
                    if (!(i is TextBox || i is ComboBox || i is NumericUpDown || i is DataGridView || i is DateTimePicker))
                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));

                }
            }
        }
        void GUI()
        {
            txtID.Enabled = false;
            DataTable dt = new DataTable();
            if (Quanli.Instance.langnow == "en")
                dt.Columns.AddRange(
                new DataColumn[]
                {
                new DataColumn("DiscountID", typeof(string)),
                new DataColumn("DiscountName", typeof(string)),
                new DataColumn("Value", typeof(int)),
                new DataColumn("Percent", typeof(bool)),
                new DataColumn("Active", typeof(bool))
                });
            else
            {
                dt.Columns.AddRange(
                    new DataColumn[]
                    {
                new DataColumn("ID Mã giảm giá", typeof(string)),
                new DataColumn("Tên mã giảm giá", typeof(string)),
                new DataColumn("Giá trị", typeof(int)),
                new DataColumn("Theo phần trăm", typeof(bool)),
                new DataColumn("Kích hoạt", typeof(bool))
                });
            }
            foreach (Discount i in Quanli.Instance.GetAllDiscount(false))
            {
                dt.Rows.Add(i.DiscountID, i.DisCountName, i.Value, i.Percent, i.Active);
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Discount d = Quanli.Instance.GetDiscountByID(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtID.Text = d.DiscountID;
            txtDiscountName.Text = d.DisCountName;
            txtDiscountNameEn.Text = d.DisCountNameEn;
            txtValue.Text = d.Value.ToString();
            if (d.Percent)
                cbPercent.Checked = true;
            else
                cbPercent.Checked = false;
            if (d.Active)
                cbActive.Checked = true;
            else
                cbActive.Checked = false;
        }
        private void btnNewID_Click(object sender, EventArgs e)
        {
            txtID.Text = Quanli.Instance.NewDiscountID();
        }

        private void addorupdate_Click(object sender, EventArgs e)
        {
            if (txtDiscountName.Text == "" || txtValue.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            Quanli.Instance.AddOrUpdateDiscount(
                 new Discount()
                 {
                     DiscountID = txtID.Text,
                     DisCountName = txtDiscountName.Text,
                     DisCountNameEn = txtDiscountNameEn.Text,
                     Value = Convert.ToInt32(txtValue.Text),
                     Percent = cbPercent.Checked,
                     Active = cbActive.Checked
                 }
                 );
            GUI();
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
                else if (i is TextBox)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }
            }
        }


    }

}
