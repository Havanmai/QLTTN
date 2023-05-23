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
    public partial class FormSub : Form
    {
        public FormSub()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataSource = GetData().Tables[0];

        }

        private DataSet GetData()
        {
            DataSet data = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();
                String Query = "SELECT MAMON, TENMON FROM MONHOC";
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
    }
}
