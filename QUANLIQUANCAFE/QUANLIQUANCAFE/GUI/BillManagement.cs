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
            GenLang();
        }
        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter("billmanagement.txt"))
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
        private void GUI()
        {
            dateTimePickerFrom.Value = DateTime.Now - TimeSpan.FromDays(7);
            dateTimePickerTo.Value = DateTime.Now;
            dataGridView1.DataSource = Quanli.Instance.SelectBillByDate(dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Quanli.Instance.SelectBillByDate(dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Quanli.Instance.SelectBillByDate(dateTimePickerFrom.Value, dateTimePickerTo.Value);
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
                    i.ForeColor = ColorTranslator.FromHtml(label[0]);
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
