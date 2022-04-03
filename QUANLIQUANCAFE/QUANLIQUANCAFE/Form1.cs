using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLIQUANCAFE
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            int mg = (int)(this.flowLayoutPanel6.Width - this.button33.Width - this.button34.Width - this.button35.Width) / 6;
            this.button34.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
            this.button35.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
            this.button33.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int mg = (int)(this.flowLayoutPanel6.Width - this.button33.Width - this.button34.Width - this.button35.Width) / 6;
            this.button34.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
            this.button35.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
            this.button33.Margin = new System.Windows.Forms.Padding(mg, 3, mg, 3);
        }
    }
}
