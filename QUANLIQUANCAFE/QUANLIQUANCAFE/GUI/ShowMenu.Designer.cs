namespace QUANLIQUANCAFE.GUI
{
    partial class ShowMenu
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
            this.butAddDish = new System.Windows.Forms.Button();
            this.butDelDish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDishGroup = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // butAddDish
            // 
            this.butAddDish.Location = new System.Drawing.Point(549, 33);
            this.butAddDish.Name = "butAddDish";
            this.butAddDish.Size = new System.Drawing.Size(75, 23);
            this.butAddDish.TabIndex = 1;
            this.butAddDish.Text = "Thêm món";
            this.butAddDish.UseVisualStyleBackColor = true;
            this.butAddDish.Click += new System.EventHandler(this.butAddDish_Click);
            // 
            // butDelDish
            // 
            this.butDelDish.Location = new System.Drawing.Point(657, 33);
            this.butDelDish.Name = "butDelDish";
            this.butDelDish.Size = new System.Drawing.Size(75, 23);
            this.butDelDish.TabIndex = 2;
            this.butDelDish.Text = "Xóa món";
            this.butDelDish.UseVisualStyleBackColor = true;
            this.butDelDish.Click += new System.EventHandler(this.butDelDish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhóm";
            // 
            // cbbDishGroup
            // 
            this.cbbDishGroup.FormattingEnabled = true;
            this.cbbDishGroup.Location = new System.Drawing.Point(378, 35);
            this.cbbDishGroup.Name = "cbbDishGroup";
            this.cbbDishGroup.Size = new System.Drawing.Size(121, 21);
            this.cbbDishGroup.TabIndex = 4;
            this.cbbDishGroup.SelectedIndexChanged += new System.EventHandler(this.cbbDishGroup_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.butDelDish);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butAddDish);
            this.panel1.Controls.Add(this.cbbDishGroup);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 71);
            this.panel1.TabIndex = 5;
            // 
            // ShowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ShowMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butAddDish;
        private System.Windows.Forms.Button butDelDish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDishGroup;
        private System.Windows.Forms.Panel panel1;
    }
}