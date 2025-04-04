using System.Numerics;

namespace Práctica_2._3
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            f_num = float.Parse(textBox1.Text);
            Total += f_num;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
