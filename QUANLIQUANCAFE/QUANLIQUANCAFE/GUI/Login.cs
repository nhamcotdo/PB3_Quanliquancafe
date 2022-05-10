using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLIQUANCAFE.DAL;
using QUANLIQUANCAFE.BLL;


namespace QUANLIQUANCAFE.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void butDN_Click(object sender, EventArgs e)
        {
            string account = txtbAccout.Text;
            string passWord = txtbPassWord.Text;
            if (Quanli.Instance.fLogin(account, passWord) == null)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");

            }
            else
            {
                MainForm mainForm = new MainForm(Quanli.Instance.fLogin(account, passWord));
                this.Hide();
                mainForm.ShowDialog();
                txtbAccout.Text = "";
                txtbPassWord.Text = "";
                this.Show();
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }
        //on enter key
        private void txtbAccout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butDN_Click(sender, e);
            }
        }
    }
}