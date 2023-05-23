using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quanlydethi.GUI.User
{
    public partial class FormStartExam : Form
    {
        string idname;
        string name;
        public FormStartExam(String id, String name)
        {
            InitializeComponent();
            idname = id;
            name = name;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStartExam_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = name;
            lblTime.Text = "30 phút";
            dtpNow.Text =  DateTime.Now.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbSub.SelectedItem.Equals("Java"))
            {
                FormExam fe = new FormExam(idname, "Java",name);
                fe.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("C# Chưa Có Câu Hỏi Hãy Thi Môn Java");
            }
        }
    }
}
