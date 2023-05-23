namespace Quanlydethi
{
    partial class FormLogin
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
            this.formDangnhap = new System.Windows.Forms.Panel();
            this.chkb_visiblePassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.label_tendangnhap = new System.Windows.Forms.Label();
            this.tieuDeForm = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.formDangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // formDangnhap
            // 
            this.formDangnhap.BackColor = System.Drawing.Color.Snow;
            this.formDangnhap.Controls.Add(this.chkb_visiblePassword);
            this.formDangnhap.Controls.Add(this.txtPassword);
            this.formDangnhap.Controls.Add(this.txtUsername);
            this.formDangnhap.Controls.Add(this.label_matkhau);
            this.formDangnhap.Controls.Add(this.label_tendangnhap);
            this.formDangnhap.Controls.Add(this.tieuDeForm);
            this.formDangnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.formDangnhap.Location = new System.Drawing.Point(357, 125);
            this.formDangnhap.Name = "formDangnhap";
            this.formDangnhap.Size = new System.Drawing.Size(397, 244);
            this.formDangnhap.TabIndex = 0;
            // 
            // chkb_visiblePassword
            // 
            this.chkb_visiblePassword.AutoSize = true;
            this.chkb_visiblePassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_visiblePassword.Location = new System.Drawing.Point(156, 205);
            this.chkb_visiblePassword.Name = "chkb_visiblePassword";
            this.chkb_visiblePassword.Size = new System.Drawing.Size(137, 20);
            this.chkb_visiblePassword.TabIndex = 2;
            this.chkb_visiblePassword.Text = "Hiển thị mật khẩu";
            this.chkb_visiblePassword.UseVisualStyleBackColor = true;
            this.chkb_visiblePassword.CheckedChanged += new System.EventHandler(this.chkb_visiblePassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(156, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
           
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matkhau.Location = new System.Drawing.Point(27, 149);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(82, 17);
            this.label_matkhau.TabIndex = 2;
            this.label_matkhau.Text = "Mật khẩu :";
            // 
            // label_tendangnhap
            // 
            this.label_tendangnhap.AutoSize = true;
            this.label_tendangnhap.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tendangnhap.Location = new System.Drawing.Point(27, 98);
            this.label_tendangnhap.Name = "label_tendangnhap";
            this.label_tendangnhap.Size = new System.Drawing.Size(122, 17);
            this.label_tendangnhap.TabIndex = 1;
            this.label_tendangnhap.Text = "Tên đăng nhập :";
            // 
            // tieuDeForm
            // 
            this.tieuDeForm.BackColor = System.Drawing.Color.Snow;
            this.tieuDeForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tieuDeForm.CausesValidation = false;
            this.tieuDeForm.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieuDeForm.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.tieuDeForm.Location = new System.Drawing.Point(104, 20);
            this.tieuDeForm.Name = "tieuDeForm";
            this.tieuDeForm.Size = new System.Drawing.Size(179, 36);
            this.tieuDeForm.TabIndex = 5;
            this.tieuDeForm.Text = "Đăng nhập";
            this.tieuDeForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tieuDeForm.WordWrap = true;
            // 
            // txtUsername
            // 
            
            this.txtUsername.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(156, 90);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 25);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.No;
            this.txtUsername.UseWaitCursor = true;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(445, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 39);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(606, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 39);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quanlydethi.Properties.Resources.anh_login;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.formDangnhap);
            this.Name = "FormLogin";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.formDangnhap.ResumeLayout(false);
            this.formDangnhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formDangnhap;
        private System.Windows.Forms.CheckBox chkb_visiblePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.Label label_tendangnhap;
        private System.Windows.Forms.TextBox tieuDeForm;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}

