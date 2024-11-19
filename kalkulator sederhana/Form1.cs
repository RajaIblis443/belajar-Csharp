namespace kalkulator_sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lblHasil.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Di Isi");
            }
            else
            {

            int angka1, angka2, tambah;

            angka1 = int.Parse(this.textBox1.Text);
            angka2 = int.Parse(this.textBox2.Text);

            tambah = angka1 + angka2;

            this.lblHasil.Text = tambah.ToString();

            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblHasil_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Di Isi");
            }
            else { 
            int angka1, angka2, tambah;

            angka1 = int.Parse(this.textBox1.Text);
            angka2 = int.Parse(this.textBox2.Text);

            tambah = angka1 - angka2;

            this.lblHasil.Text = tambah.ToString();
        }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Di Isi");
            }
            else
            {
            int angka1, angka2, tambah;

            angka1 = int.Parse(this.textBox1.Text);
            angka2 = int.Parse(this.textBox2.Text);

            tambah = angka1 * angka2;

            this.lblHasil.Text = tambah.ToString();
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Di Isi");
            }
            else
            {
            int angka1, angka2, tambah;

            angka1 = int.Parse(this.textBox1.Text);
            angka2 = int.Parse(this.textBox2.Text);

            tambah = angka1 / angka2;

            this.lblHasil.Text = tambah.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.lblHasil.Text = "";
        }
    }
}
