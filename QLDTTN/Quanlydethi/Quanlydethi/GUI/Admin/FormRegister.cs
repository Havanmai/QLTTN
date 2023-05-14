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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Hàm Kiểm tra Tài khoản Đã tồn Tại hay chưa 
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string Name = txtUsername.Text;
            SqlConnection con2 = new SqlConnection(DataProvider.sqlConnection);
            con2.Open();
            SqlCommand cmd = new SqlCommand("Select Username from TAIKHOAN", con2);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                if (Name == r.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con2.Close();
            return tatkt;
        }
        //  Khi dang ky Ta can Them du lieu vao Hai bang :v

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals("") ||
               dtpDateBorn.Text.Trim().Equals("") || txtAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Thông Tin Đã đủ chưa , Thiếu kìa ");
            }
            else
            {
                if (kiemtratontai() == true)
                {
                    MessageBox.Show("Không thể đăng ký, Người dùng đã tồn tại");
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
                        cmd.CommandText = "INSERT_USER";
                        cmd.Parameters.Add(new SqlParameter("@sUsername", txtUsername.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sPassword", txtPassword.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@srole", false));
                        cmd.Parameters.Add(new SqlParameter("@sMATHISINH", txtUsername.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sNGAYGIANHAP", month + "/" + day + "/" + year));
                        cmd.Parameters.Add(new SqlParameter("@sGMAIL", txtEmail.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sNGAYSINH", dtpDateBorn.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sDIACHI", txtAddress.Text.Trim()));

                        //Thực thi Stored Procedure
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Đăng ký thành công tài khoản mới");
                        this.Close();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Lỗi EX" + x);
                    }
                }

            }
        }
    }
}
