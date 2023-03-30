namespace PBL3.View
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
            this.grbThongTinHD = new System.Windows.Forms.GroupBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.btnXemChiTietHoaDon = new System.Windows.Forms.Button();
            this.grbThongTinHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinHD
            // 
            this.grbThongTinHD.Controls.Add(this.txtKhachHang);
            this.grbThongTinHD.Controls.Add(this.txtNhanVien);
            this.grbThongTinHD.Controls.Add(this.txtNgayLap);
            this.grbThongTinHD.Controls.Add(this.txtMaHD);
            this.grbThongTinHD.Controls.Add(this.lblKhachHang);
            this.grbThongTinHD.Controls.Add(this.lblNhanVien);
            this.grbThongTinHD.Controls.Add(this.lblNgayLap);
            this.grbThongTinHD.Controls.Add(this.lblMaHD);
            this.grbThongTinHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinHD.Location = new System.Drawing.Point(12, 38);
            this.grbThongTinHD.Name = "grbThongTinHD";
            this.grbThongTinHD.Size = new System.Drawing.Size(453, 370);
            this.grbThongTinHD.TabIndex = 0;
            this.grbThongTinHD.TabStop = false;
            this.grbThongTinHD.Text = "Thông tin hóa đơn";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(30, 59);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(97, 26);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã HD:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(30, 122);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(120, 26);
            this.lblNgayLap.TabIndex = 1;
            this.lblNgayLap.Text = "Ngày Lập:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(30, 189);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(128, 26);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Nhân Viên:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(30, 257);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(150, 26);
            this.lblKhachHang.TabIndex = 3;
            this.lblKhachHang.Text = "Khách Hàng:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(208, 59);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(223, 35);
            this.txtMaHD.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaHD,
            this.ColNgayLap,
            this.ColTongTien,
            this.ColTenNV,
            this.ColTenKH,
            this.ColTrangThai,
            this.ColGiamGia});
            this.dataGridView1.Location = new System.Drawing.Point(517, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 412);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColMaHD
            // 
            this.ColMaHD.HeaderText = "Mã Hóa Đơn";
            this.ColMaHD.MinimumWidth = 8;
            this.ColMaHD.Name = "ColMaHD";
            this.ColMaHD.Width = 150;
            // 
            // ColNgayLap
            // 
            this.ColNgayLap.HeaderText = "Ngày Lập";
            this.ColNgayLap.MinimumWidth = 8;
            this.ColNgayLap.Name = "ColNgayLap";
            this.ColNgayLap.Width = 150;
            // 
            // ColTongTien
            // 
            this.ColTongTien.HeaderText = "Tổng tiền";
            this.ColTongTien.MinimumWidth = 8;
            this.ColTongTien.Name = "ColTongTien";
            this.ColTongTien.Width = 150;
            // 
            // ColTenNV
            // 
            this.ColTenNV.HeaderText = "Tên Nhân Viên";
            this.ColTenNV.MinimumWidth = 8;
            this.ColTenNV.Name = "ColTenNV";
            this.ColTenNV.Width = 150;
            // 
            // ColTenKH
            // 
            this.ColTenKH.HeaderText = "Tên Khách Hàng";
            this.ColTenKH.MinimumWidth = 8;
            this.ColTenKH.Name = "ColTenKH";
            this.ColTenKH.Width = 150;
            // 
            // ColTrangThai
            // 
            this.ColTrangThai.HeaderText = "Trạng Thái";
            this.ColTrangThai.MinimumWidth = 8;
            this.ColTrangThai.Name = "ColTrangThai";
            this.ColTrangThai.Width = 150;
            // 
            // ColGiamGia
            // 
            this.ColGiamGia.HeaderText = "Giảm Giá";
            this.ColGiamGia.MinimumWidth = 8;
            this.ColGiamGia.Name = "ColGiamGia";
            this.ColGiamGia.Width = 150;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(47, 463);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(149, 62);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm Hóa Đơn";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(208, 122);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(223, 35);
            this.txtNgayLap.TabIndex = 7;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(208, 189);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(223, 35);
            this.txtNhanVien.TabIndex = 8;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(208, 254);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(223, 35);
            this.txtKhachHang.TabIndex = 9;
            // 
            // btnXemChiTietHoaDon
            // 
            this.btnXemChiTietHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietHoaDon.Location = new System.Drawing.Point(293, 462);
            this.btnXemChiTietHoaDon.Name = "btnXemChiTietHoaDon";
            this.btnXemChiTietHoaDon.Size = new System.Drawing.Size(172, 63);
            this.btnXemChiTietHoaDon.TabIndex = 3;
            this.btnXemChiTietHoaDon.Text = "Xem chi tiết Hóa Đơn";
            this.btnXemChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 673);
            this.Controls.Add(this.btnXemChiTietHoaDon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbThongTinHD);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.grbThongTinHD.ResumeLayout(false);
            this.grbThongTinHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinHD;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGiamGia;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXemChiTietHoaDon;
    }
}