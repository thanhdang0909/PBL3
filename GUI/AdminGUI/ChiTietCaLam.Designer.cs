namespace DoAnPBL3.View
{
    partial class ChiTietCaLam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietCaLam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpkThangNam = new System.Windows.Forms.DateTimePicker();
            this.dtgvChiTiet = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpkThangNam
            // 
            this.dtpkThangNam.CustomFormat = "MM/yyyy";
            this.dtpkThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkThangNam.Location = new System.Drawing.Point(346, 46);
            this.dtpkThangNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkThangNam.Name = "dtpkThangNam";
            this.dtpkThangNam.ShowUpDown = true;
            this.dtpkThangNam.Size = new System.Drawing.Size(237, 26);
            this.dtpkThangNam.TabIndex = 1;
            // 
            // dtgvChiTiet
            // 
            this.dtgvChiTiet.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maCT,
            this.maTK,
            this.tenNV,
            this.ngayLam,
            this.gioBatDau,
            this.gioKetThuc});
            this.dtgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTiet.Location = new System.Drawing.Point(3, 21);
            this.dtgvChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvChiTiet.Name = "dtgvChiTiet";
            this.dtgvChiTiet.ReadOnly = true;
            this.dtgvChiTiet.RowHeadersWidth = 62;
            this.dtgvChiTiet.RowTemplate.Height = 28;
            this.dtgvChiTiet.Size = new System.Drawing.Size(1225, 535);
            this.dtgvChiTiet.TabIndex = 136;
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
            this.btnTimkiem.Location = new System.Drawing.Point(692, 30);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(190, 56);
            this.btnTimkiem.TabIndex = 137;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgvChiTiet);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1231, 558);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết ca làm của nhân viên";
            // 
            // btnThoat
            // 
            this.btnThoat.BorderRadius = 15;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThoat.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnThoat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThoat.Location = new System.Drawing.Point(921, 676);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 56);
            this.btnThoat.TabIndex = 139;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextOffset = new System.Drawing.Point(15, 0);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.maCT.HeaderText = "Mã ca làm";
            this.maCT.MinimumWidth = 8;
            this.maCT.Name = "maCT";
            this.maCT.ReadOnly = true;
            this.maCT.Width = 150;
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
            // ngayLam
            // 
            this.ngayLam.DataPropertyName = "ngayLam";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayLam.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayLam.HeaderText = "Ngày làm";
            this.ngayLam.MinimumWidth = 8;
            this.ngayLam.Name = "ngayLam";
            this.ngayLam.ReadOnly = true;
            this.ngayLam.Width = 150;
            // 
            // gioBatDau
            // 
            this.gioBatDau.DataPropertyName = "gioBatDau";
            this.gioBatDau.HeaderText = "Thời gian bắt đầu";
            this.gioBatDau.MinimumWidth = 8;
            this.gioBatDau.Name = "gioBatDau";
            this.gioBatDau.ReadOnly = true;
            this.gioBatDau.Width = 150;
            // 
            // gioKetThuc
            // 
            this.gioKetThuc.DataPropertyName = "gioKetThuc";
            this.gioKetThuc.HeaderText = "Thời gian kết thúc";
            this.gioKetThuc.MinimumWidth = 8;
            this.gioKetThuc.Name = "gioKetThuc";
            this.gioKetThuc.ReadOnly = true;
            this.gioKetThuc.Width = 150;
            // 
            // ChiTietCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 782);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dtpkThangNam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChiTietCaLam";
            this.Text = "ChiTietCaLam";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpkThangNam;
        private System.Windows.Forms.DataGridView dtgvChiTiet;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioKetThuc;
    }
}