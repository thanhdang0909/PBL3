namespace DoAnPBL3
{
    partial class ThongKeKhachHang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeKhachHang));
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.ChartKH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkStart = new System.Windows.Forms.DateTimePicker();
            this.dtpkEnd = new System.Windows.Forms.DateTimePicker();
            this.cbbTKBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.ngayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThongke = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBieuDo
            // 
            this.pnlBieuDo.Controls.Add(this.ChartKH);
            this.pnlBieuDo.Location = new System.Drawing.Point(2, 198);
            this.pnlBieuDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.Size = new System.Drawing.Size(1092, 396);
            this.pnlBieuDo.TabIndex = 0;
            // 
            // ChartKH
            // 
            this.ChartKH.BackColor = System.Drawing.Color.Gainsboro;
            this.ChartKH.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.ChartKH.ChartAreas.Add(chartArea1);
            this.ChartKH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.ChartKH.Legends.Add(legend1);
            this.ChartKH.Location = new System.Drawing.Point(0, 0);
            this.ChartKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartKH.Name = "ChartKH";
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Orange;
            series1.Legend = "Legend1";
            series1.Name = "Số lượng khách";
            this.ChartKH.Series.Add(series1);
            this.ChartKH.Size = new System.Drawing.Size(1092, 396);
            this.ChartKH.TabIndex = 0;
            this.ChartKH.Text = "Biểu đồ khách hàng";
            title1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Orange;
            title1.Name = "Title1";
            title1.Text = "Thống kê khách hàng";
            this.ChartKH.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến";
            // 
            // dtpkStart
            // 
            this.dtpkStart.CustomFormat = "dd/MM/yyyy";
            this.dtpkStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkStart.Location = new System.Drawing.Point(101, 22);
            this.dtpkStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkStart.Name = "dtpkStart";
            this.dtpkStart.ShowUpDown = true;
            this.dtpkStart.Size = new System.Drawing.Size(250, 22);
            this.dtpkStart.TabIndex = 2;
            // 
            // dtpkEnd
            // 
            this.dtpkEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpkEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkEnd.Location = new System.Drawing.Point(101, 57);
            this.dtpkEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkEnd.Name = "dtpkEnd";
            this.dtpkEnd.ShowUpDown = true;
            this.dtpkEnd.Size = new System.Drawing.Size(250, 22);
            this.dtpkEnd.TabIndex = 3;
            // 
            // cbbTKBy
            // 
            this.cbbTKBy.FormattingEnabled = true;
            this.cbbTKBy.Location = new System.Drawing.Point(101, 93);
            this.cbbTKBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTKBy.Name = "cbbTKBy";
            this.cbbTKBy.Size = new System.Drawing.Size(250, 24);
            this.cbbTKBy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thống kê ";
            // 
            // dtgvData
            // 
            this.dtgvData.BackgroundColor = System.Drawing.Color.Linen;
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayDen,
            this.tongSoNguoi});
            this.dtgvData.GridColor = System.Drawing.Color.PeachPuff;
            this.dtgvData.Location = new System.Drawing.Point(503, 10);
            this.dtgvData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.RowHeadersWidth = 62;
            this.dtgvData.RowTemplate.Height = 28;
            this.dtgvData.Size = new System.Drawing.Size(580, 175);
            this.dtgvData.TabIndex = 6;
            // 
            // ngayDen
            // 
            this.ngayDen.DataPropertyName = "ngayden";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.ngayDen.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayDen.HeaderText = "Thời gian đến";
            this.ngayDen.MinimumWidth = 8;
            this.ngayDen.Name = "ngayDen";
            this.ngayDen.Width = 150;
            // 
            // tongSoNguoi
            // 
            this.tongSoNguoi.DataPropertyName = "Tongsonguoi";
            this.tongSoNguoi.HeaderText = "Tổng số người";
            this.tongSoNguoi.MinimumWidth = 8;
            this.tongSoNguoi.Name = "tongSoNguoi";
            this.tongSoNguoi.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(418, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "DỮ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(418, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "LIỆU";
            // 
            // btnThongke
            // 
            this.btnThongke.BorderRadius = 15;
            this.btnThongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongke.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnThongke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.Black;
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongke.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnThongke.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThongke.Location = new System.Drawing.Point(150, 132);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(169, 45);
            this.btnThongke.TabIndex = 82;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextOffset = new System.Drawing.Point(15, 0);
            this.btnThongke.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // ThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbTKBy);
            this.Controls.Add(this.dtpkEnd);
            this.Controls.Add(this.dtpkStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBieuDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeKhachHang";
            this.pnlBieuDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkStart;
        private System.Windows.Forms.DateTimePicker dtpkEnd;
        private System.Windows.Forms.ComboBox cbbTKBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoNguoi;
        private Guna.UI2.WinForms.Guna2Button btnThongke;
    }
}