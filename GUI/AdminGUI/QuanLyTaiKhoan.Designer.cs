using System.Runtime.CompilerServices;

namespace DoAnPBL3
{
    partial class QuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTaiKhoan));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvQLTK = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaiTro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtKytu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTendangnhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbVaitro = new System.Windows.Forms.ComboBox();
            this.txtMathau = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLTK)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dtgvQLTK);
            this.guna2Panel1.Location = new System.Drawing.Point(14, 130);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(683, 425);
            this.guna2Panel1.TabIndex = 7;
            // 
            // dtgvQLTK
            // 
            this.dtgvQLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maTK,
            this.tenDangNhap,
            this.kyTu,
            this.vaiTro});
            this.dtgvQLTK.Location = new System.Drawing.Point(4, 4);
            this.dtgvQLTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvQLTK.Name = "dtgvQLTK";
            this.dtgvQLTK.ReadOnly = true;
            this.dtgvQLTK.RowHeadersWidth = 51;
            this.dtgvQLTK.RowTemplate.Height = 24;
            this.dtgvQLTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLTK.Size = new System.Drawing.Size(675, 415);
            this.dtgvQLTK.TabIndex = 0;
            this.dtgvQLTK.SelectionChanged += new System.EventHandler(this.dtgvQLTK_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // maTK
            // 
            this.maTK.DataPropertyName = "maTK";
            this.maTK.HeaderText = "Mã tài khoản";
            this.maTK.MinimumWidth = 6;
            this.maTK.Name = "maTK";
            this.maTK.ReadOnly = true;
            this.maTK.Width = 125;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.DataPropertyName = "tenDangNhap";
            this.tenDangNhap.HeaderText = "Tên đăng nhập";
            this.tenDangNhap.MinimumWidth = 6;
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.ReadOnly = true;
            this.tenDangNhap.Width = 125;
            // 
            // kyTu
            // 
            this.kyTu.DataPropertyName = "kyTu";
            this.kyTu.HeaderText = "Ký tự";
            this.kyTu.MinimumWidth = 6;
            this.kyTu.Name = "kyTu";
            this.kyTu.ReadOnly = true;
            this.kyTu.Width = 125;
            // 
            // vaiTro
            // 
            this.vaiTro.DataPropertyName = "vaiTro";
            this.vaiTro.HeaderText = "Vai trò";
            this.vaiTro.MinimumWidth = 6;
            this.vaiTro.Name = "vaiTro";
            this.vaiTro.ReadOnly = true;
            this.vaiTro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vaiTro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vaiTro.Width = 125;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel2.Controls.Add(this.btnHuy);
            this.guna2Panel2.Controls.Add(this.btnCapnhat);
            this.guna2Panel2.Controls.Add(this.btnXoa);
            this.guna2Panel2.Controls.Add(this.btnThem);
            this.guna2Panel2.Location = new System.Drawing.Point(14, 562);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(683, 151);
            this.guna2Panel2.TabIndex = 8;
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 15;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHuy.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHuy.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHuy.Location = new System.Drawing.Point(169, 81);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(168, 56);
            this.btnHuy.TabIndex = 49;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextOffset = new System.Drawing.Point(20, 0);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnCapnhat.Location = new System.Drawing.Point(505, 81);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(164, 56);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextOffset = new System.Drawing.Point(15, 0);
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnXoa.ImageSize = new System.Drawing.Size(25, 25);
            this.btnXoa.Location = new System.Drawing.Point(343, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(164, 56);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextOffset = new System.Drawing.Point(15, 0);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThem.Location = new System.Drawing.Point(15, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(164, 56);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel3.Controls.Add(this.txtKytu);
            this.guna2Panel3.Controls.Add(this.label8);
            this.guna2Panel3.Controls.Add(this.txtMaTK);
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.Controls.Add(this.txtTendangnhap);
            this.guna2Panel3.Controls.Add(this.cbbVaitro);
            this.guna2Panel3.Controls.Add(this.txtMathau);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Location = new System.Drawing.Point(703, 130);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(487, 584);
            this.guna2Panel3.TabIndex = 9;
            // 
            // txtKytu
            // 
            this.txtKytu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKytu.DefaultText = "";
            this.txtKytu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKytu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKytu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKytu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKytu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKytu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKytu.ForeColor = System.Drawing.Color.Black;
            this.txtKytu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKytu.Location = new System.Drawing.Point(227, 466);
            this.txtKytu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtKytu.Name = "txtKytu";
            this.txtKytu.PasswordChar = '\0';
            this.txtKytu.PlaceholderText = "";
            this.txtKytu.SelectedText = "";
            this.txtKytu.Size = new System.Drawing.Size(206, 35);
            this.txtKytu.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ký tự";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTK.DefaultText = "";
            this.txtMaTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTK.Enabled = false;
            this.txtMaTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaTK.ForeColor = System.Drawing.Color.Black;
            this.txtMaTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTK.Location = new System.Drawing.Point(227, 275);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.PasswordChar = '\0';
            this.txtMaTK.PlaceholderText = "";
            this.txtMaTK.SelectedText = "";
            this.txtMaTK.Size = new System.Drawing.Size(206, 35);
            this.txtMaTK.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã tài khoản";
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTendangnhap.DefaultText = "";
            this.txtTendangnhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTendangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTendangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTendangnhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTendangnhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTendangnhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTendangnhap.ForeColor = System.Drawing.Color.Black;
            this.txtTendangnhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTendangnhap.Location = new System.Drawing.Point(227, 340);
            this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTendangnhap.MaxLength = 10;
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.PasswordChar = '\0';
            this.txtTendangnhap.PlaceholderText = "";
            this.txtTendangnhap.SelectedText = "";
            this.txtTendangnhap.Size = new System.Drawing.Size(206, 35);
            this.txtTendangnhap.TabIndex = 10;
            // 
            // cbbVaitro
            // 
            this.cbbVaitro.FormattingEnabled = true;
            this.cbbVaitro.Location = new System.Drawing.Point(227, 529);
            this.cbbVaitro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbVaitro.MaxLength = 25555;
            this.cbbVaitro.Name = "cbbVaitro";
            this.cbbVaitro.Size = new System.Drawing.Size(205, 28);
            this.cbbVaitro.TabIndex = 9;
            // 
            // txtMathau
            // 
            this.txtMathau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMathau.DefaultText = "";
            this.txtMathau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMathau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMathau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMathau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMathau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMathau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMathau.ForeColor = System.Drawing.Color.Black;
            this.txtMathau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMathau.Location = new System.Drawing.Point(227, 402);
            this.txtMathau.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMathau.MaxLength = 6;
            this.txtMathau.Name = "txtMathau";
            this.txtMathau.PasswordChar = '\0';
            this.txtMathau.PlaceholderText = "";
            this.txtMathau.SelectedText = "";
            this.txtMathau.Size = new System.Drawing.Size(206, 35);
            this.txtMathau.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vai trò";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vai trò = 0 : Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vai trò = 1 : Người quản lý";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(268, 40);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(82, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
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
            this.txtTimkiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.Location = new System.Drawing.Point(42, 29);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PasswordChar = '\0';
            this.txtTimkiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.Size = new System.Drawing.Size(414, 48);
            this.txtTimkiem.TabIndex = 55;
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
            this.btnTimkiem.Location = new System.Drawing.Point(506, 20);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(190, 56);
            this.btnTimkiem.TabIndex = 54;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 754);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLTK)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dtgvQLTK;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnCapnhat;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTendangnhap;
        private System.Windows.Forms.ComboBox cbbVaitro;
        private Guna.UI2.WinForms.Guna2TextBox txtMathau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTK;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2TextBox txtKytu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyTu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vaiTro;
    }
}