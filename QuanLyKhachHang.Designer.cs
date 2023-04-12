﻿namespace PBL3.View
{
    partial class QuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKhachHang));
            this.pnlBanan = new System.Windows.Forms.Panel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dtgvKhachhang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnXemlichsudatban = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGioitinh = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.pnlBanan.Name = "pnlBanan";
            this.pnlBanan.Size = new System.Drawing.Size(1093, 561);
            this.pnlBanan.TabIndex = 0;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.dtgvKhachhang);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(482, 148);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(566, 301);
            this.guna2GradientPanel2.TabIndex = 55;
            // 
            // dtgvKhachhang
            // 
            this.dtgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.gioiTinh,
            this.SDT,
            this.Diachi});
            this.dtgvKhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKhachhang.Location = new System.Drawing.Point(0, 0);
            this.dtgvKhachhang.Name = "dtgvKhachhang";
            this.dtgvKhachhang.RowHeadersWidth = 51;
            this.dtgvKhachhang.RowTemplate.Height = 24;
            this.dtgvKhachhang.Size = new System.Drawing.Size(566, 301);
            this.dtgvKhachhang.TabIndex = 0;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 125;
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 125;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // Diachi
            // 
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 125;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.btnXemlichsudatban);
            this.guna2GradientPanel1.Controls.Add(this.btnCapnhat);
            this.guna2GradientPanel1.Controls.Add(this.btnThem);
            this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(152, 470);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(770, 62);
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
            this.btnXemlichsudatban.Location = new System.Drawing.Point(493, 8);
            this.btnXemlichsudatban.Name = "btnXemlichsudatban";
            this.btnXemlichsudatban.Size = new System.Drawing.Size(246, 45);
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
            this.btnCapnhat.Location = new System.Drawing.Point(262, 8);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(169, 45);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 15;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnThem.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThem.Location = new System.Drawing.Point(21, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(10, 0);
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
            this.txtTimkiem.Location = new System.Drawing.Point(45, 71);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PasswordChar = '\0';
            this.txtTimkiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.Size = new System.Drawing.Size(368, 38);
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
            this.btnTimkiem.Location = new System.Drawing.Point(458, 64);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(169, 45);
            this.btnTimkiem.TabIndex = 52;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Controls.Add(this.txtDiachi);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.txtSDT);
            this.guna2Panel2.Controls.Add(this.txtGioitinh);
            this.guna2Panel2.Controls.Add(this.txtTenkhachhang);
            this.guna2Panel2.Controls.Add(this.txtMakhachhang);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel2.Location = new System.Drawing.Point(45, 148);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(431, 301);
            this.guna2Panel2.TabIndex = 51;
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
            this.txtDiachi.Location = new System.Drawing.Point(142, 248);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PasswordChar = '\0';
            this.txtDiachi.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDiachi.PlaceholderText = "";
            this.txtDiachi.SelectedText = "";
            this.txtDiachi.Size = new System.Drawing.Size(229, 38);
            this.txtDiachi.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
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
            this.txtSDT.Location = new System.Drawing.Point(142, 190);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(229, 38);
            this.txtSDT.TabIndex = 49;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioitinh.DefaultText = "";
            this.txtGioitinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGioitinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGioitinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioitinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioitinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGioitinh.ForeColor = System.Drawing.Color.Black;
            this.txtGioitinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioitinh.Location = new System.Drawing.Point(142, 130);
            this.txtGioitinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.PasswordChar = '\0';
            this.txtGioitinh.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtGioitinh.PlaceholderText = "";
            this.txtGioitinh.SelectedText = "";
            this.txtGioitinh.Size = new System.Drawing.Size(229, 38);
            this.txtGioitinh.TabIndex = 48;
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
            this.txtTenkhachhang.Location = new System.Drawing.Point(142, 72);
            this.txtTenkhachhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.PasswordChar = '\0';
            this.txtTenkhachhang.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenkhachhang.PlaceholderText = "";
            this.txtTenkhachhang.SelectedText = "";
            this.txtTenkhachhang.Size = new System.Drawing.Size(229, 38);
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
            this.txtMakhachhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMakhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMakhachhang.ForeColor = System.Drawing.Color.Black;
            this.txtMakhachhang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMakhachhang.Location = new System.Drawing.Point(142, 15);
            this.txtMakhachhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.PasswordChar = '\0';
            this.txtMakhachhang.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMakhachhang.PlaceholderText = "";
            this.txtMakhachhang.SelectedText = "";
            this.txtMakhachhang.Size = new System.Drawing.Size(229, 38);
            this.txtMakhachhang.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã khách hàng";
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 561);
            this.Controls.Add(this.pnlBanan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtGioitinh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenkhachhang;
        private Guna.UI2.WinForms.Guna2TextBox txtMakhachhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
    }
}