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
    public partial class DiscountManagement : Form
    {
        public DiscountManagement()
        {
            InitializeComponent();
            GUI();
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
    }

}
