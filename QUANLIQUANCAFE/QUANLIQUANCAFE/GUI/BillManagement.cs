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
    public partial class BillManagement : Form
    {
        public BillManagement()
        {
            InitializeComponent();
            GUI();
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
    }
}
