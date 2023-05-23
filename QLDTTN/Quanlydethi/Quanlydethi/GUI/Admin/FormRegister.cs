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

namespace Quanlydethi.GUI.Admin
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            getIDThiSinh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegisterAD_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
            }
            else
            {

                try
                {
                    DateTime today = DateTime.Now;
                    String year = Convert.ToString(today.Year);
                    String month = Convert.ToString(today.Month);
                    String day = Convert.ToString(today.Day);
                    //mở Cổng kết Nối Với Database
                    SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Tên PROC
                    cmd.CommandText = "INSERT_USER_LOGIN";
                    cmd.Parameters.Add(new SqlParameter("@sUsername", cmbUsername.SelectedValue.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@sPassword", txtPassword.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@srole", false));

                    //Thực thi Stored Procedure
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Đăng ký thành công tài khoản sinh viên mới");
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Lỗi EX" + x);
                }


            }
        

        }

       private void getIDThiSinh()
        {
            DataTable data = new DataTable();


            SqlConnection con2 = new SqlConnection(DataProvider.sqlConnection);
            con2.Open();
            SqlCommand cmd = new SqlCommand("SELECT THISINHX.MATHISINH FROM THISINHX LEFT JOIN TAIKHOAN ON THISINHX.MATHISINH = TAIKHOAN.USERNAME WHERE TAIKHOAN.USERNAME IS NULL", con2);
            SqlDataReader r = cmd.ExecuteReader();
            data.Load(r);
            cmbUsername.DisplayMember = "MATHISINH";
            cmbUsername.ValueMember = "MATHISINH";
            cmbUsername.DataSource = data;
            r.Close();
            con2.Close();
        }

    }
}
