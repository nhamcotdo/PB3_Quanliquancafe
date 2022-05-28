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
    public partial class ChangeInfo : Form
    {
        Staff staff;
        public delegate void MyDel();
        public MyDel d;
        public ChangeInfo(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            GUI();
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
            txtPassword.PasswordChar = '*';
            cbHide.Checked = false;
        }

        private void cbHide_CheckedChanged(object sender, EventArgs e)
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

        private void btnOK_Click(object sender, EventArgs e)
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
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
