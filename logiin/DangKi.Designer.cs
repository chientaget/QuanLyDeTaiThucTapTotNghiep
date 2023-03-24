namespace logiin
{
    partial class Form_DangKi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangKi));
            this.lb_DangKi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Closed_DangKi = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txt_Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_DangKi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_BackLogin = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.rdio_TruongKhoa = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdio_SinhVien = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdio_GiangVien = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdio_khac = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cbx_ChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_DangKi
            // 
            this.lb_DangKi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lb_DangKi, "lb_DangKi");
            this.lb_DangKi.Name = "lb_DangKi";
            this.lb_DangKi.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Closed_DangKi
            // 
            resources.ApplyResources(this.btn_Closed_DangKi, "btn_Closed_DangKi");
            this.btn_Closed_DangKi.FillColor = System.Drawing.Color.Transparent;
            this.btn_Closed_DangKi.IconColor = System.Drawing.Color.Black;
            this.btn_Closed_DangKi.Name = "btn_Closed_DangKi";
            this.btn_Closed_DangKi.Click += new System.EventHandler(this.btn_Closed_DangKi_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.BorderRadius = 15;
            this.txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pass.DefaultText = "";
            this.txt_Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txt_Pass, "txt_Pass");
            this.txt_Pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '\0';
            this.txt_Pass.PlaceholderText = "Mật Khẩu";
            this.txt_Pass.SelectedText = "";
            // 
            // txt_TK
            // 
            this.txt_TK.BorderRadius = 15;
            this.txt_TK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TK.DefaultText = "";
            this.txt_TK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txt_TK, "txt_TK");
            this.txt_TK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.PasswordChar = '\0';
            this.txt_TK.PlaceholderText = "Tên tài khoản";
            this.txt_TK.SelectedText = "";
            // 
            // btn_DangKi
            // 
            this.btn_DangKi.BorderRadius = 10;
            this.btn_DangKi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangKi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangKi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangKi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btn_DangKi, "btn_DangKi");
            this.btn_DangKi.ForeColor = System.Drawing.Color.White;
            this.btn_DangKi.Name = "btn_DangKi";
            this.btn_DangKi.Click += new System.EventHandler(this.btn_DangKi_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.guna2TextBox1, "guna2TextBox1");
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Nhập Lại Mật Khẩu";
            this.guna2TextBox1.SelectedText = "";
            // 
            // btn_BackLogin
            // 
            this.btn_BackLogin.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
            resources.ApplyResources(this.btn_BackLogin, "btn_BackLogin");
            this.btn_BackLogin.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_BackLogin.Image = global::QuanLyDeTaiThucTapTotNghiep.Properties.Resources.back_Login;
            this.btn_BackLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_BackLogin.ImageRotate = 0F;
            this.btn_BackLogin.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_BackLogin.Name = "btn_BackLogin";
            this.btn_BackLogin.PressedState.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_BackLogin.Click += new System.EventHandler(this.btn_BackLogin_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btn_BackLogin);
            this.guna2Panel1.Controls.Add(this.btn_DangKi);
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Name = "guna2Panel1";
            // 
            // rdio_TruongKhoa
            // 
            resources.ApplyResources(this.rdio_TruongKhoa, "rdio_TruongKhoa");
            this.rdio_TruongKhoa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdio_TruongKhoa.CheckedState.BorderThickness = 0;
            this.rdio_TruongKhoa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdio_TruongKhoa.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdio_TruongKhoa.CheckedState.InnerOffset = -4;
            this.rdio_TruongKhoa.Name = "rdio_TruongKhoa";
            this.rdio_TruongKhoa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdio_TruongKhoa.UncheckedState.BorderThickness = 2;
            this.rdio_TruongKhoa.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdio_TruongKhoa.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdio_TruongKhoa.Click += new System.EventHandler(this.rdio_TruongKhoa_Click);
            // 
            // rdio_SinhVien
            // 
            resources.ApplyResources(this.rdio_SinhVien, "rdio_SinhVien");
            this.rdio_SinhVien.Checked = true;
            this.rdio_SinhVien.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdio_SinhVien.CheckedState.BorderThickness = 0;
            this.rdio_SinhVien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdio_SinhVien.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdio_SinhVien.CheckedState.InnerOffset = -4;
            this.rdio_SinhVien.Name = "rdio_SinhVien";
            this.rdio_SinhVien.TabStop = true;
            this.rdio_SinhVien.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdio_SinhVien.UncheckedState.BorderThickness = 2;
            this.rdio_SinhVien.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdio_SinhVien.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdio_GiangVien
            // 
            resources.ApplyResources(this.rdio_GiangVien, "rdio_GiangVien");
            this.rdio_GiangVien.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdio_GiangVien.CheckedState.BorderThickness = 0;
            this.rdio_GiangVien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdio_GiangVien.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdio_GiangVien.CheckedState.InnerOffset = -4;
            this.rdio_GiangVien.Name = "rdio_GiangVien";
            this.rdio_GiangVien.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdio_GiangVien.UncheckedState.BorderThickness = 2;
            this.rdio_GiangVien.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdio_GiangVien.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdio_khac
            // 
            resources.ApplyResources(this.rdio_khac, "rdio_khac");
            this.rdio_khac.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdio_khac.CheckedState.BorderThickness = 0;
            this.rdio_khac.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdio_khac.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdio_khac.CheckedState.InnerOffset = -4;
            this.rdio_khac.Name = "rdio_khac";
            this.rdio_khac.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdio_khac.UncheckedState.BorderThickness = 2;
            this.rdio_khac.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdio_khac.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cbx_ChucVu
            // 
            this.cbx_ChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbx_ChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_ChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ChucVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_ChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbx_ChucVu, "cbx_ChucVu");
            this.cbx_ChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_ChucVu.Name = "cbx_ChucVu";
            // 
            // Form_DangKi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.cbx_ChucVu);
            this.Controls.Add(this.rdio_khac);
            this.Controls.Add(this.rdio_GiangVien);
            this.Controls.Add(this.rdio_SinhVien);
            this.Controls.Add(this.rdio_TruongKhoa);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.lb_DangKi);
            this.Controls.Add(this.btn_Closed_DangKi);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_TK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DangKi";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_DangKi;
        private Guna.UI2.WinForms.Guna2ControlBox btn_Closed_DangKi;
        private Guna.UI2.WinForms.Guna2TextBox txt_Pass;
        private Guna.UI2.WinForms.Guna2TextBox txt_TK;
        private Guna.UI2.WinForms.Guna2Button btn_DangKi;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_BackLogin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton rdio_khac;
        private Guna.UI2.WinForms.Guna2RadioButton rdio_GiangVien;
        private Guna.UI2.WinForms.Guna2RadioButton rdio_SinhVien;
        private Guna.UI2.WinForms.Guna2RadioButton rdio_TruongKhoa;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_ChucVu;
    }
}