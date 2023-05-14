namespace Quanlydethi.GUI
{
    partial class FormHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MangamentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ADMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sltStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_System = new System.Windows.Forms.GroupBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbHelp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grb_System.SuspendLayout();
            this.grbHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SysToolStripMenuItem,
            this.ManageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SysToolStripMenuItem
            // 
            this.SysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MangamentUserToolStripMenuItem,
            this.changePassToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.SysToolStripMenuItem.Name = "SysToolStripMenuItem";
            this.SysToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.SysToolStripMenuItem.Text = "Thiết lập hệ thống";
            // 
            // MangamentUserToolStripMenuItem
            // 
            this.MangamentUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADMINToolStripMenuItem,
            this.UserToolStripMenuItem});
            this.MangamentUserToolStripMenuItem.Name = "MangamentUserToolStripMenuItem";
            this.MangamentUserToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.MangamentUserToolStripMenuItem.Text = "Đăng ký  tài khoản";
            this.MangamentUserToolStripMenuItem.Click += new System.EventHandler(this.UserToolStripMenuItem_Click);
            // 
            // ADMINToolStripMenuItem
            // 
            this.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem";
            this.ADMINToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ADMINToolStripMenuItem.Text = "Tài khoản ADMIN";
            this.ADMINToolStripMenuItem.Click += new System.EventHandler(this.ADMINToolStripMenuItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.UserToolStripMenuItem.Text = "Tài khoản User";
            // 
            // changePassToolStripMenuItem
            // 
            this.changePassToolStripMenuItem.Name = "changePassToolStripMenuItem";
            this.changePassToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.changePassToolStripMenuItem.Text = "Đổi mật khẩu";
            this.changePassToolStripMenuItem.Click += new System.EventHandler(this.changePassToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.logOutToolStripMenuItem.Text = "Đăng xuất";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // ManageToolStripMenuItem
            // 
            this.ManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sltStudent,
            this.QuestionToolStripMenuItem,
            this.HistoryExamToolStripMenuItem,
            this.ExamToolStripMenuItem});
            this.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem";
            this.ManageToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ManageToolStripMenuItem.Text = "Quản lý";
            // 
            // sltStudent
            // 
            this.sltStudent.Name = "sltStudent";
            this.sltStudent.Size = new System.Drawing.Size(179, 22);
            this.sltStudent.Text = "Danh sách sinh viên";
            this.sltStudent.Click += new System.EventHandler(this.sltStudent_Click);
            // 
            // QuestionToolStripMenuItem
            // 
            this.QuestionToolStripMenuItem.Name = "QuestionToolStripMenuItem";
            this.QuestionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.QuestionToolStripMenuItem.Text = "Danh sách câu hỏi";
            this.QuestionToolStripMenuItem.Click += new System.EventHandler(this.QuestionToolStripMenuItem_Click);
            // 
            // HistoryExamToolStripMenuItem
            // 
            this.HistoryExamToolStripMenuItem.Name = "HistoryExamToolStripMenuItem";
            this.HistoryExamToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.HistoryExamToolStripMenuItem.Text = "Lịch sử bài thi";
            this.HistoryExamToolStripMenuItem.Click += new System.EventHandler(this.HistoryExamToolStripMenuItem_Click);
            // 
            // ExamToolStripMenuItem
            // 
            this.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem";
            this.ExamToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ExamToolStripMenuItem.Text = "Làm bài thi";
            this.ExamToolStripMenuItem.Click += new System.EventHandler(this.ExamToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.helpToolStripMenuItem.Text = "Trợ giúp";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // grb_System
            // 
            this.grb_System.BackgroundImage = global::Quanlydethi.Properties.Resources.home;
            this.grb_System.Controls.Add(this.grbHelp);
            this.grb_System.Controls.Add(this.lbl_username);
            this.grb_System.Controls.Add(this.label2);
            this.grb_System.Controls.Add(this.label1);
            this.grb_System.Location = new System.Drawing.Point(12, 27);
            this.grb_System.Name = "grb_System";
            this.grb_System.Size = new System.Drawing.Size(776, 377);
            this.grb_System.TabIndex = 1;
            this.grb_System.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(250, 149);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(0, 24);
            this.lbl_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chúc bạn có một kì thi thật tốt!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào, ";
            // 
            // grbHelp
            // 
            this.grbHelp.BackColor = System.Drawing.Color.Transparent;
            this.grbHelp.Controls.Add(this.label5);
            this.grbHelp.Controls.Add(this.label4);
            this.grbHelp.Controls.Add(this.label3);
            this.grbHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHelp.Location = new System.Drawing.Point(38, 48);
            this.grbHelp.Name = "grbHelp";
            this.grbHelp.Size = new System.Drawing.Size(685, 300);
            this.grbHelp.TabIndex = 3;
            this.grbHelp.TabStop = false;
            this.grbHelp.Text = "Thông tin liên hệ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mọi thắc mắc xin liên hệ : HVM - DKH để  được giải đáp ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "SDT : 013654789";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email : HoangDK@gmai.com";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grb_System);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grb_System.ResumeLayout(false);
            this.grb_System.PerformLayout();
            this.grbHelp.ResumeLayout(false);
            this.grbHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MangamentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sltStudent;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistoryExamToolStripMenuItem;
        private System.Windows.Forms.GroupBox grb_System;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ADMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbHelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}