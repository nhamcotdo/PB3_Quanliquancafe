namespace QUANLIQUANCAFE.GUI
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbtable = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.panelBill = new System.Windows.Forms.Panel();
            this.lbOther = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbPromotion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.daylb = new System.Windows.Forms.Label();
            this.lbNV = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbkm = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panelBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Location = new System.Drawing.Point(91, 675);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 36);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Xác nhận in hóa đơn";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(383, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ABC CAFE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ: abc, xyz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(99, 68);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 13);
            this.lbTime.TabIndex = 6;
            // 
            // lbtable
            // 
            this.lbtable.AutoSize = true;
            this.lbtable.Location = new System.Drawing.Point(316, 68);
            this.lbtable.Name = "lbtable";
            this.lbtable.Size = new System.Drawing.Size(36, 13);
            this.lbtable.TabIndex = 7;
            this.lbtable.Text = "Bàn X";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.BackColor = System.Drawing.Color.Transparent;
            this.label111.Location = new System.Drawing.Point(50, 101);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(59, 13);
            this.label111.TabIndex = 8;
            this.label111.Text = "Thu ngân: ";
            // 
            // panelBill
            // 
            this.panelBill.BackColor = System.Drawing.Color.Linen;
            this.panelBill.Controls.Add(this.lbOther);
            this.panelBill.Controls.Add(this.label10);
            this.panelBill.Controls.Add(this.lbTotalPrice);
            this.panelBill.Controls.Add(this.lbPromotion);
            this.panelBill.Controls.Add(this.dataGridView1);
            this.panelBill.Controls.Add(this.daylb);
            this.panelBill.Controls.Add(this.lbNV);
            this.panelBill.Controls.Add(this.lbTime);
            this.panelBill.Controls.Add(this.label111);
            this.panelBill.Controls.Add(this.lbTotal);
            this.panelBill.Controls.Add(this.lbtable);
            this.panelBill.Controls.Add(this.label7);
            this.panelBill.Controls.Add(this.label6);
            this.panelBill.Controls.Add(this.label3);
            this.panelBill.Controls.Add(this.label5);
            this.panelBill.Controls.Add(this.label4);
            this.panelBill.Controls.Add(this.label2);
            this.panelBill.Controls.Add(this.label1);
            this.panelBill.Location = new System.Drawing.Point(89, 12);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(420, 594);
            this.panelBill.TabIndex = 10;
            // 
            // lbOther
            // 
            this.lbOther.AutoSize = true;
            this.lbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOther.Location = new System.Drawing.Point(297, 500);
            this.lbOther.Name = "lbOther";
            this.lbOther.Size = new System.Drawing.Size(16, 18);
            this.lbOther.TabIndex = 16;
            this.lbOther.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Chi phí khác";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(297, 530);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(16, 18);
            this.lbTotalPrice.TabIndex = 14;
            this.lbTotalPrice.Text = "0";
            // 
            // lbPromotion
            // 
            this.lbPromotion.AutoSize = true;
            this.lbPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromotion.Location = new System.Drawing.Point(297, 472);
            this.lbPromotion.Name = "lbPromotion";
            this.lbPromotion.Size = new System.Drawing.Size(16, 18);
            this.lbPromotion.TabIndex = 13;
            this.lbPromotion.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Linen;
            this.dataGridView1.Location = new System.Drawing.Point(53, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(309, 320);
            this.dataGridView1.TabIndex = 12;
            // 
            // daylb
            // 
            this.daylb.AutoSize = true;
            this.daylb.BackColor = System.Drawing.Color.Transparent;
            this.daylb.Location = new System.Drawing.Point(105, 68);
            this.daylb.Name = "daylb";
            this.daylb.Size = new System.Drawing.Size(0, 13);
            this.daylb.TabIndex = 11;
            // 
            // lbNV
            // 
            this.lbNV.AutoSize = true;
            this.lbNV.BackColor = System.Drawing.Color.Transparent;
            this.lbNV.Location = new System.Drawing.Point(105, 99);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(0, 13);
            this.lbNV.TabIndex = 10;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(297, 440);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(50, 18);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Tổng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tổng tiền: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Khuyến mại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cảm ơn quý khách và hẹn gặp lại!!!!";
            // 
            // cbbkm
            // 
            this.cbbkm.FormattingEnabled = true;
            this.cbbkm.Location = new System.Drawing.Point(408, 609);
            this.cbbkm.Name = "cbbkm";
            this.cbbkm.Size = new System.Drawing.Size(97, 21);
            this.cbbkm.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(92, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Chọn khuyến mại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(93, 636);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Chi phí khác";
            // 
            // tbOther
            // 
            this.tbOther.Location = new System.Drawing.Point(408, 649);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(97, 20);
            this.tbOther.TabIndex = 14;
            this.tbOther.TextChanged += new System.EventHandler(this.tbOther_TextChanged);
            this.tbOther.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOther_KeyPress);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 723);
            this.Controls.Add(this.tbOther);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbkm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panelBill);
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.panelBill.ResumeLayout(false);
            this.panelBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbtable;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label daylb;
        private System.Windows.Forms.Label lbNV;
        private System.Windows.Forms.ComboBox cbbkm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbPromotion;
        private System.Windows.Forms.Label lbOther;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}