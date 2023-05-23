using Quanlydethi.DAO;
using Quanlydethi.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanlydethi.GUI
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

       
        DataSet getLichsuthi()
        {
            DataSet data = new DataSet();

            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);

                con.Open();
                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON, LOP.TENLOP FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH JOIN LOP ON LOP.MALOP = THISINHX.MALOP; ";
                SqlCommand cmd = new SqlCommand(Query, con);

                SqlDataAdapter Adap = new SqlDataAdapter(cmd);

                Adap.Fill(data);

                con.Close();
            }
            catch (Exception ex)
            {

            }

            return data;
        }

        DataSet getLichsuthibyCOD()
        {
            DataSet data = new DataSet();

            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();

                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON, LOP.TENLOP FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH JOIN LOP ON LOP.MALOP = THISINHX.MALOP AND KETQUA.MATHISINH = '" + txtCodeSV.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(Query, con);

                SqlDataAdapter Adap = new SqlDataAdapter(cmd);

                Adap.Fill(data);

                con.Close();
            }
            catch (Exception ex)
            {

            }

            return data;
        }

        DataSet getLichsuthibySub()
        {
            DataSet data = new DataSet();


            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);

                con.Open();

                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON, LOP.TENLOP FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH JOIN LOP ON LOP.MALOP = THISINHX.MALOP AND KETQUA.MAMON = '" + cmbSub.SelectedIndex.ToString() + "'";
                SqlCommand cmd = new SqlCommand(Query, con);

                SqlDataAdapter Adap = new SqlDataAdapter(cmd);

                Adap.Fill(data);

                con.Close();
            }
            catch (Exception ex)
            {

            }

            return data;
        }


        DataSet getLichsuthibyLop()
        {
            DataSet data = new DataSet();

            try
            {

                using (SqlConnection con = new SqlConnection(DataProvider.sqlConnection))
                {
                    con.Open();

                    string query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON, LOP.TENLOP FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH JOIN LOP ON LOP.MALOP = THISINHX.MALOP AND LOP.MALOP = @MALOP";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MALOP", Convert.ToInt32(cmbLop.SelectedIndex.ToString()));

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }

            }
            catch (Exception ex)
            {

            }

            return data;
        }

        DataSet getLichsuthibyLopandSub()
        {
            DataSet data = new DataSet();

            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);

                con.Open();

                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON, LOP.TENLOP FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH JOIN LOP ON LOP.MALOP = THISINHX.MALOP AND LOP.MALOP = '" + Convert.ToInt32(cmbLop.SelectedIndex.ToString()) + "' AND KETQUA.MAMON = " + Convert.ToInt32(cmbSub.SelectedIndex.ToString());
                SqlCommand cmd = new SqlCommand(Query, con);

                SqlDataAdapter Adap = new SqlDataAdapter(cmd);

                Adap.Fill(data);

                con.Close();
            }
            catch (Exception ex)
            {

            }

            return data;
        }
        DataSet getLichsuthibySubandTS()
        {
            DataSet data = new DataSet();

            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);

                con.Open();
                string query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON, LOP.TENLOP FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH JOIN LOP ON LOP.MALOP = THISINHX.MALOP WHERE KETQUA.MAMON = @MAMON AND KETQUA.MATHISINH = @MATHISINH";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@MAMON", Convert.ToInt32(cmbSub.SelectedIndex.ToString()));
                    command.Parameters.AddWithValue("@MATHISINH", txtCodeSV.Text.Trim());
                    SqlDataAdapter Adap = new SqlDataAdapter(command);

                    Adap.Fill(data);
                    // Tiếp tục thực hiện các thao tác khác với câu truy vấn...
                }

               

                con.Close();
            }
            catch (Exception ex)
            {

            }

            return data;
        }


        DataSet getLichsuthibyLopandTS()
        {
            DataSet data = new DataSet();

            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);

                con.Open();

                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON, LOP.TENLOP FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH JOIN LOP ON LOP.MALOP = THISINHX.MALOP  AND   LOP.MALOP =" + Convert.ToInt32(cmbLop.SelectedItem.ToString()) + " AND KETQUA.MATHISINH=" + txtCodeSV.Text.Trim();
                SqlCommand cmd = new SqlCommand(Query, con);

                SqlDataAdapter Adap = new SqlDataAdapter(cmd);

                Adap.Fill(data);

                con.Close();
            }
            catch (Exception ex)
            {

            }

            return data;
        }

        DataSet getLichsuthiAll()
        {
            DataSet data = new DataSet();

            try
            {

                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);

                con.Open();

                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON, LOP.TENLOP FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH JOIN LOP ON LOP.MALOP = THISINHX.MALOP  AND   LOP.MALOP =" + Convert.ToInt32(cmbLop.SelectedIndex.ToString()) + " AND KETQUA.MATHISINH=" + txtCodeSV.Text.Trim() + " AND  KETQUA.MAMON = " + Convert.ToInt32(cmbSub.SelectedIndex.ToString());
                SqlCommand cmd = new SqlCommand(Query, con);

                SqlDataAdapter Adap = new SqlDataAdapter(cmd);

                Adap.Fill(data);

                con.Close();
            }
            catch (Exception ex)
            {

            }

            return data;
        }



        private void FormHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataSource = getLichsuthi().Tables[0];
            getALLMon();
            getALLLop();
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
            cmbSub.DataSource = null;
            cmbSub.Items.Clear();
            // Tạo một danh sách mới từ DataSource hiện tại của ComboBox
            List<object> items = new List<object>();

            // Thêm giá trị "Tất cả" vào danh sách mục
            items.Insert(0, "Tất cả");
            foreach (DataRow row in data.Rows)
            {
                string tenMon = row["TENMON"].ToString();
                int maMon = Convert.ToInt32(row["MAMON"].ToString()); ;
                // Hiển thị giá trị hoặc thực hiện các thao tác khác tùy vào nhu cầu
                items.Insert(maMon, tenMon);
            }
            // Thiết lập lại DataSource cho ComboBox
            cmbSub.DataSource = items;

            // Đặt giá trị mặc định là "Tất cả"
            cmbSub.SelectedIndex = 0;
            r.Close();
            con2.Close();
        }

        private void getALLLop()
        {
            DataTable data = new DataTable();


            SqlConnection con2 = new SqlConnection(DataProvider.sqlConnection);
            con2.Open();
            SqlCommand cmd = new SqlCommand("SELECT MALOP, TENLOP FROM LOP", con2);
            SqlDataReader r = cmd.ExecuteReader();
            data.Load(r);
            
            cmbLop.DisplayMember = "TENLOP";
            cmbLop.ValueMember = "MALOP";
            cmbLop.DataSource = null;
            cmbLop.Items.Clear();
            // Tạo một danh sách mới từ DataSource hiện tại của ComboBox
            List<object> items = new List<object>();

            // Thêm giá trị "Tất cả" vào danh sách mục
            items.Insert(0, "Tất cả");
            foreach (DataRow row in data.Rows)
            {
                string tenLop = row["TENLOP"].ToString();
                int maLop = Convert.ToInt32( row["MALOP"].ToString()); ;
                // Hiển thị giá trị hoặc thực hiện các thao tác khác tùy vào nhu cầu
                items.Insert(maLop, tenLop);
            }
            // Thiết lập lại DataSource cho ComboBox
            cmbLop.DataSource = items;
            // Đặt giá trị mặc định là "Tất cả"
            cmbLop.SelectedIndex = 0;
            r.Close();
            con2.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(txtCodeSV.Text))
            {
                MessageBox.Show(txtCodeSV.Text);
                if((Convert.ToInt32(cmbSub.SelectedIndex.ToString()) == 0)&& (Convert.ToInt32(cmbLop.SelectedIndex.ToString()) == 0))
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DataSource = getLichsuthibyCOD().Tables[0];

                }
                else if((Convert.ToInt32(cmbSub.SelectedIndex.ToString()) != 0) && (Convert.ToInt32(cmbLop.SelectedIndex.ToString()) == 0))
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    if(getLichsuthibySubandTS().Tables.Count > 0)
                    {
                        dataGridView1.DataSource = getLichsuthibySubandTS().Tables[0];

                    }
                    else { dataGridView1.DataSource = null; }
                }

                else if((Convert.ToInt32(cmbSub.SelectedIndex.ToString()) == 0) && (Convert.ToInt32(cmbLop.SelectedIndex.ToString()) != 0))
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    if (getLichsuthibyLopandTS().Tables.Count > 0)
                    {
                        dataGridView1.DataSource = getLichsuthibyLopandTS().Tables[0];

                    }
                    else { dataGridView1.DataSource = null; }
                }
                else if ((Convert.ToInt32(cmbSub.SelectedIndex.ToString()) != 0) && (Convert.ToInt32(cmbLop.SelectedIndex.ToString()) != 0))
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    if (getLichsuthiAll().Tables.Count > 0)
                    {
                        dataGridView1.DataSource = getLichsuthiAll().Tables[0];

                    }
                    else { dataGridView1.DataSource = null; }
                }

            }
            else
            {
                if  ((Convert.ToInt32(cmbSub.SelectedIndex.ToString()) == 0) && (Convert.ToInt32(cmbLop.SelectedIndex.ToString()) == 0))
                    {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DataSource = getLichsuthi().Tables[0];

                }
                else if((Convert.ToInt32(cmbSub.SelectedIndex.ToString()) != 0) && (Convert.ToInt32(cmbLop.SelectedIndex.ToString()) == 0))
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DataSource = getLichsuthibySub().Tables[0];
                }
                else if ((Convert.ToInt32(cmbSub.SelectedIndex.ToString()) == 0) && (Convert.ToInt32(cmbLop.SelectedIndex.ToString()) != 0))
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DataSource = getLichsuthibyLop().Tables[0];
                }
                else if ((Convert.ToInt32(cmbSub.SelectedIndex.ToString()) != 0) && (Convert.ToInt32(cmbLop.SelectedIndex.ToString()) != 0))
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DataSource = getLichsuthibyLopandSub().Tables[0];
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
