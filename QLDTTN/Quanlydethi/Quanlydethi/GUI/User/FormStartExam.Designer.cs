namespace Quanlydethi.GUI.User
{
    partial class FormStartExam
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.dtpNow = new System.Windows.Forms.DateTimePicker();
            this.cbSub = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeExam = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.lblNameUser);
            this.panel1.Controls.Add(this.dtpNow);
            this.panel1.Controls.Add(this.cbSub);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblTimeExam);
            this.panel1.Controls.Add(this.lblSub);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(118, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 363);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(179, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 52);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Snow;
            this.btnStart.Location = new System.Drawing.Point(21, 259);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 52);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Làm bài";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.Location = new System.Drawing.Point(123, 27);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(0, 18);
            this.lblNameUser.TabIndex = 7;
            // 
            // dtpNow
            // 
            this.dtpNow.Enabled = false;
            this.dtpNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNow.Location = new System.Drawing.Point(123, 82);
            this.dtpNow.Name = "dtpNow";
            this.dtpNow.Size = new System.Drawing.Size(118, 23);
            this.dtpNow.TabIndex = 6;
            // 
            // cbSub
            // 
            this.cbSub.FormattingEnabled = true;
            this.cbSub.Items.AddRange(new object[] {
            "C#",
            "Java Cơ Bản"});
            this.cbSub.Location = new System.Drawing.Point(123, 127);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(118, 21);
            this.cbSub.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(145, 169);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "30 phút";
            // 
            // lblTimeExam
            // 
            this.lblTimeExam.AutoSize = true;
            this.lblTimeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeExam.Location = new System.Drawing.Point(20, 169);
            this.lblTimeExam.Name = "lblTimeExam";
            this.lblTimeExam.Size = new System.Drawing.Size(98, 17);
            this.lblTimeExam.TabIndex = 3;
            this.lblTimeExam.Text = "Thời gian thi : ";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(23, 127);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(66, 17);
            this.lblSub.TabIndex = 2;
            this.lblSub.Text = "Môn thi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày thi :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã sinh viên : ";
            // 
            // FormStartExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quanlydethi.Properties.Resources.Start;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormStartExam";
            this.Text = "Xác nhận làm bài thi";
            this.Load += new System.EventHandler(this.FormStartExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.DateTimePicker dtpNow;
        private System.Windows.Forms.ComboBox cbSub;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeExam;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
    }
}