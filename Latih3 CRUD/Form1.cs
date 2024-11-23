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

        private void tampil_data()
        {
            SqlConnection con = konn.getConn();
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM TB_Siswa", con);
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

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tampil_data();
            clear();
        }

        private void insert_data()
        {
            SqlConnection con = konn.getConn();
            con.Open();

            string query = "INSERT INTO TB_Siswa (NIS, Nama, Jurusan, Gender) VALUES (@NIS, @Nama, @Jurusan, @Gender)";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@NIS", textBox1.Text);
            cmd.Parameters.AddWithValue("@Nama", textBox2.Text);
            cmd.Parameters.AddWithValue("@Jurusan", textBox3.Text);
            cmd.Parameters.AddWithValue("@Gender", textBox4.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Di Tambahkan");

            con.Close();
            clear();
            tampil_data();
        }

        private void delete_data()
        {
            SqlConnection con = konn.getConn();
            con.Open();

            string query = "DELETE FROM TB_Siswa Where NIS = @NIS";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@NIS", textBox1.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");

            con.Close();
            clear();
            tampil_data();
        }
        private void update_data()
        {
            SqlConnection con = konn.getConn();
            con.Open();

            string query = "UPDATE TB_Siswa set Nama = @Nama, Jurusan = @Jurusan, Gender = @Gender WHERE NIS = @NIS";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@NIS", textBox1.Text);
            cmd.Parameters.AddWithValue("@Nama", textBox2.Text);
            cmd.Parameters.AddWithValue("@Jurusan", textBox3.Text);
            cmd.Parameters.AddWithValue("@Gender", textBox4.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Di Update", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            clear();
            tampil_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Masukan Nis", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                delete_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text)
                )
            {
                MessageBox.Show("Data Belum Lengkap");
                return;
            }


            try
            {
                insert_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || 
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || 
                string.IsNullOrWhiteSpace(textBox4.Text) )
            {
                MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                update_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs args)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                textBox1.Text = selectedRow.Cells["NIS"].Value != null ? selectedRow.Cells["NIS"].Value.ToString() : "";
                textBox2.Text = selectedRow.Cells["Nama"].Value != null ? selectedRow.Cells["Nama"].Value.ToString() : "";
                textBox3.Text = selectedRow.Cells["Jurusan"].Value != null ? selectedRow.Cells["Jurusan"].Value.ToString() : "";
                textBox4.Text = selectedRow.Cells["Gender"].Value != null ? selectedRow.Cells["Gender"].Value.ToString() : "";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
