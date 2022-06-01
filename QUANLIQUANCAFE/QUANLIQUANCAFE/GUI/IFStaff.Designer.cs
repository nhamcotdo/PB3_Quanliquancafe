namespace QUANLIQUANCAFE.GUI
{
    partial class IFStaff
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
            this.grbTT = new System.Windows.Forms.GroupBox();
            this.btnNewID = new System.Windows.Forms.Button();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lbAccount = new System.Windows.Forms.Label();
            this.grbGT = new System.Windows.Forms.GroupBox();
            this.rdbFeMale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.grbCN = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbStaff = new System.Windows.Forms.Label();
            this.grbTT.SuspendLayout();
            this.grbGT.SuspendLayout();
            this.grbCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTT
            // 
            this.grbTT.Controls.Add(this.btnNewID);
            this.grbTT.Controls.Add(this.lbPassWord);
            this.grbTT.Controls.Add(this.txtPassWord);
            this.grbTT.Controls.Add(this.txtTK);
            this.grbTT.Controls.Add(this.lbAccount);
            this.grbTT.Controls.Add(this.grbGT);
            this.grbTT.Controls.Add(this.dateTimePicker1);
            this.grbTT.Controls.Add(this.txtDC);
            this.grbTT.Controls.Add(this.txtHT);
            this.grbTT.Controls.Add(this.txtSDT);
            this.grbTT.Controls.Add(this.txtID);
            this.grbTT.Controls.Add(this.label5);
            this.grbTT.Controls.Add(this.label4);
            this.grbTT.Controls.Add(this.label3);
            this.grbTT.Controls.Add(this.lbHT);
            this.grbTT.Controls.Add(this.lbID);
            this.grbTT.Location = new System.Drawing.Point(12, 59);
            this.grbTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTT.Name = "grbTT";
            this.grbTT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTT.Size = new System.Drawing.Size(776, 350);
            this.grbTT.TabIndex = 2;
            this.grbTT.TabStop = false;
            this.grbTT.Text = "Thông tin nhân viên";
            // 
            // btnNewID
            // 
            this.btnNewID.Location = new System.Drawing.Point(277, 46);
            this.btnNewID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewID.Name = "btnNewID";
            this.btnNewID.Size = new System.Drawing.Size(75, 23);
            this.btnNewID.TabIndex = 33;
            this.btnNewID.Text = "New ID";
            this.btnNewID.UseVisualStyleBackColor = true;
            this.btnNewID.Click += new System.EventHandler(this.btnNewID_Click);
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Location = new System.Drawing.Point(381, 276);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(61, 16);
            this.lbPassWord.TabIndex = 31;
            this.lbPassWord.Text = "Mật khẩu";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(456, 276);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(225, 22);
            this.txtPassWord.TabIndex = 30;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(147, 279);
            this.txtTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(199, 22);
            this.txtTK.TabIndex = 27;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(71, 279);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(67, 16);
            this.lbAccount.TabIndex = 26;
            this.lbAccount.Text = "Tài khoản";
            // 
            // grbGT
            // 
            this.grbGT.Controls.Add(this.rdbFeMale);
            this.grbGT.Controls.Add(this.rdbMale);
            this.grbGT.Location = new System.Drawing.Point(393, 182);
            this.grbGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGT.Name = "grbGT";
            this.grbGT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGT.Size = new System.Drawing.Size(299, 63);
            this.grbGT.TabIndex = 25;
            this.grbGT.TabStop = false;
            this.grbGT.Text = "Giới tính";
            // 
            // rdbFeMale
            // 
            this.rdbFeMale.AutoSize = true;
            this.rdbFeMale.Location = new System.Drawing.Point(196, 28);
            this.rdbFeMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFeMale.Name = "rdbFeMale";
            this.rdbFeMale.Size = new System.Drawing.Size(45, 20);
            this.rdbFeMale.TabIndex = 27;
            this.rdbFeMale.TabStop = true;
            this.rdbFeMale.Text = "Nữ";
            this.rdbFeMale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(48, 28);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(57, 20);
            this.rdbMale.TabIndex = 26;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 121);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(465, 49);
            this.txtDC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(225, 22);
            this.txtDC.TabIndex = 23;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(147, 121);
            this.txtHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(199, 22);
            this.txtHT.TabIndex = 22;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(147, 207);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(199, 22);
            this.txtSDT.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(147, 46);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(124, 22);
            this.txtID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số Điện Thoại";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(59, 120);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(70, 16);
            this.lbHT.TabIndex = 15;
            this.lbHT.Text = "Họ và Tên";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(95, 46);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(20, 16);
            this.lbID.TabIndex = 14;
            this.lbID.Text = "ID";
            // 
            // grbCN
            // 
            this.grbCN.Controls.Add(this.btnExit);
            this.grbCN.Controls.Add(this.btnDelete);
            this.grbCN.Controls.Add(this.btnEdit);
            this.grbCN.Controls.Add(this.btnAdd);
            this.grbCN.Location = new System.Drawing.Point(795, 59);
            this.grbCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCN.Name = "grbCN";
            this.grbCN.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCN.Size = new System.Drawing.Size(200, 350);
            this.grbCN.TabIndex = 3;
            this.grbCN.TabStop = false;
            this.grbCN.Text = "Chức năng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(49, 295);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(49, 207);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 38);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(49, 114);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 38);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 38);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 443);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(981, 286);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.Location = new System.Drawing.Point(401, 9);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(184, 20);
            this.lbStaff.TabIndex = 5;
            this.lbStaff.Text = "Thông Tin Nhân Viên";
            // 
            // IFStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 761);
            this.Controls.Add(this.lbStaff);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbCN);
            this.Controls.Add(this.grbTT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IFStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IFStaff";
            this.grbTT.ResumeLayout(false);
            this.grbTT.PerformLayout();
            this.grbGT.ResumeLayout(false);
            this.grbGT.PerformLayout();
            this.grbCN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTT;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.GroupBox grbGT;
        private System.Windows.Forms.RadioButton rdbFeMale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox grbCN;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnNewID;
    }
}