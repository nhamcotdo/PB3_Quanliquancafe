using QUANLIQUANCAFE.BLL;
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
    public partial class GUICustom : Form
    {
        string backnow;
        public delegate void Mydel();
        public Mydel d;

        public GUICustom()
        {
            InitializeComponent();
            Design();
            Quanli.Instance.LoadLang(this);

        }

        private void GenLang()
        {
            using (StreamWriter sw = new StreamWriter(Name + ".txt"))
            {
                foreach (Control i in this.Controls)
                {
                    if (i.Text != "")
                        sw.WriteLine(i.Name + ";" + i.Text + ";" + Quanli.Instance.TranslateText(i.Text, "vi", "en"));
                }
            }
        }

        void Design()
        {
            string[] background;
            string[] button;
            string[] label;
            string[] textbox;
            using (StreamReader sr = new StreamReader("config.txt"))
            {
                backnow = sr.ReadLine();
                background = backnow.Split(';');
                button = sr.ReadLine().Split(';');
                label = sr.ReadLine().Split(';');
                textbox = sr.ReadLine().Split(';');
            }
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    c.BackColor = ColorTranslator.FromHtml(button[0]);
                    c.ForeColor = ColorTranslator.FromHtml(button[1]);
                }
                if (c.GetType() == typeof(Label))
                {
                    c.BackColor = ColorTranslator.FromHtml(label[0]);
                    c.ForeColor = ColorTranslator.FromHtml(label[1]);
                }
                if (c.GetType() == typeof(TextBox))
                {
                    c.BackColor = ColorTranslator.FromHtml(textbox[0]);
                    c.ForeColor = ColorTranslator.FromHtml(textbox[1]);
                }
            }
            if (background[0] == "Color")
            {
                BackColor = ColorTranslator.FromHtml(background[1]);
                btnBackColor.BackColor = ColorTranslator.FromHtml(background[1]);
            }
            else
            {
                BackgroundImage = Image.FromFile(background[1]);
                BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.Image = Image.FromFile(background[1]);
            }
            btnButBackColor.BackColor = ColorTranslator.FromHtml(button[0]);
            btnButTextColor.BackColor = ColorTranslator.FromHtml(button[1]);
            btnLabelTextColor.BackColor = ColorTranslator.FromHtml(label[1]);
            btnTxtBackColor.BackColor = ColorTranslator.FromHtml(textbox[0]);
            btnTxtTextColor.BackColor = ColorTranslator.FromHtml(textbox[1]);
            // xanh đỏ
            btnOK.BackColor = Color.Green;
            btnOK.ForeColor = Color.White;
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;

        }
        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                this.BackgroundImage = null;
                backnow = "Color;" + ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //choose file jpg
            openFileDialog1.Filter = "IMG Files| *.jpg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                backnow = "IMG;" + openFileDialog1.FileName;
            }
        }

        private void btnButBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnButBackColor.BackColor = colorDialog1.Color;
                btnExample.BackColor = colorDialog1.Color;
            }
        }

        private void btnButTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnButTextColor.BackColor = colorDialog1.Color;
                btnExample.ForeColor = colorDialog1.Color;
            }
        }

        private void btnLabelTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnLabelTextColor.BackColor = colorDialog1.Color;
                lbExample.ForeColor = colorDialog1.Color;
            }
        }

        private void btnTxtBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnTxtBackColor.BackColor = colorDialog1.Color;
                txtExample.BackColor = colorDialog1.Color;
            }
        }

        private void btnTxtTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnTxtTextColor.BackColor = colorDialog1.Color;
                txtExample.ForeColor = colorDialog1.Color;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("config.txt"))
            {
                sw.WriteLine(backnow);
                sw.WriteLine(ColorTranslator.ToHtml(btnExample.BackColor) + ";" + ColorTranslator.ToHtml(btnExample.ForeColor));
                sw.WriteLine(ColorTranslator.ToHtml(lbExample.BackColor) + ";" + ColorTranslator.ToHtml(lbExample.ForeColor));
                sw.WriteLine(ColorTranslator.ToHtml(txtExample.BackColor) + ";" + ColorTranslator.ToHtml(txtExample.ForeColor));
            }
            d();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
