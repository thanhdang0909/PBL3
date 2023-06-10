namespace DoAnPBL3.View
{
    partial class CaLamViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaLamViec));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCalamviec = new System.Windows.Forms.Panel();
            this.btnLuong = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvCalamviec = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtmNgaylam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCalamviec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCalamviec)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCalamviec
            // 
            this.pnlCalamviec.Controls.Add(this.btnLuong);
            this.pnlCalamviec.Controls.Add(this.btnTimkiem);
            this.pnlCalamviec.Controls.Add(this.dtgvCalamviec);
            this.pnlCalamviec.Controls.Add(this.dtmNgaylam);
            this.pnlCalamviec.Controls.Add(this.btDangKy);
            this.pnlCalamviec.Controls.Add(this.label1);
            this.pnlCalamviec.Controls.Add(this.label2);
            this.pnlCalamviec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalamviec.Location = new System.Drawing.Point(0, 0);
            this.pnlCalamviec.Name = "pnlCalamviec";
            this.pnlCalamviec.Size = new System.Drawing.Size(847, 611);
            this.pnlCalamviec.TabIndex = 0;
            // 
            // btnLuong
            // 
            this.btnLuong.BorderRadius = 15;
            this.btnLuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuong.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnLuong.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLuong.ForeColor = System.Drawing.Color.White;
            this.btnLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnLuong.Image")));
            this.btnLuong.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLuong.Location = new System.Drawing.Point(360, 168);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(197, 51);
            this.btnLuong.TabIndex = 81;
            this.btnLuong.Text = "Xem lương";
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BorderRadius = 15;
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimkiem.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnTimkiem.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTimkiem.Location = new System.Drawing.Point(540, 72);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(169, 45);
            this.btnTimkiem.TabIndex = 80;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click_1);
            // 
            // dtgvCalamviec
            // 
            this.dtgvCalamviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCalamviec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maCT,
            this.ngayLam,
            this.gioBatDau,
            this.gioKetThuc,
            this.trangThai,
            this.soLuong});
            this.dtgvCalamviec.Location = new System.Drawing.Point(3, 268);
            this.dtgvCalamviec.Name = "dtgvCalamviec";
            this.dtgvCalamviec.ReadOnly = true;
            this.dtgvCalamviec.RowHeadersWidth = 62;
            this.dtgvCalamviec.RowTemplate.Height = 28;
            this.dtgvCalamviec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCalamviec.Size = new System.Drawing.Size(841, 331);
            this.dtgvCalamviec.TabIndex = 79;
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
            this.gioBatDau.HeaderText = "Giờ bắt đầu";
            this.gioBatDau.MinimumWidth = 8;
            this.gioBatDau.Name = "gioBatDau";
            this.gioBatDau.ReadOnly = true;
            this.gioBatDau.Width = 150;
            // 
            // gioKetThuc
            // 
            this.gioKetThuc.DataPropertyName = "gioKetThuc";
            this.gioKetThuc.HeaderText = "Giờ kết thúc";
            this.gioKetThuc.MinimumWidth = 8;
            this.gioKetThuc.Name = "gioKetThuc";
            this.gioKetThuc.ReadOnly = true;
            this.gioKetThuc.Width = 150;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 8;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.trangThai.Width = 150;
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
            // dtmNgaylam
            // 
            this.dtmNgaylam.Checked = true;
            this.dtmNgaylam.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaylam.FillColor = System.Drawing.Color.Silver;
            this.dtmNgaylam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmNgaylam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaylam.Location = new System.Drawing.Point(237, 72);
            this.dtmNgaylam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmNgaylam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmNgaylam.Name = "dtmNgaylam";
            this.dtmNgaylam.ShowUpDown = true;
            this.dtmNgaylam.Size = new System.Drawing.Size(264, 44);
            this.dtmNgaylam.TabIndex = 78;
            this.dtmNgaylam.Value = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            // 
            // btDangKy
            // 
            this.btDangKy.BorderRadius = 15;
            this.btDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDangKy.FillColor = System.Drawing.Color.DarkSalmon;
            this.btDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangKy.ForeColor = System.Drawing.Color.White;
            this.btDangKy.Image = ((System.Drawing.Image)(resources.GetObject("btDangKy.Image")));
            this.btDangKy.ImageSize = new System.Drawing.Size(25, 25);
            this.btDangKy.Location = new System.Drawing.Point(573, 168);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(251, 51);
            this.btDangKy.TabIndex = 76;
            this.btDangKy.Text = "Đăng ký ca làm";
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 75;
            this.label1.Text = "Thông tin ca làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 73;
            this.label2.Text = "Ngày làm";
            // 
            // CaLamViec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(847, 611);
            this.Controls.Add(this.pnlCalamviec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaLamViec";
            this.Load += new System.EventHandler(this.CaLamViec_Load_1);
            this.pnlCalamviec.ResumeLayout(false);
            this.pnlCalamviec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCalamviec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCalamviec;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmNgaylam;
        private Guna.UI2.WinForms.Guna2Button btDangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvCalamviec;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioKetThuc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private Guna.UI2.WinForms.Guna2Button btnLuong;
    }
}