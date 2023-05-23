using Quanlydethi.DAO;
using Quanlydethi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanlydethi.GUI.Admin
{
    public partial class FormCreateTS : Form
    {
        public FormCreateTS()
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

        private void getALLLop()
        {
            DataTable data= new DataTable();
            

            SqlConnection con2 = new SqlConnection(DataProvider.sqlConnection);
            con2.Open();
            SqlCommand cmd = new SqlCommand("SELECT MALOP, TENLOP FROM LOP", con2);
                SqlDataReader r = cmd.ExecuteReader();
                data.Load(r);
                cmbLop.DisplayMember = "TENLOP";
                cmbLop.ValueMember = "MALOP";
                cmbLop.DataSource = data;
                r.Close();
            con2.Close();
        }


        //  Khi dang ky Ta can Them du lieu vao Hai bang :v

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("")  || txtEmail.Text.Trim().Equals("") || 
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
                        cmd.Parameters.Add(new SqlParameter("@sHOTENTHISINH", txtUsername.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sNGAYGIANHAP", month + "/" + day + "/" + year));
                        cmd.Parameters.Add(new SqlParameter("@sGMAIL", txtEmail.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sNGAYSINH", dtpDateBorn.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@sDIACHI", txtAddress.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@iMALOP", Convert.ToInt32(cmbLop.SelectedItem)));

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

        private void FormRegister_Load(object sender, EventArgs e)
        {
            this.getALLLop();
        }

       
    }
}
