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
    public partial class ChangeInfo : Form
    {
        Staff staff;
        public ChangeInfo(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            GUI();
            Design();
        }
        void GUI()
        {
            txtStaffID.Text = staff.StaffID;
            txtStaffID.Enabled = false;
            txtStaffName.Text = staff.StaffName;
            txtPhoneNumber.Text = staff.PhoneNumber;
            txtAddress.Text = staff.Address;
            dtpDatein.Value = staff.DateIn;
            if (staff.Sex)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            txtAccount.Text = Quanli.Instance.GetAccountByStaffID(staff.StaffID).Account;
            txtPassword.Text = Quanli.Instance.GetAccountByStaffID(staff.StaffID).Password;
            cbHide.Checked = false;
        }
        private void cbHide_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbHide.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            Quanli.Instance.ChangeInfo(
                new Staff()
                {
                    StaffID = txtStaffID.Text,
                    StaffName = txtStaffName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    DateIn = dtpDatein.Value,
                    Sex = rbMale.Checked
                },
                new AccountDTO
                {
                    StaffID = txtStaffID.Text,
                    Account = txtAccount.Text,
                    Password = txtPassword.Text,
                    Role = Quanli.Instance.GetAccountByStaffID(staff.StaffID).Role
                }
                );
            this.Dispose();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        
    }
}
