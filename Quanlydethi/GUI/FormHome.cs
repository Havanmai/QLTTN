using Quanlydethi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlydethi.GUI.Admin;
using Quanlydethi.GUI.User;


namespace Quanlydethi.GUI
{
    public partial class FormHome : Form
    {
        FormLogin _frmLogin;
        String IdName;
        public FormHome(FormLogin Form, String Usename)
        {
            InitializeComponent();
            _frmLogin = Form;
            IdName = Usename;
            lbl_username.Text = IdName + "!";
            //Role_USer();
            //Kiểm tra quyền thôi :V
            //  MessageBox.Show(x);


        }

        String x;
        public bool Check_Role()
        {
            // Mở kết Nối 
            SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
            con.Open();

            SqlCommand comand = new SqlCommand("Select Role from TAIKHOAN WHERE Username ='" + IdName + "'", con);
            SqlDataReader r = comand.ExecuteReader();
            r.Read();
            x = r.GetValue(0).ToString();
            if (r.GetValue(0).ToString() == "True")
                return true;
            else
                return false;

            r.Close();
            con.Close();
        }

        //Phân Quyền :v
        public void Role_USer()
        {
            if (Check_Role() == true)
            {
                logOutToolStripMenuItem.Enabled = true;
                changePassToolStripMenuItem.Enabled = true;
                UserToolStripMenuItem.Enabled = true;
                sltStudent.Enabled = true;
                QuestionToolStripMenuItem.Enabled = true;
                HistoryExamToolStripMenuItem.Enabled = true;
                ExamToolStripMenuItem.Enabled = false;
                helpToolStripMenuItem.Enabled = true;
            }
            else
            {
                logOutToolStripMenuItem.Enabled = true;
                changePassToolStripMenuItem.Enabled = true;
                UserToolStripMenuItem.Enabled = false;
                sltStudent.Enabled = false;
                QuestionToolStripMenuItem.Enabled = false;
                HistoryExamToolStripMenuItem.Enabled = false;
                ExamToolStripMenuItem.Enabled = false;
                helpToolStripMenuItem.Enabled = true;
            }

        }



        private void btn_Register_Click(object sender, EventArgs e)
        {

        }

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser user = new FormUser();
            user.Show();
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void sltStudent_Click(object sender, EventArgs e)
        {
            FormStudent student = new FormStudent();
            student.Show();
        }

        private void QuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuestion question = new FormQuestion();
            question.Show();

        }

        private void HistoryExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory history =new FormHistory();
            history.Show();
        }

        private void ExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExam exam= new FormExam();
            exam.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}