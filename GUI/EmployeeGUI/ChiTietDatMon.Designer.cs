namespace DoAnPBL3.View
{
    partial class ChiTietDatMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietDatMon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCTDM = new System.Windows.Forms.Panel();
            this.cbbMaBan = new System.Windows.Forms.ComboBox();
            this.dtpkNgayDat = new System.Windows.Forms.DateTimePicker();
            this.btnTaoHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaDat = new Guna.UI2.WinForms.Guna2Button();
            this.txtDG = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbTenMA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvCTDB = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCTDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTDB)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCTDM
            // 
            this.pnlCTDM.Controls.Add(this.cbbMaBan);
            this.pnlCTDM.Controls.Add(this.dtpkNgayDat);
            this.pnlCTDM.Controls.Add(this.btnTaoHD);
            this.pnlCTDM.Controls.Add(this.btnThoat);
            this.pnlCTDM.Controls.Add(this.numSL);
            this.pnlCTDM.Controls.Add(this.btnCapNhat);
            this.pnlCTDM.Controls.Add(this.btnXoaDat);
            this.pnlCTDM.Controls.Add(this.txtDG);
            this.pnlCTDM.Controls.Add(this.cbbTenMA);
            this.pnlCTDM.Controls.Add(this.label1);
            this.pnlCTDM.Controls.Add(this.txtMaPV);
            this.pnlCTDM.Controls.Add(this.label3);
            this.pnlCTDM.Controls.Add(this.label2);
            this.pnlCTDM.Controls.Add(this.label5);
            this.pnlCTDM.Controls.Add(this.groupBox1);
            this.pnlCTDM.Controls.Add(this.btnTimKiem);
            this.pnlCTDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCTDM.Location = new System.Drawing.Point(0, 0);
            this.pnlCTDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCTDM.Name = "pnlCTDM";
            this.pnlCTDM.Size = new System.Drawing.Size(1230, 754);
            this.pnlCTDM.TabIndex = 0;
            // 
            // cbbMaBan
            // 
            this.cbbMaBan.FormattingEnabled = true;
            this.cbbMaBan.Location = new System.Drawing.Point(50, 21);
            this.cbbMaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaBan.Name = "cbbMaBan";
            this.cbbMaBan.Size = new System.Drawing.Size(262, 28);
            this.cbbMaBan.TabIndex = 128;
            // 
            // dtpkNgayDat
            // 
            this.dtpkNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayDat.Location = new System.Drawing.Point(50, 68);
            this.dtpkNgayDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkNgayDat.Name = "dtpkNgayDat";
            this.dtpkNgayDat.ShowUpDown = true;
            this.dtpkNgayDat.Size = new System.Drawing.Size(262, 26);
            this.dtpkNgayDat.TabIndex = 127;
            this.dtpkNgayDat.Value = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            this.dtpkNgayDat.ValueChanged += new System.EventHandler(this.dtpkNgayDat_ValueChanged);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BorderRadius = 15;
            this.btnTaoHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoHD.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTaoHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.ForeColor = System.Drawing.Color.White;
            this.btnTaoHD.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoHD.Image")));
            this.btnTaoHD.ImageSize = new System.Drawing.Size(22, 22);
            this.btnTaoHD.Location = new System.Drawing.Point(154, 685);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(190, 56);
            this.btnTaoHD.TabIndex = 126;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoRoundedCorners = true;
            this.btnThoat.BorderRadius = 27;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThoat.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnThoat.ImageSize = new System.Drawing.Size(22, 22);
            this.btnThoat.Location = new System.Drawing.Point(863, 685);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 56);
            this.btnThoat.TabIndex = 125;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextOffset = new System.Drawing.Point(15, 0);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(338, 198);
            this.numSL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(96, 26);
            this.numSL.TabIndex = 124;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 15;
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCapNhat.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCapNhat.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCapNhat.Location = new System.Drawing.Point(389, 685);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(190, 56);
            this.btnCapNhat.TabIndex = 123;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextOffset = new System.Drawing.Point(15, 0);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaDat
            // 
            this.btnXoaDat.BorderRadius = 15;
            this.btnXoaDat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaDat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaDat.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnXoaDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDat.ForeColor = System.Drawing.Color.White;
            this.btnXoaDat.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDat.Image")));
            this.btnXoaDat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaDat.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnXoaDat.ImageSize = new System.Drawing.Size(22, 22);
            this.btnXoaDat.Location = new System.Drawing.Point(626, 685);
            this.btnXoaDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDat.Name = "btnXoaDat";
            this.btnXoaDat.Size = new System.Drawing.Size(190, 56);
            this.btnXoaDat.TabIndex = 122;
            this.btnXoaDat.Text = "Xóa món";
            this.btnXoaDat.TextOffset = new System.Drawing.Point(15, 0);
            this.btnXoaDat.Click += new System.EventHandler(this.btnXoaDat_Click);
            // 
            // txtDG
            // 
            this.txtDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDG.DefaultText = "";
            this.txtDG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDG.Enabled = false;
            this.txtDG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDG.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDG.ForeColor = System.Drawing.Color.Black;
            this.txtDG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDG.Location = new System.Drawing.Point(730, 198);
            this.txtDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDG.Name = "txtDG";
            this.txtDG.PasswordChar = '\0';
            this.txtDG.PlaceholderText = "";
            this.txtDG.SelectedText = "";
            this.txtDG.Size = new System.Drawing.Size(270, 31);
            this.txtDG.TabIndex = 121;
            // 
            // cbbTenMA
            // 
            this.cbbTenMA.DropDownHeight = 90;
            this.cbbTenMA.DropDownWidth = 200;
            this.cbbTenMA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenMA.FormattingEnabled = true;
            this.cbbTenMA.IntegralHeight = false;
            this.cbbTenMA.Location = new System.Drawing.Point(730, 152);
            this.cbbTenMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenMA.Name = "cbbTenMA";
            this.cbbTenMA.Size = new System.Drawing.Size(270, 33);
            this.cbbTenMA.TabIndex = 120;
            this.cbbTenMA.SelectedIndexChanged += new System.EventHandler(this.cbbTenMA_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(210, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 115;
            this.label1.Text = "Mã phục vụ";
            // 
            // txtMaPV
            // 
            this.txtMaPV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPV.DefaultText = "";
            this.txtMaPV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPV.Enabled = false;
            this.txtMaPV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPV.ForeColor = System.Drawing.Color.Black;
            this.txtMaPV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPV.Location = new System.Drawing.Point(338, 152);
            this.txtMaPV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPV.Name = "txtMaPV";
            this.txtMaPV.PasswordChar = '\0';
            this.txtMaPV.PlaceholderText = "";
            this.txtMaPV.SelectedText = "";
            this.txtMaPV.Size = new System.Drawing.Size(210, 31);
            this.txtMaPV.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(210, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 116;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(579, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 117;
            this.label2.Text = "Tên món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(579, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 118;
            this.label5.Text = "Đơn giá";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvCTDB);
            this.groupBox1.Location = new System.Drawing.Point(63, 248);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1102, 416);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đặt món";
            // 
            // dtgvCTDB
            // 
            this.dtgvCTDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maPV,
            this.maMA,
            this.tenMA,
            this.soLuong,
            this.giaMA});
            this.dtgvCTDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCTDB.Location = new System.Drawing.Point(3, 21);
            this.dtgvCTDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCTDB.Name = "dtgvCTDB";
            this.dtgvCTDB.ReadOnly = true;
            this.dtgvCTDB.RowHeadersWidth = 62;
            this.dtgvCTDB.RowTemplate.Height = 28;
            this.dtgvCTDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCTDB.Size = new System.Drawing.Size(1096, 393);
            this.dtgvCTDB.TabIndex = 64;
            this.dtgvCTDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCTDB_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 150;
            // 
            // maPV
            // 
            this.maPV.DataPropertyName = "maPV";
            this.maPV.HeaderText = "Mã phục vụ";
            this.maPV.MinimumWidth = 8;
            this.maPV.Name = "maPV";
            this.maPV.ReadOnly = true;
            this.maPV.Width = 150;
            // 
            // maMA
            // 
            this.maMA.DataPropertyName = "maMA";
            this.maMA.HeaderText = "Mã món ăn";
            this.maMA.MinimumWidth = 8;
            this.maMA.Name = "maMA";
            this.maMA.ReadOnly = true;
            this.maMA.Width = 150;
            // 
            // tenMA
            // 
            this.tenMA.DataPropertyName = "tenMA";
            this.tenMA.HeaderText = "Tên món ăn";
            this.tenMA.MinimumWidth = 8;
            this.tenMA.Name = "tenMA";
            this.tenMA.ReadOnly = true;
            this.tenMA.Width = 150;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 8;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 150;
            // 
            // giaMA
            // 
            this.giaMA.DataPropertyName = "giaMA";
            dataGridViewCellStyle1.Format = "#,### VNĐ";
            this.giaMA.DefaultCellStyle = dataGridViewCellStyle1;
            this.giaMA.HeaderText = "Đơn giá";
            this.giaMA.MinimumWidth = 8;
            this.giaMA.Name = "giaMA";
            this.giaMA.ReadOnly = true;
            this.giaMA.Width = 150;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(22, 22);
            this.btnTimKiem.Location = new System.Drawing.Point(349, 36);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(162, 48);
            this.btnTimKiem.TabIndex = 112;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // ChiTietDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 754);
            this.Controls.Add(this.pnlCTDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChiTietDatMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietDatBan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChiTietDatBan_Load);
            this.pnlCTDM.ResumeLayout(false);
            this.pnlCTDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCTDM;
        private Guna.UI2.WinForms.Guna2Button btnTaoHD;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private System.Windows.Forms.NumericUpDown numSL;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnXoaDat;
        private Guna.UI2.WinForms.Guna2TextBox txtDG;
        private System.Windows.Forms.ComboBox cbbTenMA;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvCTDB;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtpkNgayDat;
        private System.Windows.Forms.ComboBox cbbMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaMA;
    }
}