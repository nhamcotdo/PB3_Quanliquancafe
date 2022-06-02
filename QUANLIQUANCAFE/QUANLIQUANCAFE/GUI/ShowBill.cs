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
    public partial class ShowBill : Form
    {
        string BillID;
        string StaffName;
        public ShowBill(string BillID, string StaffName)
        {
            InitializeComponent();
            this.BillID = BillID;
            this.StaffName = StaffName;
            GUI();
            Quanli.Instance.LoadLang(this);
        }
        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter(Name + ".txt"))
            {
                foreach (Control i in panelBill.Controls)
                {
                    if (!(i is DataGridView))

                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }

            }

        }
        private void GUI()
        {
            Bill b = Quanli.Instance.GetBillByID(BillID);
            lbTime.Text = b.TimeCheckOut.ToString();
            lbTotalPrice.Text = b.TotalBill.ToString();
            lbOther.Text = b.OtherFee.ToString();

            lbNV.Text = StaffName;

            int Total = 0;

            dataGridView1.Columns.Add("Tên món", "Tên món");
            dataGridView1.Columns.Add("Số lượng", "Số lượng");
            dataGridView1.Columns.Add("Đơn giá", "Đơn giá");
            dataGridView1.Columns.Add("Thành tiền", "Thành tiền");
            foreach (DataRow i in Quanli.Instance.GetListOrderByBillID(BillID).Rows)
            {
                dataGridView1.Rows.Add(i["DishName"], i["Quantity"], i["Price"], (int)i["Quantity"] * (int)i["Price"]);
                Total += (int)i["Quantity"] * (int)i["Price"];
            }
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            lbTotal.Text = Total.ToString();

            Discount d = Quanli.Instance.GetDiscountByID(b.DiscountID);


            if (d.Percent == true)
            {
                lbPromotion.Text = (-Convert.ToInt32(lbTotal.Text) * d.Value / 100).ToString();
            }
            else
            {
                lbPromotion.Text = (-d.Value).ToString();
            }
            lbKM.Text = d.DisCountName;

        }
    }
}
