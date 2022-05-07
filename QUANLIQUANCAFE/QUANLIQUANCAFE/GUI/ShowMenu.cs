using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLIQUANCAFE.BLL;
using QUANLIQUANCAFE.DTO;
using QUANLIQUANCAFE.DAL;

namespace QUANLIQUANCAFE.GUI
{
    public partial class ShowMenu : Form
    {
        public delegate void Mydel();
        public Mydel d;
        Quanli bll = new Quanli();
        public ShowMenu()
        {
            InitializeComponent();
            addDatagrid();
        }
        public void addDatagrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
            new DataColumn("ID món"),
            new DataColumn("Tên món"),
            new DataColumn("Giá"),
            new DataColumn("Nhóm món"),
            new DataColumn("Size"),
            });
            string query = "SELECT * FROM [Menu]";
            dt = DBHelper.Instance.GetRecords(query);
            dataGridView1.DataSource = dt;
        }
        private void butAddDish_Click(object sender, EventArgs e)
        {
            AddDish f = new AddDish();
<<<<<<< Updated upstream
            //f.d = new AddDish.Mydel();
            this.Show();
=======
            f.d = new AddDish.Mydel(addDatagrid);
            f.Show();
>>>>>>> Stashed changes
        }

        private void butDelDish_Click(object sender, EventArgs e)
        {
                string Warning = "Bạn chưa chọn món để xóa";
                if (dataGridView1.SelectedRows.Count == 0) MessageBox.Show(Warning);
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Quanli.Instance.DelDish(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    }
                }
<<<<<<< Updated upstream
=======
            }
            addDatagrid();
>>>>>>> Stashed changes
        }
    }
}
