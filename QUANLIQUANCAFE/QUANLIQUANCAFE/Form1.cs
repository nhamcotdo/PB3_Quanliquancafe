using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLIQUANCAFE
{
    public partial class Form1 : Form
    {
        Quanli bll = new Quanli();
        Color c = Color.FromArgb(0, 255, 255);

        public Form1()
        {
            InitializeComponent();

            LoadComponet();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int mg = (int)(this.flowLayoutPanel6.Width - this.button33.Width - this.button34.Width - this.button35.Width) / 6;
            this.button34.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
            this.button35.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
            this.button33.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);

        }




        private void LoadComponet()
        {
            // set location and color for button(Gọi món, Gộp bàn, Thanh toán)
            //int mg = (int)(this.flowLayoutPanel6.Width - this.button33.Width - this.button34.Width - this.button35.Width) / 6;
            //this.button34.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
            //this.button34.BackColor = c;
            //this.button35.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
            //this.button35.BackColor = c;
            //this.button33.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
            //this.button33.BackColor = c;

            int w = this.flowLayout1.Width;
            //add KV to flowLayoutPanel
            foreach (FlowLayoutPanel i in bll.ListPanelKV(w, c))
                this.flowLayout1.Controls.Add(i);
        }
    }
}

