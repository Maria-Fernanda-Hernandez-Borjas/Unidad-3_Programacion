namespace Práctica_2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            if (numero % 2 == 0)
            {
                listBox1.Items.Add(numero + "  Par");
            }
            else {
                listBox1.Items.Add(numero + "  impar");
            }
            textBox1.Text = "  ";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
