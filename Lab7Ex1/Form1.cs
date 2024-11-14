namespace Lab7Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(textboxNum1.Text);
            double n2 = int.Parse(textBoxNum2.Text);
            double result = n1 + n2;
            textBoxResult.Text = result.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(textboxNum1.Text);
            double n2 = int.Parse(textBoxNum2.Text);
            double result = n1 - n2;
            textBoxResult.Text = result.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(textboxNum1.Text);
            double n2 = int.Parse(textBoxNum2.Text);
            double result = n1 * n2;
            textBoxResult.Text = result.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(textboxNum1.Text);
            double n2 = int.Parse(textBoxNum2.Text);
            double result = n1 / n2;
            textBoxResult.Text = result.ToString();


        }
    }
}
