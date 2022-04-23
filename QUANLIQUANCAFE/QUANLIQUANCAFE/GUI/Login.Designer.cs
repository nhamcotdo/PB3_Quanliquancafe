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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.lbTDN = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbPassWord = new System.Windows.Forms.TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.butDN = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butDN);
            this.panel1.Controls.Add(this.butExit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 226);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbUser);
            this.panel2.Controls.Add(this.lbTDN);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 56);
            this.panel2.TabIndex = 1;
            // 
            // txtbUser
            // 
            this.txtbUser.Cursor = System.Windows.Forms.Cursors.No;
            this.txtbUser.Location = new System.Drawing.Point(217, 14);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(276, 22);
            this.txtbUser.TabIndex = 1;
            // 
            // lbTDN
            // 
            this.lbTDN.AutoSize = true;
            this.lbTDN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTDN.Location = new System.Drawing.Point(26, 14);
            this.lbTDN.Name = "lbTDN";
            this.lbTDN.Size = new System.Drawing.Size(152, 24);
            this.lbTDN.TabIndex = 1;
            this.lbTDN.Text = "Tên đăng nhập";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtbPassWord);
            this.panel3.Controls.Add(this.lbMK);
            this.panel3.Location = new System.Drawing.Point(3, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 56);
            this.panel3.TabIndex = 2;
            // 
            // txtbPassWord
            // 
            this.txtbPassWord.Location = new System.Drawing.Point(217, 14);
            this.txtbPassWord.Name = "txtbPassWord";
            this.txtbPassWord.PasswordChar = '*';
            this.txtbPassWord.Size = new System.Drawing.Size(276, 22);
            this.txtbPassWord.TabIndex = 1;
            this.txtbPassWord.UseSystemPasswordChar = true;
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Location = new System.Drawing.Point(26, 12);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(97, 24);
            this.lbMK.TabIndex = 1;
            this.lbMK.Text = "Mật khẩu";
            // 
            // butDN
            // 
            this.butDN.Location = new System.Drawing.Point(135, 160);
            this.butDN.Name = "butDN";
            this.butDN.Size = new System.Drawing.Size(116, 37);
            this.butDN.TabIndex = 3;
            this.butDN.Text = "Đăng nhập";
            this.butDN.UseVisualStyleBackColor = true;
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(297, 160);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(116, 37);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "Thoát";
            this.butExit.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 251);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTDN;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbPassWord;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button butDN;
        private System.Windows.Forms.Button butExit;
    }
}