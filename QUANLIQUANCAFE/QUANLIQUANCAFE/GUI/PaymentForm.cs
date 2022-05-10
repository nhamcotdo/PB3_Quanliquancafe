using QUANLIQUANCAFE.BLL;
using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLIQUANCAFE.GUI
{
    public partial class PaymentForm : Form
    {
        public delegate void Mydel();
        public Mydel d;
        string TableID;
        int Total;
        Bitmap bmp;
        public PaymentForm(string TableID, Staff NV)
        {
            InitializeComponent();
            this.TableID = TableID;
            lbNV.Text = NV.StaffName;
            GUI();
        }
        void GUI()
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Total = 0;

            dataGridView1.Columns.Add("Tên món", "Tên món");
            dataGridView1.Columns.Add("Số lượng", "Số lượng");
            dataGridView1.Columns.Add("Đơn giá", "Đơn giá");
            dataGridView1.Columns.Add("Thành tiền", "Thành tiền");
            foreach (Order item in Quanli.Instance.GetListOrderByTableID(TableID))
            {
                dataGridView1.Rows.Add(item.DishName, item.Quantity, item.Price, item.Price * item.Quantity);
                Total += item.Price * item.Quantity;
            }
            //show full text in cell
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            lbtable.Text = Quanli.Instance.GetTableByID(TableID).TableName;
            lbTotal.Text = Total.ToString();
            lbTotalPrice.Text = (Total + Convert.ToInt32(lbPromotion.Text) + Convert.ToInt32(lbPromotion.Text)).ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
            e.HasMorePages = false;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Quanli.Instance.Pay(TableID);
            d();
            Graphics g = this.CreateGraphics();
            // bmp new bit map A5 size
            bmp = new Bitmap(panelBill.Width, panelBill.Height, g);
            //draw panel to full page A5 
            panelBill.DrawToBitmap(bmp, new Rectangle(0, 0, panelBill.Width, panelBill.Height));

            printPreviewDialog1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbOther_TextChanged(object sender, EventArgs e)
        {
            if (tbOther.Text == "" || tbOther.Text == null)
            {
                lbOther.Text = "0";
                lbTotalPrice.Text = (Convert.ToInt32(lbTotal.Text) + Convert.ToInt32(lbPromotion.Text)).ToString();
                return;
            }
            lbOther.Text = tbOther.Text;
            lbTotalPrice.Text = (Convert.ToInt32(lbTotal.Text) + Convert.ToInt32(lbPromotion.Text) + Convert.ToInt32(lbOther.Text)).ToString();
        }
        private void tbOther_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }




    }
}
