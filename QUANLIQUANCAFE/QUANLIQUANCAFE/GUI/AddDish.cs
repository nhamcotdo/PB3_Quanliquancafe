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
        }

        private void butOK_Click(object sender, EventArgs e)
        {

            if (txtDishID.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ID món");
                return;
            }

            if (txtDishName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên món");
                return;
            }

            Quanli.Instance.AddDish(txtDishName.Text,txtDishID.Text,txtPrice.Text);
            d();
            this.Dispose();
        }
    }
}
