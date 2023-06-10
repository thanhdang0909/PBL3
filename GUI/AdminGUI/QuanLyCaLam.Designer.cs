using System.Windows.Forms;

namespace DoAnPBL3
{
    partial class QuanLyCaLam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyCaLam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbTrangthai = new System.Windows.Forms.ComboBox();
            this.dtmNgaylam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtmGiobatdau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtmGioketthuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dtgvCatruc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dtmTimkiem = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel2.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatruc)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnTimkiem.Location = new System.Drawing.Point(542, 8);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(190, 56);
            this.btnTimkiem.TabIndex = 47;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Controls.Add(this.cbbTrangthai);
            this.guna2Panel2.Controls.Add(this.dtmNgaylam);
            this.guna2Panel2.Controls.Add(this.dtmGiobatdau);
            this.guna2Panel2.Controls.Add(this.dtmGioketthuc);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.txtSoluong);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.txtMaCT);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel2.Location = new System.Drawing.Point(78, 95);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(505, 458);
            this.guna2Panel2.TabIndex = 49;
            // 
            // cbbTrangthai
            // 
            this.cbbTrangthai.FormattingEnabled = true;
            this.cbbTrangthai.Location = new System.Drawing.Point(160, 394);
            this.cbbTrangthai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTrangthai.Name = "cbbTrangthai";
            this.cbbTrangthai.Size = new System.Drawing.Size(254, 28);
            this.cbbTrangthai.TabIndex = 58;
            // 
            // dtmNgaylam
            // 
            this.dtmNgaylam.Checked = true;
            this.dtmNgaylam.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaylam.FillColor = System.Drawing.Color.Silver;
            this.dtmNgaylam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmNgaylam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaylam.Location = new System.Drawing.Point(160, 89);
            this.dtmNgaylam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtmNgaylam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmNgaylam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmNgaylam.Name = "dtmNgaylam";
            this.dtmNgaylam.ShowUpDown = true;
            this.dtmNgaylam.Size = new System.Drawing.Size(254, 45);
            this.dtmNgaylam.TabIndex = 57;
            this.dtmNgaylam.Value = new System.DateTime(2023, 6, 7, 0, 0, 0, 0);
            // 
            // dtmGiobatdau
            // 
            this.dtmGiobatdau.Checked = true;
            this.dtmGiobatdau.CustomFormat = "hh:mm:ss tt";
            this.dtmGiobatdau.FillColor = System.Drawing.Color.Silver;
            this.dtmGiobatdau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmGiobatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmGiobatdau.Location = new System.Drawing.Point(160, 162);
            this.dtmGiobatdau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtmGiobatdau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmGiobatdau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmGiobatdau.Name = "dtmGiobatdau";
            this.dtmGiobatdau.ShowUpDown = true;
            this.dtmGiobatdau.Size = new System.Drawing.Size(254, 45);
            this.dtmGiobatdau.TabIndex = 56;
            this.dtmGiobatdau.Value = new System.DateTime(2023, 4, 21, 8, 6, 18, 25);
            // 
            // dtmGioketthuc
            // 
            this.dtmGioketthuc.Checked = true;
            this.dtmGioketthuc.CustomFormat = "hh:mm:ss tt";
            this.dtmGioketthuc.FillColor = System.Drawing.Color.Silver;
            this.dtmGioketthuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmGioketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmGioketthuc.Location = new System.Drawing.Point(160, 239);
            this.dtmGioketthuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtmGioketthuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmGioketthuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmGioketthuc.Name = "dtmGioketthuc";
            this.dtmGioketthuc.ShowUpDown = true;
            this.dtmGioketthuc.Size = new System.Drawing.Size(254, 45);
            this.dtmGioketthuc.TabIndex = 55;
            this.dtmGioketthuc.Value = new System.DateTime(2023, 4, 21, 8, 7, 48, 665);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Trạng thái";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoluong.DefaultText = "";
            this.txtSoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoluong.ForeColor = System.Drawing.Color.Black;
            this.txtSoluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.Location = new System.Drawing.Point(160, 308);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.PasswordChar = '\0';
            this.txtSoluong.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSoluong.PlaceholderText = "";
            this.txtSoluong.SelectedText = "";
            this.txtSoluong.Size = new System.Drawing.Size(258, 48);
            this.txtSoluong.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ngày làm";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCT.DefaultText = "";
            this.txtMaCT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaCT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaCT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCT.Enabled = false;
            this.txtMaCT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaCT.ForeColor = System.Drawing.Color.Black;
            this.txtMaCT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCT.Location = new System.Drawing.Point(160, 19);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.PasswordChar = '\0';
            this.txtMaCT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMaCT.PlaceholderText = "";
            this.txtMaCT.SelectedText = "";
            this.txtMaCT.Size = new System.Drawing.Size(258, 48);
            this.txtMaCT.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Giờ kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Giờ bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã ca trực";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.dtgvCatruc);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(590, 95);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(567, 458);
            this.guna2GradientPanel2.TabIndex = 51;
            // 
            // dtgvCatruc
            // 
            this.dtgvCatruc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCatruc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maCT,
            this.ngayLam,
            this.gioBatDau,
            this.gioKetThuc,
            this.soLuong,
            this.trangThai});
            this.dtgvCatruc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCatruc.Location = new System.Drawing.Point(0, 0);
            this.dtgvCatruc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvCatruc.Name = "dtgvCatruc";
            this.dtgvCatruc.ReadOnly = true;
            this.dtgvCatruc.RowHeadersWidth = 51;
            this.dtgvCatruc.RowTemplate.Height = 24;
            this.dtgvCatruc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCatruc.Size = new System.Drawing.Size(567, 458);
            this.dtgvCatruc.TabIndex = 0;
            this.dtgvCatruc.SelectionChanged += new System.EventHandler(this.dtgvCatruc_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // maCT
            // 
            this.maCT.DataPropertyName = "maCT";
            this.maCT.HeaderText = "Mã ca trực";
            this.maCT.MinimumWidth = 6;
            this.maCT.Name = "maCT";
            this.maCT.ReadOnly = true;
            this.maCT.Width = 125;
            // 
            // ngayLam
            // 
            this.ngayLam.DataPropertyName = "ngayLam";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayLam.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayLam.HeaderText = "Ngày làm";
            this.ngayLam.MinimumWidth = 6;
            this.ngayLam.Name = "ngayLam";
            this.ngayLam.ReadOnly = true;
            this.ngayLam.Width = 125;
            // 
            // gioBatDau
            // 
            this.gioBatDau.DataPropertyName = "gioBatDau";
            this.gioBatDau.HeaderText = "Giờ bắt đầu";
            this.gioBatDau.MinimumWidth = 6;
            this.gioBatDau.Name = "gioBatDau";
            this.gioBatDau.ReadOnly = true;
            this.gioBatDau.Width = 125;
            // 
            // gioKetThuc
            // 
            this.gioKetThuc.DataPropertyName = "gioKetThuc";
            this.gioKetThuc.HeaderText = "Giờ kết thúc";
            this.gioKetThuc.MinimumWidth = 6;
            this.gioKetThuc.Name = "gioKetThuc";
            this.gioKetThuc.ReadOnly = true;
            this.gioKetThuc.Width = 125;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 125;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.trangThai.Width = 125;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.btnHuy);
            this.guna2GradientPanel1.Controls.Add(this.btnXoa);
            this.guna2GradientPanel1.Controls.Add(this.btnCapnhat);
            this.guna2GradientPanel1.Controls.Add(this.btnThem);
            this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(101, 560);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1020, 94);
            this.guna2GradientPanel1.TabIndex = 52;
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
            this.btnHuy.Location = new System.Drawing.Point(777, 19);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(190, 56);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextOffset = new System.Drawing.Point(20, 0);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(531, 19);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(190, 56);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextOffset = new System.Drawing.Point(10, 0);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnCapnhat.Location = new System.Drawing.Point(279, 19);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(190, 56);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextOffset = new System.Drawing.Point(20, 0);
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
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
            this.btnThem.Location = new System.Drawing.Point(28, 19);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(190, 56);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(10, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtmTimkiem
            // 
            this.dtmTimkiem.Checked = true;
            this.dtmTimkiem.CustomFormat = "dd/MM/yyyy";
            this.dtmTimkiem.FillColor = System.Drawing.Color.Silver;
            this.dtmTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmTimkiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmTimkiem.Location = new System.Drawing.Point(150, 15);
            this.dtmTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtmTimkiem.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmTimkiem.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmTimkiem.Name = "dtmTimkiem";
            this.dtmTimkiem.ShowUpDown = true;
            this.dtmTimkiem.Size = new System.Drawing.Size(314, 45);
            this.dtmTimkiem.TabIndex = 53;
            this.dtmTimkiem.Value = new System.DateTime(2023, 6, 7, 0, 0, 0, 0);
            // 
            // QuanLyCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 754);
            this.Controls.Add(this.dtmTimkiem);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnTimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyCaLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyCaTruc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyCaTruc_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatruc)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.DataGridView dtgvCatruc;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnCapnhat;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmNgaylam;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmGiobatdau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmGioketthuc;
        private System.Windows.Forms.ComboBox cbbTrangthai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmTimkiem;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn maCT;
        private DataGridViewTextBoxColumn ngayLam;
        private DataGridViewTextBoxColumn gioBatDau;
        private DataGridViewTextBoxColumn gioKetThuc;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewCheckBoxColumn trangThai;
    }
}