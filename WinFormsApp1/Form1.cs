using System.CodeDom.Compiler;
using System.Collections.Generic;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = GenerateData();
            dataGridView1.DataSource = data;

            dataGridView1.Columns["No"].Width = 50;
            dataGridView1.Columns["Pembuat"].DefaultCellStyle.BackColor = Color.LightBlue;

        }

        private IEnumerable<Data> GenerateData()
        {
            var Buku = new Data
            {
                No  = 1,
                Nama = "Belajar Dengan Cepat",
                Pembuat = "Bagas",
            };

            var game = new Data
            {
                No = 2,
                Nama = "Game Pembuat Game",
                Pembuat = "Adit",
            };

            var data = new List<Data> { Buku, game };
            return data;
        }

    }
}
