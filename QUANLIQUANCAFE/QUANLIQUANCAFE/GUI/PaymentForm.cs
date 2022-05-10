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
    public partial class PaymentForm : Form
    {
        public delegate void Mydel();
        public Mydel d;
        string TableID;
        public PaymentForm(string TableID, Staff NV)
        {
            InitializeComponent();
            this.TableID = TableID;
        }
        void GUI()
        {

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Quanli.Instance.Pay(TableID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
