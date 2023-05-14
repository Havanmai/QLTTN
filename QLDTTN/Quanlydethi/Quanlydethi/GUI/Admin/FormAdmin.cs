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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
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

        private void btnRegisterAD_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
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
                        cmd.CommandText = "INSERT_USER_ADMIN";
                        cmd.Parameters.Add(new SqlParameter("@sUsername", txtUsername.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sPassword", txtPassword.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@srole", true));

                        //Thực thi Stored Procedure
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Đăng ký thành công tài khoản admin mới");
                        this.Close();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Lỗi EX" + x);
                    }
                }

            }
        }

            private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = null;
            txtPassword.Text = null;
        }
    }
}
