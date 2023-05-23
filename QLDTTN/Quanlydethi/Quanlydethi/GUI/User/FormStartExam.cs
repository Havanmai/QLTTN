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
using System.Xml.Linq;

namespace Quanlydethi.GUI.User
{
    public partial class FormStartExam : Form
    {
        string idname;
        string nameTS;
        public FormStartExam(String id, String name)
        {
            InitializeComponent();
            idname = id;
            nameTS = name;
            getALLMon();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStartExam_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = nameTS;
            lblTime.Text = "30 phút";
            dtpNow.Text =  DateTime.Now.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbSub.SelectedValue.ToString()).Equals(1))
            {
                FormExam fe = new FormExam(idname, "Java", nameTS);
                fe.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("C# Chưa Có Câu Hỏi Hãy Thi Môn Java");
            }
        }

        private void getALLMon()
        {
            DataTable data = new DataTable();


            SqlConnection con2 = new SqlConnection(DataProvider.sqlConnection);
            con2.Open();
            SqlCommand cmd = new SqlCommand("SELECT MAMON, TENMON FROM MONHOC", con2);
            SqlDataReader r = cmd.ExecuteReader();
            data.Load(r);
            cbSub.DisplayMember = "TENMON";
            cbSub.ValueMember = "MAMON";
            cbSub.DataSource = data;
            
            r.Close();
            con2.Close();
        }
    }
}
