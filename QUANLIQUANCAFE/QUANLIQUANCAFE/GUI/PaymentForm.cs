using QUANLIQUANCAFE.BLL;
using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
        Staff staff;
        public PaymentForm(string TableID, Staff NV)
        {
            InitializeComponent();
            this.TableID = TableID;
            staff = NV;
            lbNV.Text = NV.StaffID;
            GUI();
            Quanli.Instance.LoadLang(this);
        }

        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter("paymentform.txt"))
            {
                foreach (Control i in panelBill.Controls)
                {
                    if (!(i is TextBox | i is ComboBox | i is Panel) & i.Text != "")

                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }
                foreach (Control i in panelBill.Controls)
                {
                    if (!(i is DataGridView) & i.Text != "")

                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }
            }

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
            //dont change color when select
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;

            foreach (Discount item in Quanli.Instance.GetAllDiscount())
            {
                cbbkm.Items.Add(item);
            }
            cbbkm.SelectedIndex = 0;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
            e.HasMorePages = false;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // In hoá đơn
            Graphics g = panelBill.CreateGraphics();
            // bmp new bit map A5 size
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A5", panelBill.Width, panelBill.Height + 20);

            panelBill.DrawToBitmap(bmp, new Rectangle(0, 0, panelBill.Width, panelBill.Height));
            printPreviewDialog1.ShowDialog();
            //messagebox confirm
            if (MessageBox.Show("Bạn có chắc chắn thanh toán đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Quanli.Instance.Pay(new Bill
                {
                    BillID = Quanli.Instance.NewBillID(),
                    //lbtime.text = 13/05/2020 12:44:22 to datetime
                    TimeCheckOut = DateTime.ParseExact(lbTime.Text, "dd/MM/yyyy HH:mm:ss", null),
                    TotalBill = Convert.ToInt32(lbTotalPrice.Text),
                    DiscountID = (cbbkm.SelectedItem as Discount).DiscountID,
                    OtherFee = Convert.ToInt32(lbOther.Text),
                    TableID = TableID,
                    StaffID = staff.StaffID,
                }
                 );
                this.Dispose();
                d();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            d();
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

        private void cbbkm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbbkm.SelectedItem as Discount).Percent == true)
            {
                lbPromotion.Text = (-Convert.ToInt32(lbTotal.Text) * (cbbkm.SelectedItem as Discount).Value / 100).ToString();
            }
            else
            {
                lbPromotion.Text = (-(cbbkm.SelectedItem as Discount).Value).ToString();
            }
            lbTotalPrice.Text = (Convert.ToInt32(lbTotal.Text) + Convert.ToInt32(lbPromotion.Text) + Convert.ToInt32(lbOther.Text)).ToString();

        }
    }
}
