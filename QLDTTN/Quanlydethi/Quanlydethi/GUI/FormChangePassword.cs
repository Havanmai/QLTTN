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

namespace Quanlydethi.GUI
{
    public partial class FormChangePassword : Form
    {
        public String getUS;
        public FormChangePassword(String USERNAME)
        {
            InitializeComponent();
            getUS = USERNAME;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkmkcu() == false)
            {
                MessageBox.Show("Mật Khẩu Cũ Sai =))");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                    con.Open(); // mở kết nối  
                    // Tạo đối tượng Command
                    SqlCommand cmd = new SqlCommand();
                    //Thiết lập các thuộc tính cho đối tượng Command
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Update_pass";
                    // Gắn các Parameter và giá trị cho đối tượng Command
                    cmd.Parameters.Add(new SqlParameter("@sPassword", txtPassNew.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@sUsername", getUS));
                    //Thực thi Stored Procedure
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Đổi mật khẩu Thành Công! ");
                }
                catch (Exception x)
                {
                    MessageBox.Show(x + "");
                }
                this.Close();
            }
        }

        private bool checkmkcu()
        {
            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();
                SqlCommand comand = new SqlCommand("Select Password from TAIKHOAN WHERE Username ='" + getUS + "'", con);
                SqlDataReader r = comand.ExecuteReader();
                r.Read();
                if (txtPassOld.Text.Equals(r.GetValue(0).ToString()))
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex);
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassNew.Text = null;
            txtPassOld.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
