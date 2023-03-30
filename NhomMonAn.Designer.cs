namespace PBL.View
{
    partial class NhomMonAn
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
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.bt_TK = new System.Windows.Forms.Button();
            this.cbb_ML = new System.Windows.Forms.ComboBox();
            this.txt_TL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_DSNMA = new System.Windows.Forms.DataGridView();
            this.MaLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSNMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Thoat);
            this.groupBox1.Controls.Add(this.bt_Huy);
            this.groupBox1.Controls.Add(this.bt_TK);
            this.groupBox1.Controls.Add(this.cbb_ML);
            this.groupBox1.Controls.Add(this.txt_TL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhóm món ăn";
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(303, 343);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(96, 48);
            this.bt_Thoat.TabIndex = 6;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Location = new System.Drawing.Point(170, 343);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(96, 48);
            this.bt_Huy.TabIndex = 5;
            this.bt_Huy.Text = "Huỷ";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_TK
            // 
            this.bt_TK.Location = new System.Drawing.Point(36, 343);
            this.bt_TK.Name = "bt_TK";
            this.bt_TK.Size = new System.Drawing.Size(96, 48);
            this.bt_TK.TabIndex = 4;
            this.bt_TK.Text = "Tìm kiếm";
            this.bt_TK.UseVisualStyleBackColor = true;
            // 
            // cbb_ML
            // 
            this.cbb_ML.FormattingEnabled = true;
            this.cbb_ML.Location = new System.Drawing.Point(125, 142);
            this.cbb_ML.Name = "cbb_ML";
            this.cbb_ML.Size = new System.Drawing.Size(235, 28);
            this.cbb_ML.TabIndex = 3;
            // 
            // txt_TL
            // 
            this.txt_TL.Location = new System.Drawing.Point(125, 84);
            this.txt_TL.Name = "txt_TL";
            this.txt_TL.Size = new System.Drawing.Size(235, 26);
            this.txt_TL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_DSNMA);
            this.groupBox2.Location = new System.Drawing.Point(478, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 435);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhóm món ăn";
            // 
            // dtgv_DSNMA
            // 
            this.dtgv_DSNMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSNMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLM,
            this.tenLM});
            this.dtgv_DSNMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_DSNMA.Location = new System.Drawing.Point(3, 22);
            this.dtgv_DSNMA.Name = "dtgv_DSNMA";
            this.dtgv_DSNMA.RowHeadersWidth = 62;
            this.dtgv_DSNMA.RowTemplate.Height = 28;
            this.dtgv_DSNMA.Size = new System.Drawing.Size(486, 410);
            this.dtgv_DSNMA.TabIndex = 0;
            // 
            // MaLM
            // 
            this.MaLM.DataPropertyName = "maLM";
            this.MaLM.HeaderText = "Mã loại món";
            this.MaLM.MinimumWidth = 8;
            this.MaLM.Name = "MaLM";
            this.MaLM.Width = 150;
            // 
            // tenLM
            // 
            this.tenLM.DataPropertyName = "tenLM";
            this.tenLM.HeaderText = "Tên loại món ăn";
            this.tenLM.MinimumWidth = 8;
            this.tenLM.Name = "tenLM";
            this.tenLM.Width = 150;
            // 
            // NhomMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhomMonAn";
            this.Text = "NhomMonAn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSNMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_TK;
        private System.Windows.Forms.ComboBox cbb_ML;
        private System.Windows.Forms.TextBox txt_TL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_DSNMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLM;
    }
}