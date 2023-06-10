namespace DoAnPBL3
{
    partial class ChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvChitiethoadon = new System.Windows.Forms.DataGridView();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.cbbMaHD = new System.Windows.Forms.ComboBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChitiethoadon)).BeginInit();
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
            this.btnTimkiem.Location = new System.Drawing.Point(566, 84);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(169, 45);
            this.btnTimkiem.TabIndex = 53;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dtgvChitiethoadon);
            this.guna2Panel2.Location = new System.Drawing.Point(121, 179);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(823, 258);
            this.guna2Panel2.TabIndex = 55;
            // 
            // dtgvChitiethoadon
            // 
            this.dtgvChitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChitiethoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maPV,
            this.tenMA,
            this.soLuong,
            this.giaMA,
            this.TT});
            this.dtgvChitiethoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChitiethoadon.Location = new System.Drawing.Point(0, 0);
            this.dtgvChitiethoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvChitiethoadon.Name = "dtgvChitiethoadon";
            this.dtgvChitiethoadon.ReadOnly = true;
            this.dtgvChitiethoadon.RowHeadersWidth = 62;
            this.dtgvChitiethoadon.RowTemplate.Height = 28;
            this.dtgvChitiethoadon.Size = new System.Drawing.Size(823, 258);
            this.dtgvChitiethoadon.TabIndex = 1;
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
            this.btnThoat.Location = new System.Drawing.Point(413, 457);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(169, 45);
            this.btnThoat.TabIndex = 56;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextOffset = new System.Drawing.Point(15, 0);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbMaHD
            // 
            this.cbbMaHD.FormattingEnabled = true;
            this.cbbMaHD.Location = new System.Drawing.Point(296, 96);
            this.cbbMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaHD.Name = "cbbMaHD";
            this.cbbMaHD.Size = new System.Drawing.Size(241, 24);
            this.cbbMaHD.TabIndex = 57;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
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
            this.giaMA.HeaderText = "Giá món ăn";
            this.giaMA.MinimumWidth = 8;
            this.giaMA.Name = "giaMA";
            this.giaMA.ReadOnly = true;
            this.giaMA.Width = 150;
            // 
            // TT
            // 
            this.TT.HeaderText = "Thành tiền";
            this.TT.MinimumWidth = 8;
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            this.TT.Width = 150;
            // 
            // ChiTietHoaDonAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.cbbMaHD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnTimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietHoaDonAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChiTietHoaDonAdmin_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChitiethoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView dtgvChitiethoadon;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private System.Windows.Forms.ComboBox cbbMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
    }
}