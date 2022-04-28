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
    public partial class AddTable : Form
    {
        public delegate void Mydel();
        public Mydel d;
        Quanli bll = new Quanli();
        public AddTable()
        {
            InitializeComponent();
            foreach (Area item in Quanli.Instance.GetListArea())
            {
                cbbArea.Items.Add(new CBBItem(item.AreaName, item.AreaID));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên bàn");
                return;
            }

            bool check = false;
            foreach (Area item in Quanli.Instance.GetListArea())
            {
                if (cbbArea.Text == item.AreaName)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                //confirm
                DialogResult result = MessageBox.Show("Khu vực bạn nhập không tồn tại! \n" +
                    "Bạn có muốn thêm khu vực mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string TableID = Quanli.Instance.NewAreaID();
                    cbbArea.Items.Add(new CBBItem(cbbArea.Text, TableID));
                    cbbArea.SelectedIndex = cbbArea.Items.Count - 1;
                    Quanli.Instance.AddArea(cbbArea.Text, TableID);
                    return;
                }
                else
                {
                    return;
                }

            }

            Quanli.Instance.AddTable(txtName.Text, (cbbArea.SelectedItem as CBBItem).Value.ToString());
            d();
            this.Dispose();
        }


    }
}
