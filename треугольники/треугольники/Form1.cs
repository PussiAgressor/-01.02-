using static System.Console;
namespace треугольники
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            bool flagA = double.TryParse(textBox1.Text, out double a);
            if (!flagA)
            {
                MessageBox.Show("Вы не ввели число");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;

            }
            bool flagB = double.TryParse(textBox2.Text, out double b);
            if (!flagB)
            {
                MessageBox.Show("Вы не ввели число");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;

            }
            bool flagC = double.TryParse(textBox3.Text, out double c);
            if (!flagC)
            {
                MessageBox.Show("Вы не ввели число");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;

            }
            if (a <= 0 || c <= 0 || b <= 0)
            {
                MessageBox.Show("Вы указали сторону, которая меньше либо равна 0!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }


            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("Одна сторона больше суммы двух других или равна ей!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }
            if (a > 1000000 || b > 1000000 || c > 1000000)
            {
                MessageBox.Show("Число слишкои большое!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }


            if (a == b & b == c)
            {
                label2.Text = "Равносторонний треугольник";
                return;

            }
            if (a == b || b == c || a == c)
            {
                label2.Text = "Равнобедренный треугольник";
                return;

            }
            if (a != b & b != c)
            {
                label2.Text = "Разносторонний треугольник";
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}