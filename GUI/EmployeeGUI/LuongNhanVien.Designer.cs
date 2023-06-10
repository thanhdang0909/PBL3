namespace DoAnPBL3.GUI
{
    partial class LuongNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuongNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvLuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkThangLam = new System.Windows.Forms.DateTimePicker();
            this.btnThoatt = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.maTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTheoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLuong
            // 
            this.dtgvLuong.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTK,
            this.tenNV,
            this.thangLam,
            this.soGioLam,
            this.luongTheoGio,
            this.tongLuong});
            this.dtgvLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvLuong.Location = new System.Drawing.Point(0, 131);
            this.dtgvLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvLuong.Name = "dtgvLuong";
            this.dtgvLuong.ReadOnly = true;
            this.dtgvLuong.RowHeadersWidth = 62;
            this.dtgvLuong.RowTemplate.Height = 28;
            this.dtgvLuong.Size = new System.Drawing.Size(847, 480);
            this.dtgvLuong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền lương theo tháng";
            // 
            // dtpkThangLam
            // 
            this.dtpkThangLam.CustomFormat = "MM/yyyy";
            this.dtpkThangLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkThangLam.Location = new System.Drawing.Point(166, 69);
            this.dtpkThangLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkThangLam.Name = "dtpkThangLam";
            this.dtpkThangLam.ShowUpDown = true;
            this.dtpkThangLam.Size = new System.Drawing.Size(237, 26);
            this.dtpkThangLam.TabIndex = 138;
            // 
            // btnThoatt
            // 
            this.btnThoatt.BorderRadius = 15;
            this.btnThoatt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoatt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoatt.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnThoatt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatt.ForeColor = System.Drawing.Color.White;
            this.btnThoatt.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatt.Image")));
            this.btnThoatt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThoatt.ImageSize = new System.Drawing.Size(37, 37);
            this.btnThoatt.Location = new System.Drawing.Point(629, 52);
            this.btnThoatt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatt.Name = "btnThoatt";
            this.btnThoatt.Size = new System.Drawing.Size(156, 61);
            this.btnThoatt.TabIndex = 140;
            this.btnThoatt.Text = "Thoát";
            this.btnThoatt.TextOffset = new System.Drawing.Point(8, 0);
            this.btnThoatt.Click += new System.EventHandler(this.btnThoatt_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(444, 52);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 61);
            this.btnTimKiem.TabIndex = 141;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimkiem_Click);
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
            // thangLam
            // 
            this.thangLam.DataPropertyName = "thangLam";
            this.thangLam.HeaderText = "Tháng làm";
            this.thangLam.MinimumWidth = 8;
            this.thangLam.Name = "thangLam";
            this.thangLam.ReadOnly = true;
            this.thangLam.Width = 150;
            // 
            // soGioLam
            // 
            this.soGioLam.DataPropertyName = "soGioLam";
            this.soGioLam.HeaderText = "Số giờ làm";
            this.soGioLam.MinimumWidth = 8;
            this.soGioLam.Name = "soGioLam";
            this.soGioLam.ReadOnly = true;
            this.soGioLam.Width = 150;
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
            // tongLuong
            // 
            this.tongLuong.DataPropertyName = "tongLuong";
            dataGridViewCellStyle2.Format = "#,### VNĐ";
            this.tongLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.tongLuong.HeaderText = "Tổng lương";
            this.tongLuong.MinimumWidth = 8;
            this.tongLuong.Name = "tongLuong";
            this.tongLuong.ReadOnly = true;
            this.tongLuong.Width = 150;
            // 
            // XemLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 611);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoatt);
            this.Controls.Add(this.dtpkThangLam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XemLuongNhanVien";
            this.Text = "XemLuong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkThangLam;
        private Guna.UI2.WinForms.Guna2Button btnThoatt;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTheoGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongLuong;
    }
}