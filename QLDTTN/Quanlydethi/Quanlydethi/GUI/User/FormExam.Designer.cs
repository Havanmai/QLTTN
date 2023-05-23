namespace Quanlydethi.GUI.User
{
    partial class FormExam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.grbQuestion = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.lblQuestionContent = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.grbQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(613, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn thi : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(130, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 3;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSub.Location = new System.Drawing.Point(110, 72);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(0, 24);
            this.lblSub.TabIndex = 4;
            // 
            // grbQuestion
            // 
            this.grbQuestion.Controls.Add(this.label7);
            this.grbQuestion.Controls.Add(this.label6);
            this.grbQuestion.Controls.Add(this.label5);
            this.grbQuestion.Controls.Add(this.label4);
            this.grbQuestion.Controls.Add(this.rdbD);
            this.grbQuestion.Controls.Add(this.rdbC);
            this.grbQuestion.Controls.Add(this.rdbB);
            this.grbQuestion.Controls.Add(this.rdbA);
            this.grbQuestion.Controls.Add(this.lblQuestionContent);
            this.grbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuestion.Location = new System.Drawing.Point(13, 152);
            this.grbQuestion.Name = "grbQuestion";
            this.grbQuestion.Size = new System.Drawing.Size(1063, 509);
            this.grbQuestion.TabIndex = 5;
            this.grbQuestion.TabStop = false;
            this.grbQuestion.Text = "Câu hỏi ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "A";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(594, 357);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(119, 24);
            this.rdbD.TabIndex = 4;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "radioButton1";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(101, 359);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(119, 24);
            this.rdbC.TabIndex = 3;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "radioButton1";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(594, 118);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(119, 24);
            this.rdbB.TabIndex = 2;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "radioButton1";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(90, 120);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(119, 24);
            this.rdbA.TabIndex = 1;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "radioButton1";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // lblQuestionContent
            // 
            this.lblQuestionContent.AutoSize = true;
            this.lblQuestionContent.Location = new System.Drawing.Point(7, 39);
            this.lblQuestionContent.Name = "lblQuestionContent";
            this.lblQuestionContent.Size = new System.Drawing.Size(0, 20);
            this.lblQuestionContent.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(1001, 15);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Nộp bài";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(617, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 26);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "29:59";
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Location = new System.Drawing.Point(845, 123);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(100, 31);
            this.btnPre.TabIndex = 8;
            this.btnPre.Text = "<< Trước";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(967, 123);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 31);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Sau >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã sinh viên : ";
            // 
            // FormExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 708);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grbQuestion);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormExam";
            this.Text = "Bài thi";
            this.Load += new System.EventHandler(this.FormExam_Load);
            this.grbQuestion.ResumeLayout(false);
            this.grbQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.GroupBox grbQuestion;
        private System.Windows.Forms.Label lblQuestionContent;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
    }
}