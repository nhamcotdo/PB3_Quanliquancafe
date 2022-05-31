namespace QUANLIQUANCAFE.GUI
{
    partial class DiscountManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDiscountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cbPercent = new System.Windows.Forms.CheckBox();
            this.addorupdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.btnNewID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(694, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtDiscountName
            // 
            this.txtDiscountName.Location = new System.Drawing.Point(160, 79);
            this.txtDiscountName.Name = "txtDiscountName";
            this.txtDiscountName.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên mã giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá trị";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(371, 40);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 3;
            // 
            // cbPercent
            // 
            this.cbPercent.AutoSize = true;
            this.cbPercent.Location = new System.Drawing.Point(315, 79);
            this.cbPercent.Name = "cbPercent";
            this.cbPercent.Size = new System.Drawing.Size(101, 17);
            this.cbPercent.TabIndex = 5;
            this.cbPercent.Text = "Theo phần trăm";
            this.cbPercent.UseVisualStyleBackColor = true;
            // 
            // addorupdate
            // 
            this.addorupdate.Location = new System.Drawing.Point(569, 61);
            this.addorupdate.Name = "addorupdate";
            this.addorupdate.Size = new System.Drawing.Size(121, 23);
            this.addorupdate.TabIndex = 6;
            this.addorupdate.Text = "Thêm hoặc sửa";
            this.addorupdate.UseVisualStyleBackColor = true;
            this.addorupdate.Click += new System.EventHandler(this.addorupdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(441, 82);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(79, 17);
            this.cbActive.TabIndex = 9;
            this.cbActive.Text = "Có hiệu lực";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // btnNewID
            // 
            this.btnNewID.Location = new System.Drawing.Point(201, 38);
            this.btnNewID.Name = "btnNewID";
            this.btnNewID.Size = new System.Drawing.Size(59, 23);
            this.btnNewID.TabIndex = 10;
            this.btnNewID.Text = "NewID";
            this.btnNewID.UseVisualStyleBackColor = true;
            this.btnNewID.Click += new System.EventHandler(this.btnNewID_Click);
            // 
            // DiscountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewID);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.addorupdate);
            this.Controls.Add(this.cbPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscountName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DiscountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDiscountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.CheckBox cbPercent;
        private System.Windows.Forms.Button addorupdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Button btnNewID;
    }
}