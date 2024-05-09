namespace Test3_24S
{
    public partial class Form1 : Form
    {
        double count;

        double sum;

        public Form1()
        {
            InitializeComponent();
        }
       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;

            sum += double.Parse(textBox1.Text);

            textBox2.Text = Convert.ToString(sum);

            textBox3.Text = Convert.ToString(count);

            textBox4.Text = $"= {string.Format("{0:0.00}", sum/count)}"; ;






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;

            sum = 0;

            textBox2.Text = " ";

            textBox3.Text = " ";

            textBox4.Text = " ";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
