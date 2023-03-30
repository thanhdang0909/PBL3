namespace PBL.View
{
    partial class MonAn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_LMA = new System.Windows.Forms.ComboBox();
            this.txt_tenMA = new System.Windows.Forms.TextBox();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.bt_TK = new System.Windows.Forms.Button();
            this.dtgv_DSMA = new System.Windows.Forms.DataGridView();
            this.maLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Thoat);
            this.groupBox1.Controls.Add(this.bt_Huy);
            this.groupBox1.Controls.Add(this.bt_TK);
            this.groupBox1.Controls.Add(this.txt_tenMA);
            this.groupBox1.Controls.Add(this.cb_LMA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_DSMA);
            this.groupBox2.Location = new System.Drawing.Point(452, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 443);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại món ăn: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món ăn:";
            // 
            // cb_LMA
            // 
            this.cb_LMA.FormattingEnabled = true;
            this.cb_LMA.Location = new System.Drawing.Point(140, 51);
            this.cb_LMA.Name = "cb_LMA";
            this.cb_LMA.Size = new System.Drawing.Size(228, 28);
            this.cb_LMA.TabIndex = 4;
            // 
            // txt_tenMA
            // 
            this.txt_tenMA.Location = new System.Drawing.Point(140, 109);
            this.txt_tenMA.Name = "txt_tenMA";
            this.txt_tenMA.Size = new System.Drawing.Size(228, 26);
            this.txt_tenMA.TabIndex = 6;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(298, 365);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(96, 48);
            this.bt_Thoat.TabIndex = 9;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Location = new System.Drawing.Point(165, 365);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(96, 48);
            this.bt_Huy.TabIndex = 8;
            this.bt_Huy.Text = "Huỷ";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_TK
            // 
            this.bt_TK.Location = new System.Drawing.Point(31, 365);
            this.bt_TK.Name = "bt_TK";
            this.bt_TK.Size = new System.Drawing.Size(96, 48);
            this.bt_TK.TabIndex = 7;
            this.bt_TK.Text = "Tìm kiếm";
            this.bt_TK.UseVisualStyleBackColor = true;
            // 
            // dtgv_DSMA
            // 
            this.dtgv_DSMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLM,
            this.tenMA,
            this.loaiMA,
            this.donViTinh,
            this.donGia});
            this.dtgv_DSMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_DSMA.Location = new System.Drawing.Point(3, 22);
            this.dtgv_DSMA.Name = "dtgv_DSMA";
            this.dtgv_DSMA.RowHeadersWidth = 62;
            this.dtgv_DSMA.RowTemplate.Height = 28;
            this.dtgv_DSMA.Size = new System.Drawing.Size(725, 418);
            this.dtgv_DSMA.TabIndex = 0;
            // 
            // maLM
            // 
            this.maLM.HeaderText = "Mã món ăn";
            this.maLM.MinimumWidth = 8;
            this.maLM.Name = "maLM";
            this.maLM.Width = 150;
            // 
            // tenMA
            // 
            this.tenMA.HeaderText = "Tên món ăn";
            this.tenMA.MinimumWidth = 8;
            this.tenMA.Name = "tenMA";
            this.tenMA.Width = 150;
            // 
            // loaiMA
            // 
            this.loaiMA.HeaderText = "LoạiMA";
            this.loaiMA.MinimumWidth = 8;
            this.loaiMA.Name = "loaiMA";
            this.loaiMA.Width = 150;
            // 
            // donViTinh
            // 
            this.donViTinh.HeaderText = "Đơn vị tính";
            this.donViTinh.MinimumWidth = 8;
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.Width = 150;
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 8;
            this.donGia.Name = "donGia";
            this.donGia.Width = 150;
            // 
            // MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MonAn";
            this.Text = "MonAn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tenMA;
        private System.Windows.Forms.ComboBox cb_LMA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_TK;
        private System.Windows.Forms.DataGridView dtgv_DSMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
    }
}