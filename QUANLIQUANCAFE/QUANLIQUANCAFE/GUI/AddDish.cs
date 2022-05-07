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
    public partial class AddDish : Form
    {
        public delegate void Mydel();
        public Mydel d;
        Quanli bll = new Quanli();
        public AddDish()
        {
            InitializeComponent();
            AddcbbGroup();
            AddcbbSize();
        }
        public void AddcbbGroup()
        {
            cbbGroup.Items.Add(new CBBItem { Value = "0", Text = "G001" });
            cbbGroup.Items.Add(new CBBItem { Value = "1", Text = "G002" });
            cbbGroup.Items.Add(new CBBItem { Value = "2", Text = "G003" });
            cbbGroup.Items.Add(new CBBItem { Value = "3", Text = "G004" });
            cbbGroup.Items.Add(new CBBItem { Value = "4", Text = "G005" });
            cbbGroup.Items.Add(new CBBItem { Value = "5", Text = "G006" });
        }
        public void AddcbbSize()
        {
            cbbSize.Items.Add(new CBBItem { Value = "0", Text = "S1" });
            cbbSize.Items.Add(new CBBItem { Value = "1", Text = "S2" });
            cbbSize.Items.Add(new CBBItem { Value = "2", Text = "S3" });
        }

        private void butOK_Click(object sender, EventArgs e)
        {

            if (txtDishID.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ID món");
                return;
            }

            else if (txtDishName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên món");
                return;
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá");
                return;
            }
            else if (cbbGroup.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập loại");
                return;
            }
            else if (cbbSize.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập size");
                return;
            }
            else
            {
                MessageBox.Show("Bạn có muốn thêm mặt hàng này không?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
         
            Quanli.Instance.AddDish(txtDishName.Text,txtDishID.Text,Convert.ToInt32(txtPrice.Text),cbbGroup.SelectedItem.ToString(),cbbSize.SelectedItem.ToString());
            d();
            this.Dispose();
        }
    }
}
