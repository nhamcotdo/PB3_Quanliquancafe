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
            addcbbDishGroup();
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
        public void addcbbDishGroup()
        {
            cbbDishGroup.Items.Add(new CBBItem { Value = "0" , Text = "Tất cả"});
            cbbDishGroup.Items.Add(new CBBItem { Value = "1", Text = "G001" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "2", Text = "G002" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "3", Text = "G003" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "4", Text = "G004" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "5", Text = "G005" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "6", Text = "G006" });
            cbbDishGroup.Items.Add(new CBBItem { Value = "7", Text = "G007" });
            cbbDishGroup.SelectedItem = 0;
        }
        private void butAddDish_Click(object sender, EventArgs e)
        {
            AddDish f = new AddDish();
            f.d = new AddDish.Mydel(addDatagrid);
            f.Show();
            d();
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
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        Quanli.Instance.DelDish(row.Cells[0].Value.ToString());
                    }
                }
                addDatagrid();
            }
        }

        private void cbbDishGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query;
            if(cbbDishGroup.SelectedIndex.Equals(0))
            {
                query = string.Format("Select * from [Menu]");
            }
            else
            {
                string groupID = "G00" + cbbDishGroup.SelectedIndex.ToString();
                query = string.Format("Select * from [Menu] where GroupID = N'{0}'", groupID);
            }
            dt.Columns.AddRange(new DataColumn[] {
            new DataColumn("ID món"),
            new DataColumn("Tên món"),
            new DataColumn("Giá"),
            new DataColumn("Nhóm món"),
            new DataColumn("Size"),
            });          
            dt = DBHelper.Instance.GetRecords(query);
            dataGridView1.DataSource = dt;
        
        }
    }
}
