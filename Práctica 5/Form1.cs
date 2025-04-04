namespace Práctica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textBox1.Text);
            float valor2 = float.Parse(textBox2.Text);

            float valor3 = (valor1 * valor2) / 2;

            textBox3.Text = valor3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
