namespace DoAnPBL3.View
{
    partial class ThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThucDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDSMA = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhMA = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMonNuong = new System.Windows.Forms.PictureBox();
            this.pbMonHap = new System.Windows.Forms.PictureBox();
            this.pbMonLau = new System.Windows.Forms.PictureBox();
            this.pbComMi = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbMonTM = new System.Windows.Forms.PictureBox();
            this.pbNuocUong = new System.Windows.Forms.PictureBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonNuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonHap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonLau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuocUong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDSMA);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(743, 764);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THỰC ĐƠN";
            // 
            // dtgvDSMA
            // 
            this.dtgvDSMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maMA,
            this.tenMA,
            this.donViTinh,
            this.tenLM,
            this.donGia,
            this.anhMA});
            this.dtgvDSMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSMA.Location = new System.Drawing.Point(3, 25);
            this.dtgvDSMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDSMA.Name = "dtgvDSMA";
            this.dtgvDSMA.ReadOnly = true;
            this.dtgvDSMA.RowHeadersWidth = 62;
            this.dtgvDSMA.RowTemplate.Height = 80;
            this.dtgvDSMA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSMA.Size = new System.Drawing.Size(737, 737);
            this.dtgvDSMA.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
            // 
            // maMA
            // 
            this.maMA.DataPropertyName = "maMA";
            this.maMA.HeaderText = "Mã món ăn";
            this.maMA.MinimumWidth = 8;
            this.maMA.Name = "maMA";
            this.maMA.ReadOnly = true;
            this.maMA.Width = 140;
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
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "donViTinh";
            this.donViTinh.HeaderText = "Đơn vị tính";
            this.donViTinh.MinimumWidth = 8;
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.ReadOnly = true;
            this.donViTinh.Width = 150;
            // 
            // tenLM
            // 
            this.tenLM.DataPropertyName = "maLM";
            this.tenLM.HeaderText = "Loại món";
            this.tenLM.MinimumWidth = 8;
            this.tenLM.Name = "tenLM";
            this.tenLM.ReadOnly = true;
            this.tenLM.Width = 150;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "giaMA";
            dataGridViewCellStyle1.Format = "#,### VNĐ";
            this.donGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 8;
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            this.donGia.Width = 150;
            // 
            // anhMA
            // 
            this.anhMA.DataPropertyName = "anhMA";
            this.anhMA.HeaderText = "Ảnh món ăn";
            this.anhMA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.anhMA.MinimumWidth = 8;
            this.anhMA.Name = "anhMA";
            this.anhMA.ReadOnly = true;
            this.anhMA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.anhMA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.anhMA.Width = 150;
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
            this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Location = new System.Drawing.Point(1096, 202);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(171, 41);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(171, 41);
            this.btnTimKiem.TabIndex = 49;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(926, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "DANH MỤC MÓN ĂN";
            // 
            // pbMonNuong
            // 
            this.pbMonNuong.Image = ((System.Drawing.Image)(resources.GetObject("pbMonNuong.Image")));
            this.pbMonNuong.Location = new System.Drawing.Point(783, 149);
            this.pbMonNuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMonNuong.Name = "pbMonNuong";
            this.pbMonNuong.Size = new System.Drawing.Size(234, 161);
            this.pbMonNuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonNuong.TabIndex = 51;
            this.pbMonNuong.TabStop = false;
            this.pbMonNuong.Click += new System.EventHandler(this.pbMonNuong_Click);
            // 
            // pbMonHap
            // 
            this.pbMonHap.Image = ((System.Drawing.Image)(resources.GetObject("pbMonHap.Image")));
            this.pbMonHap.Location = new System.Drawing.Point(1033, 149);
            this.pbMonHap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMonHap.Name = "pbMonHap";
            this.pbMonHap.Size = new System.Drawing.Size(234, 161);
            this.pbMonHap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonHap.TabIndex = 52;
            this.pbMonHap.TabStop = false;
            this.pbMonHap.Click += new System.EventHandler(this.pbMonHap_Click);
            // 
            // pbMonLau
            // 
            this.pbMonLau.Image = ((System.Drawing.Image)(resources.GetObject("pbMonLau.Image")));
            this.pbMonLau.Location = new System.Drawing.Point(783, 348);
            this.pbMonLau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMonLau.Name = "pbMonLau";
            this.pbMonLau.Size = new System.Drawing.Size(234, 161);
            this.pbMonLau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonLau.TabIndex = 53;
            this.pbMonLau.TabStop = false;
            this.pbMonLau.Click += new System.EventHandler(this.pbMonLau_Click);
            // 
            // pbComMi
            // 
            this.pbComMi.Image = ((System.Drawing.Image)(resources.GetObject("pbComMi.Image")));
            this.pbComMi.Location = new System.Drawing.Point(1033, 348);
            this.pbComMi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbComMi.Name = "pbComMi";
            this.pbComMi.Size = new System.Drawing.Size(234, 161);
            this.pbComMi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComMi.TabIndex = 54;
            this.pbComMi.TabStop = false;
            this.pbComMi.Click += new System.EventHandler(this.pbComMi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(847, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Món nướng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1114, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Món hấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(858, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "Món lẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1114, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Cơm, mì";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1077, 702);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 62;
            this.label6.Text = "Món tráng miệng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(847, 702);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 61;
            this.label7.Text = "Nước uống";
            // 
            // pbMonTM
            // 
            this.pbMonTM.Image = ((System.Drawing.Image)(resources.GetObject("pbMonTM.Image")));
            this.pbMonTM.Location = new System.Drawing.Point(1033, 538);
            this.pbMonTM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMonTM.Name = "pbMonTM";
            this.pbMonTM.Size = new System.Drawing.Size(234, 161);
            this.pbMonTM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonTM.TabIndex = 60;
            this.pbMonTM.TabStop = false;
            this.pbMonTM.Click += new System.EventHandler(this.pbMonTM_Click);
            // 
            // pbNuocUong
            // 
            this.pbNuocUong.Image = ((System.Drawing.Image)(resources.GetObject("pbNuocUong.Image")));
            this.pbNuocUong.Location = new System.Drawing.Point(783, 538);
            this.pbNuocUong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbNuocUong.Name = "pbNuocUong";
            this.pbNuocUong.Size = new System.Drawing.Size(234, 161);
            this.pbNuocUong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNuocUong.TabIndex = 59;
            this.pbNuocUong.TabStop = false;
            this.pbNuocUong.Click += new System.EventHandler(this.pbNuocUong_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Location = new System.Drawing.Point(801, 39);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTimKiem.MaximumSize = new System.Drawing.Size(320, 0);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(274, 28);
            this.cbbTimKiem.TabIndex = 63;
            // 
            // btnTK
            // 
            this.btnTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTK.BorderRadius = 15;
            this.btnTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTK.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTK.Location = new System.Drawing.Point(1097, 25);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.MaximumSize = new System.Drawing.Size(170, 52);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(170, 52);
            this.btnTK.TabIndex = 66;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // ThucDonNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 768);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbMonTM);
            this.Controls.Add(this.pbNuocUong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbComMi);
            this.Controls.Add(this.pbMonLau);
            this.Controls.Add(this.pbMonHap);
            this.Controls.Add(this.pbMonNuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThucDonNhanVien";
            this.Text = "ThucDon";
            this.Load += new System.EventHandler(this.ThucDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonNuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonHap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonLau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComMi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuocUong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDSMA;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMonNuong;
        private System.Windows.Forms.PictureBox pbMonHap;
        private System.Windows.Forms.PictureBox pbMonLau;
        private System.Windows.Forms.PictureBox pbComMi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbMonTM;
        private System.Windows.Forms.PictureBox pbNuocUong;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewImageColumn anhMA;
    }
}