namespace Práctica_2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, cua, cub, zeta;
            for (i = 1; i <= 50; i++)
            {
                cua = i * i;
                cub = i * i * i;
                zeta = cua + cub;
                listBox1.Items.Add(i);
                listBox2.Items.Add(cua);
                listBox3.Items.Add(cub);
                listBox4.Items.Add(zeta);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
