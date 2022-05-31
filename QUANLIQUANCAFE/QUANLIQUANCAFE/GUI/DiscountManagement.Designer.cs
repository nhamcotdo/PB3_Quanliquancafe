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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewID = new System.Windows.Forms.Button();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.addorupdate = new System.Windows.Forms.Button();
            this.cbPercent = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscountName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(925, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewID);
            this.panel1.Controls.Add(this.cbActive);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.addorupdate);
            this.panel1.Controls.Add(this.cbPercent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDiscountName);
            this.panel1.Location = new System.Drawing.Point(71, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 119);
            this.panel1.TabIndex = 1;
            // 
            // btnNewID
            // 
            this.btnNewID.Location = new System.Drawing.Point(237, 22);
            this.btnNewID.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewID.Name = "btnNewID";
            this.btnNewID.Size = new System.Drawing.Size(79, 28);
            this.btnNewID.TabIndex = 20;
            this.btnNewID.Text = "NewID";
            this.btnNewID.UseVisualStyleBackColor = true;
            this.btnNewID.Click += new System.EventHandler(this.btnNewID_Click);
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(557, 76);
            this.cbActive.Margin = new System.Windows.Forms.Padding(4);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(94, 20);
            this.cbActive.TabIndex = 19;
            this.cbActive.Text = "Có hiệu lực";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(96, 24);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 17;
            // 
            // addorupdate
            // 
            this.addorupdate.Location = new System.Drawing.Point(728, 50);
            this.addorupdate.Margin = new System.Windows.Forms.Padding(4);
            this.addorupdate.Name = "addorupdate";
            this.addorupdate.Size = new System.Drawing.Size(161, 28);
            this.addorupdate.TabIndex = 16;
            this.addorupdate.Text = "Thêm hoặc sửa";
            this.addorupdate.UseVisualStyleBackColor = true;
            this.addorupdate.Click += new System.EventHandler(this.addorupdate_Click);
            // 
            // cbPercent
            // 
            this.cbPercent.AutoSize = true;
            this.cbPercent.Location = new System.Drawing.Point(389, 72);
            this.cbPercent.Margin = new System.Windows.Forms.Padding(4);
            this.cbPercent.Name = "cbPercent";
            this.cbPercent.Size = new System.Drawing.Size(123, 20);
            this.cbPercent.TabIndex = 15;
            this.cbPercent.Text = "Theo phần trăm";
            this.cbPercent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Giá trị";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(464, 24);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(132, 22);
            this.txtValue.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên mã giảm giá";
            // 
            // txtDiscountName
            // 
            this.txtDiscountName.Location = new System.Drawing.Point(182, 72);
            this.txtDiscountName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscountName.Name = "txtDiscountName";
            this.txtDiscountName.Size = new System.Drawing.Size(132, 22);
            this.txtDiscountName.TabIndex = 11;
            // 
            // DiscountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiscountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewID;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button addorupdate;
        private System.Windows.Forms.CheckBox cbPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscountName;
    }
}