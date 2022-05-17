using QUANLIQUANCAFE.BLL;
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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Quanli.Instance.SelectBillByDate(dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }
    }
}
