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
    public partial class BillManagement : Form
    {
        public BillManagement()
        {
            InitializeComponent();
            GUI();
            Design();
            Quanli.Instance.LoadLang(this);
        }
        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter(Name + ".txt"))
            {
                foreach (Control i in panel1.Controls)
                {
                    if (!(i is TextBox || i is ComboBox || i is NumericUpDown || i is DataGridView || i is DateTimePicker))
                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }
                foreach (Control i in panel2.Controls)
                {
                    if (!(i is TextBox || i is ComboBox || i is NumericUpDown || i is DataGridView || i is DateTimePicker))
                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }
            }
        }
        void LoadDGT()
        {
            dataGridView1.DataSource = Quanli.Instance.SelectBillByDate(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            if (Quanli.Instance.langnow == "vi")
            {
                dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
                dataGridView1.Columns[1].HeaderText = "Thời gian";
                dataGridView1.Columns[2].HeaderText = "Tổng tiền";
                dataGridView1.Columns[3].HeaderText = "Tên nhân viên";
            }
            else
            {
                dataGridView1.Columns[0].HeaderText = "Bill ID";
                dataGridView1.Columns[1].HeaderText = "Time";
                dataGridView1.Columns[2].HeaderText = "Total";
                dataGridView1.Columns[3].HeaderText = "Staff Name";
            }
        }

        private void GUI()
        {
            dateTimePickerFrom.Value = DateTime.Now - TimeSpan.FromDays(7);
            dateTimePickerTo.Value = DateTime.Now;
        }


        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            LoadDGT();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new ShowBill(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString()).ShowDialog();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            new StatisticForm().ShowDialog();
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
                if (i is Label)
                {
                    i.ForeColor = ColorTranslator.FromHtml(label[1]);
                }
            }
            foreach (Control i in panel2.Controls)
            {
                if (i is Button)
                {
                    i.BackColor = ColorTranslator.FromHtml(button[0]);
                    i.ForeColor = ColorTranslator.FromHtml(button[1]);
                }
            }

        }
    }
}
