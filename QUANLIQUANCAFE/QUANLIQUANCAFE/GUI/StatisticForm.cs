using QUANLIQUANCAFE.BLL;
using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }
        void GUI()
        {
            chart1.Series.Add("Doanh thu");
            chart1.Series.Add("Doanh số");
            chart1.Series["Doanh số"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

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
