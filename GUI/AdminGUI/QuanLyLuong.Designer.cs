namespace DoAnPBL3.View
{
    partial class QuanLyLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyLuong));
            this.pnlLuong = new System.Windows.Forms.Panel();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvLuongNV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGioLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTheoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTinhLuong = new Guna.UI2.WinForms.Guna2Button();
            this.btnHienThi = new Guna.UI2.WinForms.Guna2Button();
            this.dtpkngayLuong = new System.Windows.Forms.DateTimePicker();
            this.btnChiTiet = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLuong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuongNV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLuong
            // 
            this.pnlLuong.Controls.Add(this.cbbNV);
            this.pnlLuong.Controls.Add(this.groupBox1);
            this.pnlLuong.Controls.Add(this.btnTinhLuong);
            this.pnlLuong.Controls.Add(this.btnHienThi);
            this.pnlLuong.Controls.Add(this.dtpkngayLuong);
            this.pnlLuong.Controls.Add(this.btnChiTiet);
            this.pnlLuong.Controls.Add(this.label1);
            this.pnlLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLuong.Location = new System.Drawing.Point(0, 0);
            this.pnlLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLuong.Name = "pnlLuong";
            this.pnlLuong.Size = new System.Drawing.Size(1093, 603);
            this.pnlLuong.TabIndex = 0;
            // 
            // cbbNV
            // 
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(541, 73);
            this.cbbNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(168, 24);
            this.cbbNV.TabIndex = 154;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgvLuongNV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1072, 466);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lương của nhân viên";
            // 
            // dtgvLuongNV
            // 
            this.dtgvLuongNV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvLuongNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLuongNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maTK,
            this.tenNV,
            this.tongGioLam,
            this.luongTheoGio,
            this.tienLuong});
            this.dtgvLuongNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvLuongNV.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgvLuongNV.Location = new System.Drawing.Point(3, 22);
            this.dtgvLuongNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvLuongNV.Name = "dtgvLuongNV";
            this.dtgvLuongNV.ReadOnly = true;
            this.dtgvLuongNV.RowHeadersWidth = 62;
            this.dtgvLuongNV.RowTemplate.Height = 28;
            this.dtgvLuongNV.Size = new System.Drawing.Size(1066, 442);
            this.dtgvLuongNV.TabIndex = 148;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
            // 
            // maTK
            // 
            this.maTK.DataPropertyName = "maTK";
            this.maTK.HeaderText = "Mã tài khoản";
            this.maTK.MinimumWidth = 8;
            this.maTK.Name = "maTK";
            this.maTK.ReadOnly = true;
            this.maTK.Width = 150;
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.HeaderText = "Tên nhân viên";
            this.tenNV.MinimumWidth = 8;
            this.tenNV.Name = "tenNV";
            this.tenNV.ReadOnly = true;
            this.tenNV.Width = 150;
            // 
            // tongGioLam
            // 
            this.tongGioLam.DataPropertyName = "soGioLam";
            this.tongGioLam.HeaderText = "Tổng giờ làm";
            this.tongGioLam.MinimumWidth = 8;
            this.tongGioLam.Name = "tongGioLam";
            this.tongGioLam.ReadOnly = true;
            this.tongGioLam.Width = 150;
            // 
            // luongTheoGio
            // 
            this.luongTheoGio.DataPropertyName = "luongTheoGio";
            dataGridViewCellStyle1.Format = "#,### VNĐ";
            this.luongTheoGio.DefaultCellStyle = dataGridViewCellStyle1;
            this.luongTheoGio.HeaderText = "Lương theo giờ";
            this.luongTheoGio.MinimumWidth = 8;
            this.luongTheoGio.Name = "luongTheoGio";
            this.luongTheoGio.ReadOnly = true;
            this.luongTheoGio.Width = 150;
            // 
            // tienLuong
            // 
            dataGridViewCellStyle2.Format = "#,### VNĐ";
            this.tienLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.tienLuong.HeaderText = "Tổng tiền lương";
            this.tienLuong.MinimumWidth = 8;
            this.tienLuong.Name = "tienLuong";
            this.tienLuong.ReadOnly = true;
            this.tienLuong.Width = 150;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BorderRadius = 15;
            this.btnTinhLuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhLuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTinhLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTinhLuong.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTinhLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnTinhLuong.ForeColor = System.Drawing.Color.Black;
            this.btnTinhLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.Image")));
            this.btnTinhLuong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTinhLuong.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnTinhLuong.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTinhLuong.Location = new System.Drawing.Point(261, 57);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(169, 45);
            this.btnTinhLuong.TabIndex = 147;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.TextOffset = new System.Drawing.Point(20, 0);
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BorderRadius = 15;
            this.btnHienThi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienThi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienThi.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnHienThi.ForeColor = System.Drawing.Color.Black;
            this.btnHienThi.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThi.Image")));
            this.btnHienThi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHienThi.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnHienThi.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHienThi.Location = new System.Drawing.Point(731, 63);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(169, 45);
            this.btnHienThi.TabIndex = 152;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.TextOffset = new System.Drawing.Point(20, 0);
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dtpkngayLuong
            // 
            this.dtpkngayLuong.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpkngayLuong.CustomFormat = "MM/yyyy";
            this.dtpkngayLuong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkngayLuong.Location = new System.Drawing.Point(47, 71);
            this.dtpkngayLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkngayLuong.Name = "dtpkngayLuong";
            this.dtpkngayLuong.ShowUpDown = true;
            this.dtpkngayLuong.Size = new System.Drawing.Size(191, 22);
            this.dtpkngayLuong.TabIndex = 151;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BorderRadius = 15;
            this.btnChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTiet.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChiTiet.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnChiTiet.ImageSize = new System.Drawing.Size(25, 25);
            this.btnChiTiet.Location = new System.Drawing.Point(919, 63);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(161, 45);
            this.btnChiTiet.TabIndex = 150;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.TextOffset = new System.Drawing.Point(20, 0);
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 149;
            this.label1.Text = "Lương theo tháng";
            // 
            // QuanLyLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.pnlLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyLuong";
            this.Text = "QuanLyLuong";
            this.Load += new System.EventHandler(this.QuanLyLuong_Load);
            this.pnlLuong.ResumeLayout(false);
            this.pnlLuong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuongNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLuong;
        private System.Windows.Forms.DataGridView dtgvLuongNV;
        private Guna.UI2.WinForms.Guna2Button btnTinhLuong;
        private Guna.UI2.WinForms.Guna2Button btnHienThi;
        private System.Windows.Forms.DateTimePicker dtpkngayLuong;
        private Guna.UI2.WinForms.Guna2Button btnChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGioLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTheoGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienLuong;
    }
}