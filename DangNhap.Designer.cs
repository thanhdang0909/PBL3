namespace PBL
{
    partial class DangNhap
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
            this.bt_DN = new System.Windows.Forms.Button();
            this.bt_QMK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TDN = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_DN
            // 
            this.bt_DN.Location = new System.Drawing.Point(192, 325);
            this.bt_DN.Name = "bt_DN";
            this.bt_DN.Size = new System.Drawing.Size(106, 44);
            this.bt_DN.TabIndex = 0;
            this.bt_DN.Text = "Đăng nhập";
            this.bt_DN.UseVisualStyleBackColor = true;
            this.bt_DN.Click += new System.EventHandler(this.bt_DN_Click);
            // 
            // bt_QMK
            // 
            this.bt_QMK.Location = new System.Drawing.Point(333, 325);
            this.bt_QMK.Name = "bt_QMK";
            this.bt_QMK.Size = new System.Drawing.Size(145, 44);
            this.bt_QMK.TabIndex = 1;
            this.bt_QMK.Text = "Quên mật khẩu";
            this.bt_QMK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txt_TDN
            // 
            this.txt_TDN.Location = new System.Drawing.Point(237, 150);
            this.txt_TDN.Name = "txt_TDN";
            this.txt_TDN.Size = new System.Drawing.Size(276, 26);
            this.txt_TDN.TabIndex = 4;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(237, 202);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(276, 26);
            this.txt_MK.TabIndex = 5;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 536);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_QMK);
            this.Controls.Add(this.bt_DN);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_DN;
        private System.Windows.Forms.Button bt_QMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TDN;
        private System.Windows.Forms.TextBox txt_MK;
    }
}

