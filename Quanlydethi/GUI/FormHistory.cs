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

                String Query = "SELECT * FROM KETQUA";
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
        }
    }
}
