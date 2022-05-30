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
using System.IO;

namespace QUANLIQUANCAFE.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Design();
        }
        void Design()
        {
            string[] background;
            string[] button;
            string[] label;
            string[] textbox;
            using (StreamReader sr = new StreamReader("config.txt"))
            {
                background = sr.ReadLine().Split(';');
                button = sr.ReadLine().Split(';');
                label = sr.ReadLine().Split(';');
                textbox = sr.ReadLine().Split(';');
            }
            if (background[0] == "Color")
            {
                this.BackColor = ColorTranslator.FromHtml(background[1]);
                this.BackgroundImage = null;
            }
            else
            {
                this.BackgroundImage = Image.FromFile(background[1]);
            }
            foreach (Control i in panel1.Controls)
            {
                if (i is Button)
                {
                    i.BackColor = ColorTranslator.FromHtml(button[0]);
                    i.ForeColor = ColorTranslator.FromHtml(button[1]);
                }
                else if (i is Label)
                {
                    i.ForeColor = ColorTranslator.FromHtml(label[0]);
                }
                else if (i is TextBox)
                {
                    i.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    i.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }

            }

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