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
            this.cbbCA = new System.Windows.Forms.ComboBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lbShift = new System.Windows.Forms.Label();
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
            this.grbTT.Controls.Add(this.cbbCA);
            this.grbTT.Controls.Add(this.lbPassWord);
            this.grbTT.Controls.Add(this.txtPassWord);
            this.grbTT.Controls.Add(this.lbShift);
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
            this.grbTT.Location = new System.Drawing.Point(9, 48);
            this.grbTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTT.Name = "grbTT";
            this.grbTT.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTT.Size = new System.Drawing.Size(582, 284);
            this.grbTT.TabIndex = 2;
            this.grbTT.TabStop = false;
            this.grbTT.Text = "Thông tin nhân viên";
            // 
            // btnNewID
            // 
            this.btnNewID.Location = new System.Drawing.Point(208, 37);
            this.btnNewID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewID.Name = "btnNewID";
            this.btnNewID.Size = new System.Drawing.Size(56, 19);
            this.btnNewID.TabIndex = 33;
            this.btnNewID.Text = "New ID";
            this.btnNewID.UseVisualStyleBackColor = true;
            this.btnNewID.Click += new System.EventHandler(this.btnNewID_Click);
            // 
            // cbbCA
            // 
            this.cbbCA.FormattingEnabled = true;
            this.cbbCA.Location = new System.Drawing.Point(349, 148);
            this.cbbCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbCA.Name = "cbbCA";
            this.cbbCA.Size = new System.Drawing.Size(170, 21);
            this.cbbCA.TabIndex = 32;
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Location = new System.Drawing.Point(287, 186);
            this.lbPassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(52, 13);
            this.lbPassWord.TabIndex = 31;
            this.lbPassWord.Text = "Mật khẩu";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(349, 186);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(170, 20);
            this.txtPassWord.TabIndex = 30;
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.Location = new System.Drawing.Point(292, 148);
            this.lbShift.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(39, 13);
            this.lbShift.TabIndex = 28;
            this.lbShift.Text = "Ca làm";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(110, 186);
            this.txtTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(150, 20);
            this.txtTK.TabIndex = 27;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(53, 186);
            this.lbAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(55, 13);
            this.lbAccount.TabIndex = 26;
            this.lbAccount.Text = "Tài khoản";
            // 
            // grbGT
            // 
            this.grbGT.Controls.Add(this.rdbFeMale);
            this.grbGT.Controls.Add(this.rdbMale);
            this.grbGT.Location = new System.Drawing.Point(178, 219);
            this.grbGT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbGT.Name = "grbGT";
            this.grbGT.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbGT.Size = new System.Drawing.Size(224, 51);
            this.grbGT.TabIndex = 25;
            this.grbGT.TabStop = false;
            this.grbGT.Text = "Giới tính";
            // 
            // rdbFeMale
            // 
            this.rdbFeMale.AutoSize = true;
            this.rdbFeMale.Location = new System.Drawing.Point(147, 23);
            this.rdbFeMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFeMale.Name = "rdbFeMale";
            this.rdbFeMale.Size = new System.Drawing.Size(39, 17);
            this.rdbFeMale.TabIndex = 27;
            this.rdbFeMale.TabStop = true;
            this.rdbFeMale.Text = "Nữ";
            this.rdbFeMale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(36, 23);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(47, 17);
            this.rdbMale.TabIndex = 26;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 93);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(349, 40);
            this.txtDC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(170, 20);
            this.txtDC.TabIndex = 23;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(110, 92);
            this.txtHT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(150, 20);
            this.txtHT.TabIndex = 22;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(110, 145);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 20);
            this.txtSDT.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(94, 20);
            this.txtID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số Điện Thoại";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(53, 93);
            this.lbHT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(58, 13);
            this.lbHT.TabIndex = 15;
            this.lbHT.Text = "Họ và Tên";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(71, 37);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 14;
            this.lbID.Text = "ID";
            // 
            // grbCN
            // 
            this.grbCN.Controls.Add(this.btnExit);
            this.grbCN.Controls.Add(this.btnDelete);
            this.grbCN.Controls.Add(this.btnEdit);
            this.grbCN.Controls.Add(this.btnAdd);
            this.grbCN.Location = new System.Drawing.Point(596, 48);
            this.grbCN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCN.Name = "grbCN";
            this.grbCN.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCN.Size = new System.Drawing.Size(150, 284);
            this.grbCN.TabIndex = 3;
            this.grbCN.TabStop = false;
            this.grbCN.Text = "Chức năng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(37, 240);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(37, 168);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(37, 93);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 31);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 360);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 232);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.Location = new System.Drawing.Point(301, 7);
            this.lbStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(162, 17);
            this.lbStaff.TabIndex = 5;
            this.lbStaff.Text = "Thông Tin Nhân Viên";
            // 
            // IFStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 618);
            this.Controls.Add(this.lbStaff);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbCN);
            this.Controls.Add(this.grbTT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IFStaff";
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
        private System.Windows.Forms.Label lbShift;
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
        private System.Windows.Forms.ComboBox cbbCA;
        private System.Windows.Forms.Button btnNewID;
    }
}