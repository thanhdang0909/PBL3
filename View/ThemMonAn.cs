﻿using DoAnPBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class ThemMonAn : Form
    {
        public ThemMonAn()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string txt = txtTimkiem.Text;
            dtgvMonan.DataSource = QLTDBLL.Instance.GetAll_MonAn(txt);
        }
    }
}
