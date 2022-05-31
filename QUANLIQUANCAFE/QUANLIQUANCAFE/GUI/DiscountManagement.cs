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
        }
        void GUI()
        {
            txtID.Enabled = false;
            dataGridView1.DataSource = Quanli.Instance.GetAllDiscount(false);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDiscountName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtValue.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbPercent.Checked = dataGridView1.CurrentRow.Cells[3].Value.ToString() == "True" ? true : false;
            cbActive.Checked = dataGridView1.CurrentRow.Cells[4].Value.ToString() == "True" ? true : false;

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
