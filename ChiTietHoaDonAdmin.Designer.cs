namespace PBL3.View
{
    partial class ChiTietHoaDonAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHoaDonAdmin));
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvChitiethoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimkiem.BorderRadius = 15;
            this.txtTimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiem.DefaultText = "";
            this.txtTimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.Location = new System.Drawing.Point(238, 94);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PasswordChar = '\0';
            this.txtTimkiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.Size = new System.Drawing.Size(368, 38);
            this.txtTimkiem.TabIndex = 54;
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
            this.btnTimkiem.Location = new System.Drawing.Point(651, 87);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(169, 45);
            this.btnTimkiem.TabIndex = 53;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvChitiethoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChitiethoadon.Location = new System.Drawing.Point(0, 0);
            this.dtgvChitiethoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvChitiethoadon.Name = "dtgvChitiethoadon";
            this.dtgvChitiethoadon.RowHeadersWidth = 62;
            this.dtgvChitiethoadon.RowTemplate.Height = 28;
            this.dtgvChitiethoadon.Size = new System.Drawing.Size(823, 258);
            this.dtgvChitiethoadon.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên món";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
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
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnTimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChitiethoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView dtgvChitiethoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
    }
}