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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // butAddDish
            // 
            this.butAddDish.Location = new System.Drawing.Point(540, 43);
            this.butAddDish.Name = "butAddDish";
            this.butAddDish.Size = new System.Drawing.Size(75, 23);
            this.butAddDish.TabIndex = 1;
            this.butAddDish.Text = "Thêm món";
            this.butAddDish.UseVisualStyleBackColor = true;
            this.butAddDish.Click += new System.EventHandler(this.butAddDish_Click);
            // 
            // butDelDish
            // 
            this.butDelDish.Location = new System.Drawing.Point(658, 43);
            this.butDelDish.Name = "butDelDish";
            this.butDelDish.Size = new System.Drawing.Size(75, 23);
            this.butDelDish.TabIndex = 2;
            this.butDelDish.Text = "Xóa món";
            this.butDelDish.UseVisualStyleBackColor = true;
            this.butDelDish.Click += new System.EventHandler(this.butDelDish_Click);
            // 
            // ShowMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butDelDish);
            this.Controls.Add(this.butAddDish);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowMenu";
            this.Text = "ShowMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butAddDish;
        private System.Windows.Forms.Button butDelDish;
    }
}