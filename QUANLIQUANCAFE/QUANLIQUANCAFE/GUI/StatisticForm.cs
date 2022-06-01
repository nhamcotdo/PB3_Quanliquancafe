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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
            GUI();
            Quanli.Instance.LoadLang(this);
        }

        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter("statisticform.txt"))
            {
                sw.WriteLine(btnMonth.Name + ";" + btnMonth.Text + ";" + Quanli.Instance.TranslateText(btnMonth.Text, "vi", "en"));
                sw.WriteLine(btnYear.Name + ";" + btnYear.Text + ";" + Quanli.Instance.TranslateText(btnYear.Text, "vi", "en"));

            }
        }

        void GUI()
        {
            chart1.Series.Add("Doanh thu");
            chart1.Series.Add("Doanh số");
            chart1.Series["Doanh số"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Design();
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
                else if (i is NumericUpDown)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }

            }

        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            List<Bill> list = Quanli.Instance.GetListBillByYearMonth((int)numericUpDownYear.Value);

            chart1.Series["Doanh thu"].Points.Clear();
            chart1.Series["Doanh số"].Points.Clear();
            for (int i = 1; i <= 12; i++)
            {
                int total = 0;
                int count = 0;
                foreach (Bill item in list)
                {
                    if (item.TimeCheckOut.Month == i)
                    {
                        count++;
                        total += item.TotalBill;
                    }
                }
                chart1.Series["Doanh thu"].Points.AddXY("Tháng " + i, total);
                chart1.Series["Doanh số"].Points.AddXY("Tháng " + i, count);
            }
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            List<Bill> list = Quanli.Instance.GetListBillByYearMonth((int)numericUpDownYear.Value, (int)numericUpDownMonth.Value);

            chart1.Series["Doanh thu"].Points.Clear();
            chart1.Series["Doanh số"].Points.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth((int)numericUpDownYear.Value, (int)numericUpDownMonth.Value); i++)
            {
                int total = 0;
                int count = 0;
                foreach (Bill item in list)
                {
                    if (item.TimeCheckOut.Day == i)
                    {
                        count++;
                        total += item.TotalBill;
                    }
                }
                chart1.Series["Doanh thu"].Points.AddXY("Ngày " + i, total);
                chart1.Series["Doanh số"].Points.AddXY("Ngày " + i, count);
            }
        }
    }
}
