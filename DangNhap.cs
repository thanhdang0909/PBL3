﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void bt_DN_Click(object sender, EventArgs e)
        {
            new TrangChuNV().Show();
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
