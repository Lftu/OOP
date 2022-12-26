using System.Security.Cryptography.X509Certificates;

namespace yehor
{
    public partial class Form1 : Form
    {

        string num;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            num = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  string message = textBox1.Text;
            //Console.WriteLine(message);
            MessageBox.Show("Your entered number: " + num);
        }
    }
}