namespace DoAnPBL3
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.pnlHoadon = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHD = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnXemCTHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHoadon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHoadon
            // 
            this.pnlHoadon.Controls.Add(this.groupBox1);
            this.pnlHoadon.Controls.Add(this.cbbTenNV);
            this.pnlHoadon.Controls.Add(this.guna2GradientPanel1);
            this.pnlHoadon.Controls.Add(this.btnTimkiem);
            this.pnlHoadon.Location = new System.Drawing.Point(0, 0);
            this.pnlHoadon.Name = "pnlHoadon";
            this.pnlHoadon.Size = new System.Drawing.Size(1094, 603);
            this.pnlHoadon.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDSHD);
            this.groupBox1.Location = new System.Drawing.Point(56, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(983, 272);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dtgvDSHD
            // 
            this.dtgvDSHD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.tenNV,
            this.maKH,
            this.tenKH,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dtgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSHD.Location = new System.Drawing.Point(3, 17);
            this.dtgvDSHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDSHD.Name = "dtgvDSHD";
            this.dtgvDSHD.ReadOnly = true;
            this.dtgvDSHD.RowHeadersWidth = 62;
            this.dtgvDSHD.RowTemplate.Height = 28;
            this.dtgvDSHD.Size = new System.Drawing.Size(977, 253);
            this.dtgvDSHD.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maHD";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maTK";
            this.Column2.HeaderText = "Mã tài khoản";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
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
            // Column3
            // 
            this.Column3.DataPropertyName = "maPV";
            this.Column3.HeaderText = "Mã phục vụ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngayThanhToan";
            this.Column5.HeaderText = "Ngày thanh toán";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tongTien";
            dataGridViewCellStyle1.Format = "#,### VNĐ";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(323, 60);
            this.cbbTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(244, 24);
            this.cbbTenNV.TabIndex = 62;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.btnXemCTHD);
            this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(56, 446);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(983, 75);
            this.guna2GradientPanel1.TabIndex = 61;
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.BorderRadius = 15;
            this.btnXemCTHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCTHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCTHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemCTHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemCTHD.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnXemCTHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCTHD.ForeColor = System.Drawing.Color.Black;
            this.btnXemCTHD.Image = ((System.Drawing.Image)(resources.GetObject("btnXemCTHD.Image")));
            this.btnXemCTHD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXemCTHD.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnXemCTHD.ImageSize = new System.Drawing.Size(25, 25);
            this.btnXemCTHD.Location = new System.Drawing.Point(355, 15);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(263, 45);
            this.btnXemCTHD.TabIndex = 54;
            this.btnXemCTHD.Text = "Xem chi tiết hóa đơn";
            this.btnXemCTHD.TextOffset = new System.Drawing.Point(25, 0);
            this.btnXemCTHD.Click += new System.EventHandler(this.btnXemchitiethoadon_Click);
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
            this.btnTimkiem.Location = new System.Drawing.Point(599, 50);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(169, 45);
            this.btnTimkiem.TabIndex = 58;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // HoaDonAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.pnlHoadon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDonAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HoaDonAdmin_Load);
            this.pnlHoadon.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHoadon;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnXemCTHD;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDSHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}