namespace logiin
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.LB_DangKi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_Closed_Login = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lb_Login = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chk_SaveTk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BorderRadius = 10;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btn_Login, "btn_Login");
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
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
            // LB_DangKi
            // 
            this.LB_DangKi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LB_DangKi, "LB_DangKi");
            this.LB_DangKi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_DangKi.IsContextMenuEnabled = false;
            this.LB_DangKi.IsSelectionEnabled = false;
            this.LB_DangKi.Name = "LB_DangKi";
            this.LB_DangKi.Click += new System.EventHandler(this.LB_DangKi_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btn_Closed_Login
            // 
            resources.ApplyResources(this.btn_Closed_Login, "btn_Closed_Login");
            this.btn_Closed_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Closed_Login.FillColor = System.Drawing.Color.Transparent;
            this.btn_Closed_Login.IconColor = System.Drawing.Color.Black;
            this.btn_Closed_Login.Name = "btn_Closed_Login";
            this.btn_Closed_Login.Click += new System.EventHandler(this.btn_Closed_Login_Click);
            // 
            // lb_Login
            // 
            this.lb_Login.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lb_Login, "lb_Login");
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chk_SaveTk
            // 
            resources.ApplyResources(this.chk_SaveTk, "chk_SaveTk");
            this.chk_SaveTk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_SaveTk.CheckedState.BorderRadius = 2;
            this.chk_SaveTk.CheckedState.BorderThickness = 0;
            this.chk_SaveTk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_SaveTk.Name = "chk_SaveTk";
            this.chk_SaveTk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_SaveTk.UncheckedState.BorderRadius = 2;
            this.chk_SaveTk.UncheckedState.BorderThickness = 0;
            this.chk_SaveTk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Form_login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.chk_SaveTk);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.btn_Closed_Login);
            this.Controls.Add(this.LB_DangKi);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_login";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_TK;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_DangKi;
        private Guna.UI2.WinForms.Guna2TextBox txt_Pass;
        private Guna.UI2.WinForms.Guna2ControlBox btn_Closed_Login;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CheckBox chk_SaveTk;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_Login;
    }
}

