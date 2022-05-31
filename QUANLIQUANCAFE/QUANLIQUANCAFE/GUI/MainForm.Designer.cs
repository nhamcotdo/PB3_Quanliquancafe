namespace QUANLIQUANCAFE.GUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchTrựcNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IFStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiNgônNgữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuITiengViet = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemenglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripChangeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbNameNV = new System.Windows.Forms.Label();
            this.flowLayoutTable = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutQuanLiTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cbbFoodMenu = new System.Windows.Forms.ComboBox();
            this.cbbDishGroup = new System.Windows.Forms.ComboBox();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.btnFree = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.cbbTableName = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTableName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnFooter.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíToolStripMenuItem,
            this.càiĐặToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1312, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchTrựcNhânViênToolStripMenuItem,
            this.IFStaffToolStripMenuItem,
            this.khoToolStripMenuItem,
            this.thuChiToolStripMenuItem,
            this.editMenu,
            this.DiscountToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // lịchTrựcNhânViênToolStripMenuItem
            // 
            this.lịchTrựcNhânViênToolStripMenuItem.Name = "lịchTrựcNhânViênToolStripMenuItem";
            this.lịchTrựcNhânViênToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.lịchTrựcNhânViênToolStripMenuItem.Text = "Lịch trực nhân viên";
            // 
            // IFStaffToolStripMenuItem
            // 
            this.IFStaffToolStripMenuItem.Name = "IFStaffToolStripMenuItem";
            this.IFStaffToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.IFStaffToolStripMenuItem.Text = "Tài khoản nhân viên";
            this.IFStaffToolStripMenuItem.Click += new System.EventHandler(this.IFStaffToolStripMenuItem_Click);
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.khoToolStripMenuItem.Text = "Kho";
            this.khoToolStripMenuItem.Click += new System.EventHandler(this.khoToolStripMenuItem_Click_1);
            // 
            // thuChiToolStripMenuItem
            // 
            this.thuChiToolStripMenuItem.Name = "thuChiToolStripMenuItem";
            this.thuChiToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.thuChiToolStripMenuItem.Text = "Thu chi";
            this.thuChiToolStripMenuItem.Click += new System.EventHandler(this.thuChiToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(221, 26);
            this.editMenu.Text = "Điều chỉnh Menu";
            this.editMenu.Click += new System.EventHandler(this.editMenu_cCick);
            // 
            // DiscountToolStripMenuItem
            // 
            this.DiscountToolStripMenuItem.Name = "DiscountToolStripMenuItem";
            this.DiscountToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.DiscountToolStripMenuItem.Text = "Mã giảm giá";
            this.DiscountToolStripMenuItem.Click += new System.EventHandler(this.DiscountToolStripMenuItem_Click);
            // 
            // càiĐặToolStripMenuItem
            // 
            this.càiĐặToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemChangeColor,
            this.đổiNgônNgữToolStripMenuItem});
            this.càiĐặToolStripMenuItem.Name = "càiĐặToolStripMenuItem";
            this.càiĐặToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.càiĐặToolStripMenuItem.Text = "Cài đặt";
            // 
            // ToolStripMenuItemChangeColor
            // 
            this.ToolStripMenuItemChangeColor.Name = "ToolStripMenuItemChangeColor";
            this.ToolStripMenuItemChangeColor.Size = new System.Drawing.Size(184, 26);
            this.ToolStripMenuItemChangeColor.Text = "Đổi màu nền";
            this.ToolStripMenuItemChangeColor.Click += new System.EventHandler(this.ToolStripMenuItemChangeColor_Click);
            // 
            // đổiNgônNgữToolStripMenuItem
            // 
            this.đổiNgônNgữToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuITiengViet,
            this.ToolStripMenuItemenglish});
            this.đổiNgônNgữToolStripMenuItem.Name = "đổiNgônNgữToolStripMenuItem";
            this.đổiNgônNgữToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.đổiNgônNgữToolStripMenuItem.Text = "Đổi ngôn ngữ";
            // 
            // ToolStripMenuITiengViet
            // 
            this.ToolStripMenuITiengViet.Name = "ToolStripMenuITiengViet";
            this.ToolStripMenuITiengViet.Size = new System.Drawing.Size(157, 26);
            this.ToolStripMenuITiengViet.Text = "Tiếng việt";
            this.ToolStripMenuITiengViet.Click += new System.EventHandler(this.ToolStripMenuITiengViet_Click);
            // 
            // ToolStripMenuItemenglish
            // 
            this.ToolStripMenuItemenglish.Name = "ToolStripMenuItemenglish";
            this.ToolStripMenuItemenglish.Size = new System.Drawing.Size(157, 26);
            this.ToolStripMenuItemenglish.Text = "English";
            this.ToolStripMenuItemenglish.Click += new System.EventHandler(this.ToolStripMenuItemenglish_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripChangeInfo,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // toolstripChangeInfo
            // 
            this.toolstripChangeInfo.Name = "toolstripChangeInfo";
            this.toolstripChangeInfo.Size = new System.Drawing.Size(181, 26);
            this.toolstripChangeInfo.Text = "Đổi mật khẩu";
            this.toolstripChangeInfo.Click += new System.EventHandler(this.toolstripChangeInfo_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1312, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 786);
            this.panel1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // lbNameNV
            // 
            this.lbNameNV.AutoSize = true;
            this.lbNameNV.Location = new System.Drawing.Point(1039, 10);
            this.lbNameNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameNV.Name = "lbNameNV";
            this.lbNameNV.Size = new System.Drawing.Size(28, 16);
            this.lbNameNV.TabIndex = 6;
            this.lbNameNV.Text = "111";
            // 
            // flowLayoutTable
            // 
            this.flowLayoutTable.AutoScroll = true;
            this.flowLayoutTable.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutTable.Controls.Add(this.label1);
            this.flowLayoutTable.Controls.Add(this.flowLayoutQuanLiTable);
            this.flowLayoutTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutTable.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutTable.Name = "flowLayoutTable";
            this.flowLayoutTable.Size = new System.Drawing.Size(440, 786);
            this.flowLayoutTable.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH BÀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutQuanLiTable
            // 
            this.flowLayoutQuanLiTable.AutoSize = true;
            this.flowLayoutQuanLiTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutQuanLiTable.Location = new System.Drawing.Point(433, 4);
            this.flowLayoutQuanLiTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutQuanLiTable.Name = "flowLayoutQuanLiTable";
            this.flowLayoutQuanLiTable.Size = new System.Drawing.Size(0, 59);
            this.flowLayoutQuanLiTable.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pnHeader);
            this.panel2.Controls.Add(this.pnFooter);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(451, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 780);
            this.panel2.TabIndex = 9;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnHeader.Controls.Add(this.numericUpDown1);
            this.pnHeader.Controls.Add(this.btnOrder);
            this.pnHeader.Controls.Add(this.cbbFoodMenu);
            this.pnHeader.Controls.Add(this.cbbDishGroup);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(845, 70);
            this.pnHeader.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(559, 23);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // btnOrder
            // 
            this.btnOrder.AutoSize = true;
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(336, 15);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(167, 41);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Gọi món";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // cbbFoodMenu
            // 
            this.cbbFoodMenu.FormattingEnabled = true;
            this.cbbFoodMenu.Location = new System.Drawing.Point(25, 37);
            this.cbbFoodMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbFoodMenu.Name = "cbbFoodMenu";
            this.cbbFoodMenu.Size = new System.Drawing.Size(277, 24);
            this.cbbFoodMenu.TabIndex = 1;
            // 
            // cbbDishGroup
            // 
            this.cbbDishGroup.FormattingEnabled = true;
            this.cbbDishGroup.Location = new System.Drawing.Point(25, 4);
            this.cbbDishGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDishGroup.Name = "cbbDishGroup";
            this.cbbDishGroup.Size = new System.Drawing.Size(277, 24);
            this.cbbDishGroup.TabIndex = 0;
            this.cbbDishGroup.SelectedIndexChanged += new System.EventHandler(this.cbbDishGroup_SelectedIndexChanged);
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btnFree);
            this.pnFooter.Controls.Add(this.btnDel);
            this.pnFooter.Controls.Add(this.btnAdd);
            this.pnFooter.Controls.Add(this.btnMove);
            this.pnFooter.Controls.Add(this.btnPay);
            this.pnFooter.Controls.Add(this.btnMerge);
            this.pnFooter.Controls.Add(this.cbbTableName);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 675);
            this.pnFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(845, 105);
            this.pnFooter.TabIndex = 5;
            // 
            // btnFree
            // 
            this.btnFree.AutoSize = true;
            this.btnFree.BackColor = System.Drawing.Color.White;
            this.btnFree.Location = new System.Drawing.Point(8, 58);
            this.btnFree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(167, 41);
            this.btnFree.TabIndex = 8;
            this.btnFree.Text = "Làm trống bàn";
            this.btnFree.UseVisualStyleBackColor = false;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(421, 58);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(167, 41);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Xóa Bàn";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(213, 58);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Tạo bàn";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMove
            // 
            this.btnMove.AutoSize = true;
            this.btnMove.BackColor = System.Drawing.Color.White;
            this.btnMove.Location = new System.Drawing.Point(213, 4);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(167, 41);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Chuyển bàn";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnPay
            // 
            this.btnPay.AutoSize = true;
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(631, 12);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 86);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "THANH TOÁN";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.AutoSize = true;
            this.btnMerge.BackColor = System.Drawing.Color.White;
            this.btnMerge.Location = new System.Drawing.Point(421, 0);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(167, 41);
            this.btnMerge.TabIndex = 0;
            this.btnMerge.Text = "GỘP BÀN";
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // cbbTableName
            // 
            this.cbbTableName.FormattingEnabled = true;
            this.cbbTableName.Location = new System.Drawing.Point(8, 12);
            this.cbbTableName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTableName.Name = "cbbTableName";
            this.cbbTableName.Size = new System.Drawing.Size(160, 24);
            this.cbbTableName.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.lbTableName);
            this.panel4.Location = new System.Drawing.Point(8, 78);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(829, 591);
            this.panel4.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(829, 499);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbTableName
            // 
            this.lbTableName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTableName.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableName.Location = new System.Drawing.Point(0, 0);
            this.lbTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(829, 92);
            this.lbTableName.TabIndex = 3;
            this.lbTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.flowLayoutTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbNameNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1194, 726);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ BÁN HÀNG";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutTable.ResumeLayout(false);
            this.flowLayoutTable.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchTrựcNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IFStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuChiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangeColor;
        private System.Windows.Forms.ToolStripMenuItem đổiNgônNgữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstripChangeInfo;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.Label lbNameNV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuITiengViet;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemenglish;
        private System.Windows.Forms.ToolStripMenuItem DiscountToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutQuanLiTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cbbFoodMenu;
        private System.Windows.Forms.ComboBox cbbDishGroup;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.ComboBox cbbTableName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Button btnFree;
    }
}
