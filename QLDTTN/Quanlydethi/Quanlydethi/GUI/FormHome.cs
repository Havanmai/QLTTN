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
            
            lbl_username.Text = !Check_Role()? (getName() + "!"): (Usename + "!");
            Role_USer();
            grbHelp.Visible = false;
        }


        public String getName()
        {
            SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
            con.Open();

            SqlCommand comand = new SqlCommand("Select HOTENTHISINH from THISINHX WHERE MATHISINH ='" + IdName + "'", con);
            SqlDataReader r = comand.ExecuteReader();
            r.Read();

            return r.GetValue(0).ToString();
            

            r.Close();
            con.Close();
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
                logOutToolStripMenuItem.Visible = true;
                changePassToolStripMenuItem.Visible = true;
                MangamentUserToolStripMenuItem.Visible = true;
                sltStudent.Visible = true;
                QuestionToolStripMenuItem.Visible = true;
                HistoryExamToolStripMenuItem.Visible = true;
                ExamToolStripMenuItem.Visible = false;
                helpToolStripMenuItem.Visible = true;
                classToolStripMenuItem.Visible = true;
                subToolStripMenuItem.Visible = true;
            }
            else
            {
                logOutToolStripMenuItem.Visible = true;
                changePassToolStripMenuItem.Visible = true;
                MangamentUserToolStripMenuItem.Visible = false;
                sltStudent.Visible = false;
                QuestionToolStripMenuItem.Visible = false;
                HistoryExamToolStripMenuItem.Visible = true;
                ExamToolStripMenuItem.Visible = true;
                helpToolStripMenuItem.Visible = true;
                classToolStripMenuItem.Visible = false;
                subToolStripMenuItem.Visible = false;
            }

        }



        private void btn_Register_Click(object sender, EventArgs e)
        {
            
        }

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormCreateTS user = new FormCreateTS();
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
            FormHistory history =new FormHistory(Check_Role(),IdName);
            history.Show();
        }

        private void ExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormStartExam exam= new FormStartExam(IdName,getName());
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

        private void UserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormRegister user = new FormRegister();
            user.Show();
        }

        private void listStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormStudent student = new FormStudent();
            student.Show();
        }

        private void creatStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormCreateTS user = new FormCreateTS();
            user.Show();
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormSub sub = new FormSub();
            sub.Show();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbHelp.Visible = false;
            FormClass clas= new FormClass();
            clas.Show();
        }
    }
}