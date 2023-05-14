namespace Quanlydethi.GUI.Admin
{
    partial class FormQuestion
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
            this.grpbQuestion = new System.Windows.Forms.GroupBox();
            this.cmSearch = new System.Windows.Forms.ComboBox();
            this.cbAnswer = new System.Windows.Forms.ComboBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbQuestion
            // 
            this.grpbQuestion.Controls.Add(this.cmSearch);
            this.grpbQuestion.Controls.Add(this.cbAnswer);
            this.grpbQuestion.Controls.Add(this.txtD);
            this.grpbQuestion.Controls.Add(this.txtC);
            this.grpbQuestion.Controls.Add(this.txtB);
            this.grpbQuestion.Controls.Add(this.txtA);
            this.grpbQuestion.Controls.Add(this.txtQuestion);
            this.grpbQuestion.Controls.Add(this.txtSearch);
            this.grpbQuestion.Controls.Add(this.txtCode);
            this.grpbQuestion.Controls.Add(this.btnCancel);
            this.grpbQuestion.Controls.Add(this.btnExit);
            this.grpbQuestion.Controls.Add(this.btnDelete);
            this.grpbQuestion.Controls.Add(this.btnEdit);
            this.grpbQuestion.Controls.Add(this.btnSearch);
            this.grpbQuestion.Controls.Add(this.btnCreate);
            this.grpbQuestion.Controls.Add(this.label1);
            this.grpbQuestion.Controls.Add(this.lblSearch);
            this.grpbQuestion.Controls.Add(this.lblD);
            this.grpbQuestion.Controls.Add(this.lblC);
            this.grpbQuestion.Controls.Add(this.lblB);
            this.grpbQuestion.Controls.Add(this.lblA);
            this.grpbQuestion.Controls.Add(this.lblanswer);
            this.grpbQuestion.Controls.Add(this.lblquestion);
            this.grpbQuestion.Controls.Add(this.lblCode);
            this.grpbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbQuestion.Location = new System.Drawing.Point(1, 2);
            this.grpbQuestion.Name = "grpbQuestion";
            this.grpbQuestion.Size = new System.Drawing.Size(1099, 340);
            this.grpbQuestion.TabIndex = 0;
            this.grpbQuestion.TabStop = false;
            this.grpbQuestion.Text = "Thiết lập câu hỏi";
            this.grpbQuestion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmSearch
            // 
            this.cmSearch.FormattingEnabled = true;
            this.cmSearch.Location = new System.Drawing.Point(741, 238);
            this.cmSearch.Name = "cmSearch";
            this.cmSearch.Items.AddRange(new object[] {
            "Tìm Kiếm Theo Mã",
            "Tìm Kiếm Gần Đúng Câu Hỏi",
            "Tìm Kiếm Đáp Án Đúng"});
            this.cmSearch.Size = new System.Drawing.Size(315, 32);
            this.cmSearch.TabIndex = 23;
            // 
            // cbAnswer
            // 
            this.cbAnswer.FormattingEnabled = true;
            this.cbAnswer.Location = new System.Drawing.Point(128, 187);
            this.cbAnswer.Name = "cbAnswer";
            this.cbAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbAnswer.Size = new System.Drawing.Size(347, 32);
            this.cbAnswer.TabIndex = 22;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(682, 179);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(374, 29);
            this.txtD.TabIndex = 21;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(682, 138);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(374, 29);
            this.txtC.TabIndex = 20;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(682, 98);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(374, 29);
            this.txtB.TabIndex = 19;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(682, 50);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(374, 29);
            this.txtA.TabIndex = 18;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(128, 98);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(347, 69);
            this.txtQuestion.TabIndex = 17;
            this.txtQuestion.Text = "";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(128, 229);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 29);
            this.txtSearch.TabIndex = 16;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(128, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(347, 29);
            this.txtCode.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(400, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(981, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(280, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(153, 298);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 27);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(858, 291);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 34);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(35, 298);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 27);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn loại tìm kiếm : ";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(37, 238);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 17);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Tìm kiếm : ";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(600, 187);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(84, 17);
            this.lblD.TabIndex = 6;
            this.lblD.Text = "Đáp án D  : ";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(597, 147);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(75, 17);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Đáp án C :";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(597, 107);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(79, 17);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Đáp án B : ";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(597, 62);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(75, 17);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Đáp án A :";
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer.Location = new System.Drawing.Point(37, 187);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(66, 17);
            this.lblanswer.TabIndex = 2;
            this.lblanswer.Text = "Đáp án : ";
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(32, 98);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(68, 17);
            this.lblquestion.TabIndex = 1;
            this.lblquestion.Text = "Câu hỏi  :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(32, 50);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(89, 17);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Mã câu hỏi : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1099, 402);
            this.dataGridView1.TabIndex = 1;
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 752);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpbQuestion);
            this.Name = "FormQuestion";
            this.Text = "Quản lý câu hỏi";
            this.grpbQuestion.ResumeLayout(false);
            this.grpbQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbQuestion;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.RichTextBox txtQuestion;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cmSearch;
        private System.Windows.Forms.ComboBox cbAnswer;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}