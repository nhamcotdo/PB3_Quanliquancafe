namespace QUANLIQUANCAFE
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tcLTNV = new System.Windows.Forms.TabPage();
            this.tcTKNV = new System.Windows.Forms.TabPage();
            this.tcKho = new System.Windows.Forms.TabPage();
            this.tcHDTC = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tcLTNV);
            this.tabControl1.Controls.Add(this.tcTKNV);
            this.tabControl1.Controls.Add(this.tcKho);
            this.tabControl1.Controls.Add(this.tcHDTC);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 542);
            this.tabControl1.TabIndex = 0;
            // 
            // tcLTNV
            // 
            this.tcLTNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcLTNV.Location = new System.Drawing.Point(4, 25);
            this.tcLTNV.Name = "tcLTNV";
            this.tcLTNV.Padding = new System.Windows.Forms.Padding(3);
            this.tcLTNV.Size = new System.Drawing.Size(805, 513);
            this.tcLTNV.TabIndex = 0;
            this.tcLTNV.Text = "Lịch trực nhân viên";
            this.tcLTNV.UseVisualStyleBackColor = true;
            // 
            // tcTKNV
            // 
            this.tcTKNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTKNV.Location = new System.Drawing.Point(4, 25);
            this.tcTKNV.Name = "tcTKNV";
            this.tcTKNV.Padding = new System.Windows.Forms.Padding(3);
            this.tcTKNV.Size = new System.Drawing.Size(805, 513);
            this.tcTKNV.TabIndex = 1;
            this.tcTKNV.Text = "Tài khoản nhân viên";
            this.tcTKNV.UseVisualStyleBackColor = true;
            // 
            // tcKho
            // 
            this.tcKho.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcKho.Location = new System.Drawing.Point(4, 25);
            this.tcKho.Name = "tcKho";
            this.tcKho.Size = new System.Drawing.Size(805, 513);
            this.tcKho.TabIndex = 2;
            this.tcKho.Text = "Kho";
            this.tcKho.UseVisualStyleBackColor = true;
            // 
            // tcHDTC
            // 
            this.tcHDTC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcHDTC.Location = new System.Drawing.Point(4, 25);
            this.tcHDTC.Name = "tcHDTC";
            this.tcHDTC.Size = new System.Drawing.Size(805, 513);
            this.tcHDTC.TabIndex = 3;
            this.tcHDTC.Text = "Hóa đơn thu chi";
            this.tcHDTC.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tcLTNV;
        private System.Windows.Forms.TabPage tcTKNV;
        private System.Windows.Forms.TabPage tcKho;
        private System.Windows.Forms.TabPage tcHDTC;
    }
}