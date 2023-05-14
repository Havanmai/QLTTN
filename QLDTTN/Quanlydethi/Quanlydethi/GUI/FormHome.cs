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
            Role_USer();
            grbHelp.Visible = false;
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
                MangamentUserToolStripMenuItem.Enabled = true;
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
                MangamentUserToolStripMenuItem.Enabled = false;
                sltStudent.Enabled = false;
                QuestionToolStripMenuItem.Enabled = false;
                HistoryExamToolStripMenuItem.Enabled = false;
                ExamToolStripMenuItem.Enabled = true;
                helpToolStripMenuItem.Enabled = true;
            }

        }



        private void btn_Register_Click(object sender, EventArgs e)
        {
            
        }

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormRegister user = new FormRegister();
            user.Show();
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormChangePassword changePassword = new FormChangePassword(IdName);
            changePassword.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void sltStudent_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormStudent student = new FormStudent();
            student.Show();
        }

        private void QuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormQuestion question = new FormQuestion();
            question.Show();

        }

        private void HistoryExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormHistory history =new FormHistory();
            history.Show();
        }

        private void ExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormStartExam exam= new FormStartExam(IdName);
            exam.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            grbHelp.Visible = true;
        }

        private void ADMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormAdmin admin = new FormAdmin();  
            admin.Show();
        }
    }
}