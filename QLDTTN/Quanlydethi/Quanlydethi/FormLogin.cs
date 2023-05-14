using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlydethi.DAO;
using Quanlydethi.GUI;

namespace Quanlydethi
{
    public partial class FormLogin : Form
    {
        public static bool ResultOk = false;
        public FormLogin()
        {
            
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);

                con.Open();
                // Lấy mật Khẩu Nếu Tên Tài Khoản đang Trùng với EditText tài khoản
                
                SqlCommand comand = new SqlCommand("Select Password from TAIKHOAN WHERE Username ='" + txtUsername.Text.Trim() + "'", con);

                SqlDataReader r = comand.ExecuteReader();
                r.Read();

                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu hoặc tài khoản!");

                }
                else if (txtPassword.Text.Trim() == r.GetValue(0).ToString())
                {
                    //  Load f = new Load();
                    //  f.Show();

                    MessageBox.Show("Đăng nhập hệ thống thành công !");
                    
                    r.Close();
                    con.Close();
                    ResultOk = true;
                    //   f.Close();
                    FormHome home = new FormHome(this, txtUsername.Text.Trim());
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
                r.Close();
                con.Close();



            }
            catch (Exception)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ .Vui lòng xem lại");

            }


        }

        private void chkb_visiblePassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chkb_visiblePassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
               txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = null;
            txtPassword.Text = null;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
