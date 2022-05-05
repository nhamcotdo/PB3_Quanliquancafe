namespace QUANLIQUANCAFE.GUI
{
    partial class AddDish
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDishID = new System.Windows.Forms.TextBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.butOK = new System.Windows.Forms.Button();
            this.butCC = new System.Windows.Forms.Button();
            this.cbbGroup = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // txtDishID
            // 
            this.txtDishID.Location = new System.Drawing.Point(168, 33);
            this.txtDishID.Name = "txtDishID";
            this.txtDishID.Size = new System.Drawing.Size(100, 20);
            this.txtDishID.TabIndex = 3;
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(168, 59);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(100, 20);
            this.txtDishName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(168, 85);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(87, 232);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 6;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCC
            // 
            this.butCC.Location = new System.Drawing.Point(193, 232);
            this.butCC.Name = "butCC";
            this.butCC.Size = new System.Drawing.Size(75, 23);
            this.butCC.TabIndex = 7;
            this.butCC.Text = "Hủy";
            this.butCC.UseVisualStyleBackColor = true;
            // 
            // cbbGroup
            // 
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(168, 112);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(121, 21);
            this.cbbGroup.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbSize);
            this.panel1.Controls.Add(this.cbbGroup);
            this.panel1.Controls.Add(this.butCC);
            this.panel1.Controls.Add(this.butOK);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtDishName);
            this.panel1.Controls.Add(this.txtDishID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 287);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhóm đồ ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Size";
            // 
            // cbbSize
            // 
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Location = new System.Drawing.Point(168, 140);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(121, 21);
            this.cbbSize.TabIndex = 9;
            // 
            // AddDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 318);
            this.Controls.Add(this.panel1);
            this.Name = "AddDish";
            this.Text = "AddDish";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDishID;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCC;
        private System.Windows.Forms.ComboBox cbbGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbSize;
    }
}