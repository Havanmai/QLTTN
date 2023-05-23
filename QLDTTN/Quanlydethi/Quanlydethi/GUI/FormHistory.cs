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

                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH; ";
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

                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH AND KETQUA.MATHISINH=" + txtCodeSV.Text.Trim();
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

                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH AND KETQUA.MAMON=" + Convert.ToInt32(cmbLop.SelectedItem);
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

                String Query = "SELECT KETQUA.STT, KETQUA.MATHISINH, THISINHX.HOTENTHISINH, KETQUA.NGAYTHI, KETQUA.SOCAUDUNG, KETQUA.SOCAUSAI, KETQUA.DIEM, MONHOC.TENMON FROM KETQUA JOIN MONHOC ON KETQUA.MAMON = MONHOC.MAMON JOIN THISINHX ON KETQUA.MATHISINH = THISINHX.MATHISINH AND   KETQUA.MAMON=" + Convert.ToInt32(cmbLop.SelectedItem)+ " AND KETQUA.MATHISINH=" + txtCodeSV.Text.Trim();
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
        }

        private void getALLMon()
        {
            DataTable data = new DataTable();


            SqlConnection con2 = new SqlConnection(DataProvider.sqlConnection);
            con2.Open();
            SqlCommand cmd = new SqlCommand("SELECT MAMON, TENMON FROM MONHOC", con2);
            SqlDataReader r = cmd.ExecuteReader();
            data.Load(r);
            cmbLop.DisplayMember = "TENMON";
            cmbLop.ValueMember = "MAMON";
            cmbLop.DataSource = data;
            r.Close();
            con2.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCodeSV.Text.Trim() != null)
            {
                if(cmbLop.SelectedItem == null)
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DataSource = getLichsuthibyCOD().Tables[0];

                }
                else
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    if(getLichsuthibySubandTS().Tables.Count > 0)
                    {
                        dataGridView1.DataSource = getLichsuthibySubandTS().Tables[0];

                    }
                    else { dataGridView1.DataSource = null; }
                }


            }
            else
            {
                if (cmbLop.SelectedItem == null)
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DataSource = getLichsuthi().Tables[0];

                }
                else
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DataSource = getLichsuthibySub().Tables[0];
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
