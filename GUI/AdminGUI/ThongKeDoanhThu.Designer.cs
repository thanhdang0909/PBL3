namespace DoAnPBL3
{
    partial class ThongKeDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDoanhThu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnThongke = new Guna.UI2.WinForms.Guna2Button();
            this.dtmStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmEndDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chartDoanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMonandadat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartThucdon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblKhachhang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDoanhthu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbNgaythongke = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThucdon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongke
            // 
            this.btnThongke.BorderRadius = 15;
            this.btnThongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongke.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnThongke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongke.ForeColor = System.Drawing.Color.Black;
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongke.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnThongke.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThongke.Location = new System.Drawing.Point(752, 34);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(169, 45);
            this.btnThongke.TabIndex = 81;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextOffset = new System.Drawing.Point(15, 0);
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // dtmStartDate
            // 
            this.dtmStartDate.Checked = true;
            this.dtmStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtmStartDate.FillColor = System.Drawing.Color.LightGray;
            this.dtmStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmStartDate.Location = new System.Drawing.Point(104, 10);
            this.dtmStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmStartDate.Name = "dtmStartDate";
            this.dtmStartDate.ShowUpDown = true;
            this.dtmStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtmStartDate.TabIndex = 82;
            this.dtmStartDate.Value = new System.DateTime(2023, 5, 11, 22, 44, 36, 251);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 83;
            this.label1.Text = "Từ";
            // 
            // dtmEndDay
            // 
            this.dtmEndDay.Checked = true;
            this.dtmEndDay.CustomFormat = "dd/MM/yyyy";
            this.dtmEndDay.FillColor = System.Drawing.Color.LightGray;
            this.dtmEndDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmEndDay.Location = new System.Drawing.Point(104, 65);
            this.dtmEndDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmEndDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmEndDay.Name = "dtmEndDay";
            this.dtmEndDay.ShowUpDown = true;
            this.dtmEndDay.Size = new System.Drawing.Size(200, 36);
            this.dtmEndDay.TabIndex = 84;
            this.dtmEndDay.Value = new System.DateTime(2023, 5, 11, 22, 44, 36, 251);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 85;
            this.label2.Text = "Đến";
            // 
            // chartDoanhthu
            // 
            this.chartDoanhthu.BackColor = System.Drawing.Color.Silver;
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chartDoanhthu.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartDoanhthu.Legends.Add(legend1);
            this.chartDoanhthu.Location = new System.Drawing.Point(2, 228);
            this.chartDoanhthu.Name = "chartDoanhthu";
            this.chartDoanhthu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chartDoanhthu.Series.Add(series1);
            this.chartDoanhthu.Size = new System.Drawing.Size(639, 371);
            this.chartDoanhthu.TabIndex = 86;
            this.chartDoanhthu.Text = "chartDoanhthu";
            title1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Doanh Thu";
            this.chartDoanhthu.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMonandadat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(5, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 85);
            this.panel1.TabIndex = 87;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // lblMonandadat
            // 
            this.lblMonandadat.AutoSize = true;
            this.lblMonandadat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonandadat.Location = new System.Drawing.Point(84, 41);
            this.lblMonandadat.Name = "lblMonandadat";
            this.lblMonandadat.Size = new System.Drawing.Size(50, 23);
            this.lblMonandadat.TabIndex = 89;
            this.lblMonandadat.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 23);
            this.label3.TabIndex = 88;
            this.label3.Text = "Tổng số lượng món ăn đã đặt";
            // 
            // chartThucdon
            // 
            this.chartThucdon.BackColor = System.Drawing.Color.Silver;
            chartArea2.BackColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.chartThucdon.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Silver;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartThucdon.Legends.Add(legend2);
            this.chartThucdon.Location = new System.Drawing.Point(647, 228);
            this.chartThucdon.Name = "chartThucdon";
            this.chartThucdon.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BorderColor = System.Drawing.Color.Gainsboro;
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.Silver;
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ShadowColor = System.Drawing.Color.Silver;
            this.chartThucdon.Series.Add(series2);
            this.chartThucdon.Size = new System.Drawing.Size(443, 371);
            this.chartThucdon.TabIndex = 88;
            this.chartThucdon.Text = "chart1";
            title2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Top 5 món ăn được đặt nhiều nhất";
            this.chartThucdon.Titles.Add(title2);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblKhachhang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(739, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 85);
            this.panel2.TabIndex = 89;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            // 
            // lblKhachhang
            // 
            this.lblKhachhang.AutoSize = true;
            this.lblKhachhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachhang.Location = new System.Drawing.Point(89, 40);
            this.lblKhachhang.Name = "lblKhachhang";
            this.lblKhachhang.Size = new System.Drawing.Size(50, 23);
            this.lblKhachhang.TabIndex = 90;
            this.lblKhachhang.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 88;
            this.label4.Text = "Số lượng khách hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lblDoanhthu);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(445, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 85);
            this.panel3.TabIndex = 90;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // lblDoanhthu
            // 
            this.lblDoanhthu.AutoSize = true;
            this.lblDoanhthu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhthu.Location = new System.Drawing.Point(86, 39);
            this.lblDoanhthu.Name = "lblDoanhthu";
            this.lblDoanhthu.Size = new System.Drawing.Size(50, 23);
            this.lblDoanhthu.TabIndex = 89;
            this.lblDoanhthu.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 88;
            this.label8.Text = "Tổng doanh thu";
            // 
            // cbbNgaythongke
            // 
            this.cbbNgaythongke.FormattingEnabled = true;
            this.cbbNgaythongke.Location = new System.Drawing.Point(466, 44);
            this.cbbNgaythongke.Name = "cbbNgaythongke";
            this.cbbNgaythongke.Size = new System.Drawing.Size(204, 24);
            this.cbbNgaythongke.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 92;
            this.label5.Text = "Thống kê";
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbNgaythongke);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartThucdon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartDoanhthu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtmEndDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmStartDate);
            this.Controls.Add(this.btnThongke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThucdon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Guna.UI2.WinForms.Guna2Button btnThongke;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmStartDate;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmEndDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhthu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMonandadat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThucdon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblKhachhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDoanhthu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbbNgaythongke;
        private System.Windows.Forms.Label label5;

        #endregion
        // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}