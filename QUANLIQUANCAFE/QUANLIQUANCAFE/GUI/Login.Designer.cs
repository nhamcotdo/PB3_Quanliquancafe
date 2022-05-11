namespace QUANLIQUANCAFE.GUI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.butDN = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbPassWord = new System.Windows.Forms.TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbAccout = new System.Windows.Forms.TextBox();
            this.lbTDN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butDN);
            this.panel1.Controls.Add(this.butExit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 184);
            this.panel1.TabIndex = 0;
            // 
            // butDN
            // 
            this.butDN.Location = new System.Drawing.Point(101, 130);
            this.butDN.Margin = new System.Windows.Forms.Padding(2);
            this.butDN.Name = "butDN";
            this.butDN.Size = new System.Drawing.Size(87, 30);
            this.butDN.TabIndex = 3;
            this.butDN.Text = "Đăng nhập";
            this.butDN.UseVisualStyleBackColor = true;
            this.butDN.Click += new System.EventHandler(this.butDN_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(223, 130);
            this.butExit.Margin = new System.Windows.Forms.Padding(2);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(87, 30);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "Thoát";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtbPassWord);
            this.panel3.Controls.Add(this.lbMK);
            this.panel3.Location = new System.Drawing.Point(2, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 46);
            this.panel3.TabIndex = 2;
            // 
            // txtbPassWord
            // 
            this.txtbPassWord.Location = new System.Drawing.Point(163, 11);
            this.txtbPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtbPassWord.Name = "txtbPassWord";
            this.txtbPassWord.PasswordChar = '*';
            this.txtbPassWord.Size = new System.Drawing.Size(208, 20);
            this.txtbPassWord.TabIndex = 1;
            this.txtbPassWord.UseSystemPasswordChar = true;
            this.txtbPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbAccout_KeyDown);
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Location = new System.Drawing.Point(20, 10);
            this.lbMK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(78, 19);
            this.lbMK.TabIndex = 1;
            this.lbMK.Text = "Mật khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbAccout);
            this.panel2.Controls.Add(this.lbTDN);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 46);
            this.panel2.TabIndex = 1;
            // 
            // txtbAccout
            // 
            this.txtbAccout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbAccout.Location = new System.Drawing.Point(163, 11);
            this.txtbAccout.Margin = new System.Windows.Forms.Padding(2);
            this.txtbAccout.Name = "txtbAccout";
            this.txtbAccout.Size = new System.Drawing.Size(208, 20);
            this.txtbAccout.TabIndex = 1;
            // 
            // lbTDN
            // 
            this.lbTDN.AutoSize = true;
            this.lbTDN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTDN.Location = new System.Drawing.Point(20, 11);
            this.lbTDN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTDN.Name = "lbTDN";
            this.lbTDN.Size = new System.Drawing.Size(124, 19);
            this.lbTDN.TabIndex = 1;
            this.lbTDN.Text = "Tên đăng nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 204);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTDN;
        private System.Windows.Forms.TextBox txtbAccout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbPassWord;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button butDN;
        private System.Windows.Forms.Button butExit;
    }
}