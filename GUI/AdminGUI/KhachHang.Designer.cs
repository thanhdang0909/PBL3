namespace DoAnPBL3
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.pnlBanan = new System.Windows.Forms.Panel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dtgvKhachhang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnXemlichsudatban = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDiemTL = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenkhachhang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMakhachhang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBanan.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachhang)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanan
            // 
            this.pnlBanan.Controls.Add(this.guna2GradientPanel2);
            this.pnlBanan.Controls.Add(this.guna2GradientPanel1);
            this.pnlBanan.Controls.Add(this.txtTimkiem);
            this.pnlBanan.Controls.Add(this.btnTimkiem);
            this.pnlBanan.Controls.Add(this.guna2Panel2);
            this.pnlBanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBanan.Location = new System.Drawing.Point(0, 0);
            this.pnlBanan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBanan.Name = "pnlBanan";
            this.pnlBanan.Size = new System.Drawing.Size(1230, 701);
            this.pnlBanan.TabIndex = 0;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.dtgvKhachhang);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(542, 185);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(637, 376);
            this.guna2GradientPanel2.TabIndex = 55;
            // 
            // dtgvKhachhang
            // 
            this.dtgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maKH,
            this.tenKH,
            this.gioiTinh,
            this.SDT,
            this.diaChi,
            this.diemTichLuy});
            this.dtgvKhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKhachhang.Location = new System.Drawing.Point(0, 0);
            this.dtgvKhachhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvKhachhang.Name = "dtgvKhachhang";
            this.dtgvKhachhang.ReadOnly = true;
            this.dtgvKhachhang.RowHeadersWidth = 51;
            this.dtgvKhachhang.RowTemplate.Height = 24;
            this.dtgvKhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKhachhang.Size = new System.Drawing.Size(637, 376);
            this.dtgvKhachhang.TabIndex = 0;
            this.dtgvKhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKhachhang_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "maKH";
            this.maKH.HeaderText = "Mã khách hàng";
            this.maKH.MinimumWidth = 8;
            this.maKH.Name = "maKH";
            this.maKH.ReadOnly = true;
            this.maKH.Width = 150;
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "tenKH";
            this.tenKH.HeaderText = "Tên khách hàng";
            this.tenKH.MinimumWidth = 8;
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            this.tenKH.Width = 150;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            this.gioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gioiTinh.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 125;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 8;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 150;
            // 
            // diemTichLuy
            // 
            this.diemTichLuy.DataPropertyName = "diemTichLuy";
            this.diemTichLuy.HeaderText = "Điểm tích lũy";
            this.diemTichLuy.MinimumWidth = 8;
            this.diemTichLuy.Name = "diemTichLuy";
            this.diemTichLuy.ReadOnly = true;
            this.diemTichLuy.Width = 60;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.btnXemlichsudatban);
            this.guna2GradientPanel1.Controls.Add(this.btnCapnhat);
            this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(232, 588);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(842, 78);
            this.guna2GradientPanel1.TabIndex = 54;
            // 
            // btnXemlichsudatban
            // 
            this.btnXemlichsudatban.BorderRadius = 15;
            this.btnXemlichsudatban.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemlichsudatban.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemlichsudatban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemlichsudatban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemlichsudatban.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnXemlichsudatban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemlichsudatban.ForeColor = System.Drawing.Color.Black;
            this.btnXemlichsudatban.Image = ((System.Drawing.Image)(resources.GetObject("btnXemlichsudatban.Image")));
            this.btnXemlichsudatban.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXemlichsudatban.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnXemlichsudatban.ImageSize = new System.Drawing.Size(25, 25);
            this.btnXemlichsudatban.Location = new System.Drawing.Point(429, 10);
            this.btnXemlichsudatban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemlichsudatban.Name = "btnXemlichsudatban";
            this.btnXemlichsudatban.Size = new System.Drawing.Size(277, 56);
            this.btnXemlichsudatban.TabIndex = 2;
            this.btnXemlichsudatban.Text = "Xem lịch sử đặt bàn";
            this.btnXemlichsudatban.TextOffset = new System.Drawing.Point(20, 0);
            this.btnXemlichsudatban.Click += new System.EventHandler(this.btnXemlichsudatban_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BorderRadius = 15;
            this.btnCapnhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapnhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapnhat.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnCapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapnhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhat.Image")));
            this.btnCapnhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCapnhat.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnCapnhat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCapnhat.Location = new System.Drawing.Point(177, 10);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(190, 56);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextOffset = new System.Drawing.Point(20, 0);
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimkiem.BorderRadius = 15;
            this.txtTimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiem.DefaultText = "";
            this.txtTimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.Location = new System.Drawing.Point(51, 89);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PasswordChar = '\0';
            this.txtTimkiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.Size = new System.Drawing.Size(414, 48);
            this.txtTimkiem.TabIndex = 53;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BorderRadius = 15;
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimkiem.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnTimkiem.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTimkiem.Location = new System.Drawing.Point(515, 80);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(190, 56);
            this.btnTimkiem.TabIndex = 52;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Controls.Add(this.txtDiemTL);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.rdoNu);
            this.guna2Panel2.Controls.Add(this.rdoNam);
            this.guna2Panel2.Controls.Add(this.txtDiachi);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.txtSDT);
            this.guna2Panel2.Controls.Add(this.txtTenkhachhang);
            this.guna2Panel2.Controls.Add(this.txtMakhachhang);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel2.Location = new System.Drawing.Point(51, 185);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(485, 376);
            this.guna2Panel2.TabIndex = 51;
            // 
            // txtDiemTL
            // 
            this.txtDiemTL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemTL.DefaultText = "";
            this.txtDiemTL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiemTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiemTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemTL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemTL.Enabled = false;
            this.txtDiemTL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemTL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemTL.ForeColor = System.Drawing.Color.Black;
            this.txtDiemTL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemTL.Location = new System.Drawing.Point(160, 306);
            this.txtDiemTL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDiemTL.Name = "txtDiemTL";
            this.txtDiemTL.PasswordChar = '\0';
            this.txtDiemTL.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDiemTL.PlaceholderText = "";
            this.txtDiemTL.SelectedText = "";
            this.txtDiemTL.Size = new System.Drawing.Size(279, 48);
            this.txtDiemTL.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Điểm tích lũy";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.BackColor = System.Drawing.Color.Transparent;
            this.rdoNu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(260, 145);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(61, 27);
            this.rdoNu.TabIndex = 53;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = false;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.BackColor = System.Drawing.Color.Transparent;
            this.rdoNam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(161, 145);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(74, 27);
            this.rdoNam.TabIndex = 52;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = false;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachi.DefaultText = "";
            this.txtDiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiachi.ForeColor = System.Drawing.Color.Black;
            this.txtDiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.Location = new System.Drawing.Point(161, 248);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PasswordChar = '\0';
            this.txtDiachi.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDiachi.PlaceholderText = "";
            this.txtDiachi.SelectedText = "";
            this.txtDiachi.Size = new System.Drawing.Size(279, 48);
            this.txtDiachi.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Địa chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(161, 190);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(279, 48);
            this.txtSDT.TabIndex = 49;
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenkhachhang.DefaultText = "";
            this.txtTenkhachhang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenkhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenkhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenkhachhang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenkhachhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenkhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenkhachhang.ForeColor = System.Drawing.Color.Black;
            this.txtTenkhachhang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenkhachhang.Location = new System.Drawing.Point(160, 78);
            this.txtTenkhachhang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.PasswordChar = '\0';
            this.txtTenkhachhang.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenkhachhang.PlaceholderText = "";
            this.txtTenkhachhang.SelectedText = "";
            this.txtTenkhachhang.Size = new System.Drawing.Size(279, 48);
            this.txtTenkhachhang.TabIndex = 45;
            // 
            // txtMakhachhang
            // 
            this.txtMakhachhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMakhachhang.DefaultText = "";
            this.txtMakhachhang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMakhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMakhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMakhachhang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMakhachhang.Enabled = false;
            this.txtMakhachhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMakhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMakhachhang.ForeColor = System.Drawing.Color.Black;
            this.txtMakhachhang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMakhachhang.Location = new System.Drawing.Point(160, 19);
            this.txtMakhachhang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.PasswordChar = '\0';
            this.txtMakhachhang.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMakhachhang.PlaceholderText = "";
            this.txtMakhachhang.SelectedText = "";
            this.txtMakhachhang.Size = new System.Drawing.Size(279, 48);
            this.txtMakhachhang.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã khách hàng";
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 701);
            this.Controls.Add(this.pnlBanan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            this.pnlBanan.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachhang)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanan;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.DataGridView dtgvKhachhang;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnXemlichsudatban;
        private Guna.UI2.WinForms.Guna2Button btnCapnhat;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtTenkhachhang;
        private Guna.UI2.WinForms.Guna2TextBox txtMakhachhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTichLuy;
    }
}