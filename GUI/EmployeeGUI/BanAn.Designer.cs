namespace DoAnPBL3.View
{
    partial class BanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanAn));
            this.pnlBanAn = new System.Windows.Forms.Panel();
            this.btnCTBA = new Guna.UI2.WinForms.Guna2Button();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtSoGhe = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDSBA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBanAn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanAn
            // 
            this.pnlBanAn.Controls.Add(this.btnCTBA);
            this.pnlBanAn.Controls.Add(this.cbbTrangThai);
            this.pnlBanAn.Controls.Add(this.txtSoGhe);
            this.pnlBanAn.Controls.Add(this.groupBox2);
            this.pnlBanAn.Controls.Add(this.label1);
            this.pnlBanAn.Controls.Add(this.btnTimKiem);
            this.pnlBanAn.Controls.Add(this.label2);
            this.pnlBanAn.Controls.Add(this.label3);
            this.pnlBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBanAn.Location = new System.Drawing.Point(0, 0);
            this.pnlBanAn.Name = "pnlBanAn";
            this.pnlBanAn.Size = new System.Drawing.Size(856, 599);
            this.pnlBanAn.TabIndex = 0;
            // 
            // btnCTBA
            // 
            this.btnCTBA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCTBA.BorderRadius = 15;
            this.btnCTBA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCTBA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCTBA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCTBA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCTBA.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnCTBA.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCTBA.ForeColor = System.Drawing.Color.White;
            this.btnCTBA.Image = ((System.Drawing.Image)(resources.GetObject("btnCTBA.Image")));
            this.btnCTBA.ImageSize = new System.Drawing.Size(19, 19);
            this.btnCTBA.Location = new System.Drawing.Point(391, 515);
            this.btnCTBA.MaximumSize = new System.Drawing.Size(181, 44);
            this.btnCTBA.Name = "btnCTBA";
            this.btnCTBA.Size = new System.Drawing.Size(181, 44);
            this.btnCTBA.TabIndex = 60;
            this.btnCTBA.Text = "Đặt bàn";
            this.btnCTBA.Click += new System.EventHandler(this.btnCTBA_Click);
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(301, 56);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(177, 24);
            this.cbbTrangThai.TabIndex = 59;
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoGhe.DefaultText = "";
            this.txtSoGhe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoGhe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoGhe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoGhe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoGhe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoGhe.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGhe.ForeColor = System.Drawing.Color.Black;
            this.txtSoGhe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoGhe.Location = new System.Drawing.Point(605, 52);
            this.txtSoGhe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.PasswordChar = '\0';
            this.txtSoGhe.PlaceholderText = "";
            this.txtSoGhe.SelectedText = "";
            this.txtSoGhe.Size = new System.Drawing.Size(117, 32);
            this.txtSoGhe.TabIndex = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvDSBA);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(93, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 311);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bàn ăn";
            // 
            // dtgvDSBA
            // 
            this.dtgvDSBA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSBA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.maBan,
            this.soGhe,
            this.trangThai,
            this.ghiChu});
            this.dtgvDSBA.Location = new System.Drawing.Point(3, 22);
            this.dtgvDSBA.Name = "dtgvDSBA";
            this.dtgvDSBA.ReadOnly = true;
            this.dtgvDSBA.RowHeadersWidth = 62;
            this.dtgvDSBA.RowTemplate.Height = 28;
            this.dtgvDSBA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSBA.Size = new System.Drawing.Size(659, 289);
            this.dtgvDSBA.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // maBan
            // 
            this.maBan.DataPropertyName = "maBan";
            this.maBan.HeaderText = "Mã bàn";
            this.maBan.MinimumWidth = 8;
            this.maBan.Name = "maBan";
            this.maBan.ReadOnly = true;
            this.maBan.Width = 150;
            // 
            // soGhe
            // 
            this.soGhe.DataPropertyName = "soGhe";
            this.soGhe.HeaderText = "Số ghế";
            this.soGhe.MinimumWidth = 8;
            this.soGhe.Name = "soGhe";
            this.soGhe.ReadOnly = true;
            this.soGhe.Width = 150;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 8;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 150;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.MinimumWidth = 8;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            this.ghiChu.Width = 150;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(984, 61);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 48);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(54, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Thông tin bàn ăn";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTimKiem.Location = new System.Drawing.Point(640, 121);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(156, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(156, 44);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(184, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(515, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số ghế";
            // 
            // BanAnNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(856, 599);
            this.Controls.Add(this.pnlBanAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BanAnNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanAn";
            this.Load += new System.EventHandler(this.BanAn_Load);
            this.pnlBanAn.ResumeLayout(false);
            this.pnlBanAn.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDSBA;
        private System.Windows.Forms.Button btnThoat;
        private Guna.UI2.WinForms.Guna2TextBox txtSoGhe;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private Guna.UI2.WinForms.Guna2Button btnCTBA;
    }
}