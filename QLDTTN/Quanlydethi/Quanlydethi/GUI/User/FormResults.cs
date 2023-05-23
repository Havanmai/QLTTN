using Quanlydethi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlydethi.GUI.User
{
    public partial class FormResults : Form
    {
        int Scaudung, ScauSai;
        float Diem;
        String MaTS;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            lblPoint.Text = Diem.ToString() + "/100";
            lblTrue.Text = Scaudung.ToString();
            lblFalse.Text = ScauSai.ToString();
            LuuKetquathi();
        }

        public FormResults(int Socaudung, int Socausai, float diem, String Mats)
        {
            InitializeComponent();
            Scaudung = Socaudung;
            ScauSai = Socausai;
            Diem = diem;
            MaTS = Mats;
        }

        private void LuuKetquathi()
        {
            try
            {
                SqlConnection con = new SqlConnection(DataProvider.sqlConnection);
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "INSERT_KQ";
                String ngaythi = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
                //Bắt đầu Insert Nè
                cmd.Parameters.Add(new SqlParameter("@sMATHISINH", MaTS));
                cmd.Parameters.Add(new SqlParameter("@sNGAYTHI", ngaythi));
                cmd.Parameters.Add(new SqlParameter("@sSOCAUDUNG", Scaudung));
                cmd.Parameters.Add(new SqlParameter("@sSOCAUSAI", ScauSai));
                cmd.Parameters.Add(new SqlParameter("@sDIEM", Diem));
                cmd.Parameters.Add(new SqlParameter("@iMAMON", 1));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi dữ liệu sẽ không được lưu" + e);
            }

        }
    }
}
