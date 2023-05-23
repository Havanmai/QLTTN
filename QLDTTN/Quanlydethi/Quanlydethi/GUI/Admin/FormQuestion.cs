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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Quanlydethi.DAO;

namespace Quanlydethi.GUI.Admin
{
    public partial class FormQuestion : Form
    {
        public FormQuestion()
        {
            InitializeComponent();
            LoadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();
                SqlConnection con2 = new SqlConnection(DataProvider.sqlConnection);
                con2.Open();
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con2;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "INSERT_CH";
                cmd2.Parameters.Add(new SqlParameter("@sTENCH", txtQuestion.Text.Trim()));
                cmd2.Parameters.Add(new SqlParameter("@sA", txtA.Text.Trim()));
                cmd2.Parameters.Add(new SqlParameter("@sB", txtB.Text.Trim()));
                cmd2.Parameters.Add(new SqlParameter("@sC", txtC.Text.Trim()));
                cmd2.Parameters.Add(new SqlParameter("@sD", txtD.Text.Trim()));
                cmd2.Parameters.Add(new SqlParameter("@sDAPAN", cbAnswer.Text.Trim()));
                cmd2.Parameters.Add(new SqlParameter("@iMALOAICH",Convert.ToInt32(cmbCateQues.SelectedItem)));
                cmd2.Parameters.Add(new SqlParameter("@iMONHOC", Convert.ToInt32(cmbSub.SelectedItem)));
                cmd2.ExecuteNonQuery();
                con2.Close();
                LoadData();
                MessageBox.Show("Thêm Thành Công");
            }
            catch (Exception x)
            {
                MessageBox.Show("Câu hỏi này đa tồn tại. Vui lòng thêm câu khác");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals(""))
            {
                MessageBox.Show("Mã câu hỏi không hợp lệ");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = con;

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "UPDATE_CAUHOI_AND_DAPAN";

                    cmd.Parameters.Add(new SqlParameter("@sMACH", txtCode.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@sTENCH", txtQuestion.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@sLOAICH", "null"));
                    cmd.Parameters.Add(new SqlParameter("@sA", txtA.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@sB", txtB.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@sC", txtC.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@sD", txtD.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@sDAPAN", cbAnswer.Text.Trim()));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công");
                    con.Close();
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Câu hỏi không thể cập nhật, câu này không tồn tại");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals(""))
            {
                MessageBox.Show("Mã câu hỏi không hợp lệ");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = con;

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "DELETE_CAUHOI";

                    cmd.Parameters.Add(new SqlParameter("@sMACH", txtCode.Text.Trim()));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công câu hỏi mã là" + txtCode.Text.Trim());
                    con.Close();
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Câu hỏi không thể xóa, câu này không tồn tại" + ex);
                }

            }
        }


        // tìm kiếm Theo  Đáp Án đúng
        private DataSet TimkiemTheoDapan()
        {
            DataSet data = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();
                String Query = "SELECT CAUHOI.MACH,TENCH,A,B,C,D,Dapan FROM CAUHOI WHERE  Dapan='" +  cbAnswer.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(data);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi :" + ex);
                // DataGridViewRow
            }
            return data;
        }
        // tìm kiếm theo mã câu hỏi
        private DataSet TimkiemTheoma()
        {
            DataSet data = new DataSet();
            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();
                String Query = "SELECT CAUHOI.MACH, CAUHOI.TENCH, CAUHOI.A, CAUHOI.B, CAUHOI.C, CAUHOI.D, CAUHOI.Dapan FROM CAUHOI WHERE  CAUHOI.MACH='" + txtCode.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(data);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi :" + ex);
                // DataGridViewRow
            }
            return data;
        }
        // timd kiem gan dung cau hoi
        private DataSet Timkiemgandung()
        {
            DataSet data = new DataSet();
            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();
                String Query = "SELECT CAUHOI.MACH, CAUHOI.TENCH, CAUHOI.A, CAUHOI.B, CAUHOI.C, CAUHOI.D, CAUHOI.Dapan FROM CAUHOI WHERE TENCH LIKE N'%" + txtCode.Text + "%'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(data);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi :" + ex);
                // DataGridViewRow
            }
            return data;
        }
        private DataSet GetData()
        {
            DataSet data = new DataSet();
            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();
                String Query = "SELECT CAUHOI.MACH,CAUHOI.TENCH,CAUHOI.A,CAUHOI.B,CAUHOI.C,CAUHOI.D,CAUHOI.Dapan,MONHOC.TENMON,LOAICAUHOI.TENLOAICH FROM CAUHOI,LOAICAUHOI,MONHOC WHERE CAUHOI.MALOAICH=LOAICAUHOI.MALOAICH AND CAUHOI.MAMON=MONHOC.MAMON";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(data);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex);
                // DataGridViewRow
            }
            return data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow SelectRow = dataGridView1.Rows[index];
                txtCode.Text = SelectRow.Cells[0].Value.ToString();
                txtQuestion.Text = SelectRow.Cells[1].Value.ToString();
                txtA.Text = SelectRow.Cells[2].Value.ToString();
                txtB.Text = SelectRow.Cells[3].Value.ToString();
                txtC.Text = SelectRow.Cells[4].Value.ToString();
                txtD.Text = SelectRow.Cells[5].Value.ToString();
                cbAnswer.Text = SelectRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                //    MessageBox.Show("Vui Lòng click chỗ khác");
            }

        }

        private void LoadData()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataSource = GetData().Tables[0];
            this.getALLMon();
            this.getALLLoaiCH();
        }

      
        private void PhanloaiTk()
        {
            if (cmSearch.Text.Equals("Tìm Kiếm Theo Mã"))
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DataSource = TimkiemTheoma().Tables[0];
            }
            if (cmSearch.Text.Equals("Tìm Kiếm Gần Đúng Câu Hỏi"))
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DataSource = Timkiemgandung().Tables[0];
            }
            if (cmSearch.Text.Equals("Tìm Kiếm Đáp Án Đúng"))
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DataSource = TimkiemTheoDapan().Tables[0];
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cmSearch.SelectedItem != null)
            {
                PhanloaiTk();
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn hình thức tìm kiếm câu hỏi ^^");
            }
               
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCode.Text = null;
            txtQuestion.Text = null;
            txtA.Text = null;
            txtB.Text = null;
            txtC.Text = null;
            txtD.Text = null;
            cbAnswer.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void getALLMon()
        {
            DataTable data = new DataTable();


            SqlConnection con2 = new SqlConnection(DataProvider.sqlConnection);
            con2.Open();
            SqlCommand cmd = new SqlCommand("SELECT MAMON, TENMON FROM MONHOC", con2);
            SqlDataReader r = cmd.ExecuteReader();
            data.Load(r);
            cmbSub.DisplayMember = "TENMON";
            cmbSub.ValueMember = "MAMON";
            cmbSub.DataSource = data;
            r.Close();
            con2.Close();
        }

        private void getALLLoaiCH()
        {
            DataTable data = new DataTable();


            SqlConnection con2 = new SqlConnection(DataProvider.sqlConnection);
            con2.Open();
            SqlCommand cmd = new SqlCommand("SELECT MALOAICH, TENLOAICH FROM LOAICAUHOI", con2);
            SqlDataReader r = cmd.ExecuteReader();
            data.Load(r);
            cmbCateQues.DisplayMember = "TENLOAICH";
            cmbCateQues.ValueMember = "MALOAICH";
            cmbCateQues.DataSource = data;
            r.Close();
            con2.Close();
        }
    }
}
