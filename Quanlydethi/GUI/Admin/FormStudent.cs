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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Quanlydethi.GUI.Admin
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private DataSet GetData()
        {
            DataSet data = new DataSet();
            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();
                String Query = "SELECT MATHISINH,NGAYSINH,NGAYGIANHAP,DIACHI,GMAIL FROM THISINHX";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow SelectRow = dataGridView1.Rows[index];
                txtCode.Text = SelectRow.Cells[0].Value.ToString();
                dtpDateBorn.Text = SelectRow.Cells[1].Value.ToString();
                dtpDateCreate.Text = SelectRow.Cells[2].Value.ToString();
                txtEmail.Text = SelectRow.Cells[3].Value.ToString();
                txtAddress.Text = SelectRow.Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                //Giấu BUG :)))
                // MessageBox.Show("Lỗi " + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals(""))
            {
                MessageBox.Show("Mã thí sinh không hợp lệ");
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

                    cmd.CommandText = "DELETE_THISINH";

                    cmd.Parameters.Add(new SqlParameter("@sMATHISNH", txtCode.Text.Trim()));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công mã" + txtCode.Text.Trim());
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thí sinh không thể xóa, thí sinh này không tồn tại");
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }


        private void Load_Data(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataSource = GetData().Tables[0];
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataSource = GetData().Tables[0];
        }
    }
}
