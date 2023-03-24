using System;
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
    public partial class Form_DangKi : Form
    {
        public Form_login _frm_login;
        public Form_DangKi(Form_login form_Login)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(512, 239);
            _frm_login = form_Login;
        }

        private void btn_BackLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _frm_login.Visible = true;
        }

        private void btn_Closed_DangKi_Click(object sender, EventArgs e)
        {
            _frm_login.Close();
            this.Close();
        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            // size ban đầu 512, 239
            //size sau 710, 239
            this.Size = new System.Drawing.Size(710, 239);
        }

        private void rdio_TruongKhoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("rtung khoa");
        }
    }
}
