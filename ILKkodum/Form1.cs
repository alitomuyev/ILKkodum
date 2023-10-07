namespace ILKkodum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say1 = Convert.ToInt32(textBox1.Text);
            int say2 = Convert.ToInt32(textBox2.Text);

            if (comboBox1.Text == "+")
            {
                int c = say1 + say2;
                label3.Text = c.ToString();
            }
            else if (comboBox1.Text == "-")
            {
                int c = say1 - say2;
                label3.Text = c.ToString();
            }
            else if (comboBox1.Text == "/")
            {
                int c = say1 / say2;
                label3.Text = c.ToString();
            }

            else if (comboBox1.Text == "*")
            {
                int c = say1 * say2;
                label3.Text = c.ToString();
            }
            else
            {
                label3.Text = "Dogru deyil";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}