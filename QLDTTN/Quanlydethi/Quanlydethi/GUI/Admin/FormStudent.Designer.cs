﻿namespace Quanlydethi.GUI.Admin
{
    partial class FormStudent
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblDateBorn = new System.Windows.Forms.Label();
            this.lblDateCreate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpDateBorn = new System.Windows.Forms.DateTimePicker();
            this.dtpDateCreate = new System.Windows.Forms.DateTimePicker();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNameTS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(24, 34);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(99, 17);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Mã sinh viên : ";
            // 
            // lblDateBorn
            // 
            this.lblDateBorn.AutoSize = true;
            this.lblDateBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBorn.Location = new System.Drawing.Point(24, 110);
            this.lblDateBorn.Name = "lblDateBorn";
            this.lblDateBorn.Size = new System.Drawing.Size(79, 17);
            this.lblDateBorn.TabIndex = 1;
            this.lblDateBorn.Text = "Ngày sinh :";
            // 
            // lblDateCreate
            // 
            this.lblDateCreate.AutoSize = true;
            this.lblDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreate.Location = new System.Drawing.Point(651, 38);
            this.lblDateCreate.Name = "lblDateCreate";
            this.lblDateCreate.Size = new System.Drawing.Size(77, 17);
            this.lblDateCreate.TabIndex = 2;
            this.lblDateCreate.Text = "Ngày tạo : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(651, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email : ";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(651, 127);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Địa chỉ : ";
            // 
            // dtpDateBorn
            // 
            this.dtpDateBorn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBorn.Location = new System.Drawing.Point(176, 110);
            this.dtpDateBorn.Name = "dtpDateBorn";
            this.dtpDateBorn.Size = new System.Drawing.Size(298, 23);
            this.dtpDateBorn.TabIndex = 5;
            // 
            // dtpDateCreate
            // 
            this.dtpDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCreate.Location = new System.Drawing.Point(770, 38);
            this.dtpDateCreate.Name = "dtpDateCreate";
            this.dtpDateCreate.Size = new System.Drawing.Size(263, 23);
            this.dtpDateCreate.TabIndex = 6;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(176, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(298, 23);
            this.txtCode.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(770, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(770, 124);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(263, 23);
            this.txtAddress.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1134, 526);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(682, 161);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 24);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(787, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(998, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(880, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNameTS
            // 
            this.txtNameTS.Location = new System.Drawing.Point(176, 70);
            this.txtNameTS.Name = "txtNameTS";
            this.txtNameTS.Size = new System.Drawing.Size(298, 20);
            this.txtNameTS.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Họ tên sinh viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lớp : ";
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(176, 149);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(298, 21);
            this.cmbLop.TabIndex = 18;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 715);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameTS);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dtpDateCreate);
            this.Controls.Add(this.dtpDateBorn);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDateCreate);
            this.Controls.Add(this.lblDateBorn);
            this.Controls.Add(this.lblStudent);
            this.Name = "FormStudent";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblDateBorn;
        private System.Windows.Forms.Label lblDateCreate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpDateBorn;
        private System.Windows.Forms.DateTimePicker dtpDateCreate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNameTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLop;
    }
}