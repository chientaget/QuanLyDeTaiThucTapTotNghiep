﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logiin
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

        }

        private void LB_DangKi_Click(object sender, EventArgs e)
        {
           this.Visible = false;
            Form_DangKi form_DangKi= new Form_DangKi(this);
            form_DangKi.ShowDialog();
        }

        private void btn_Closed_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
