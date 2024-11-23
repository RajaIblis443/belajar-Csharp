using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Latih2_DB_CONNECT
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private Koneksi konn = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = konn.getConn();
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM TB_Siswa", con); // Perbaikan sintaks
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TB_Siswa");
                dataGridView1.DataSource = ds.Tables["TB_Siswa"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
