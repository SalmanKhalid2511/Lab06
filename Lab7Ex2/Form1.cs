namespace Lab7Ex2
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double result;
        public Form1()
        {
            InitializeComponent();
            Buttons();
            num1 = int.MinValue;
            result = 0;

        }
        public void Buttons()
        {
            int x = 94;
            int y = 81;
            int k = 0;
            string[] buttons = { "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", "0", "C" };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Text = buttons[k];
                    button.Location = new Point(x, y);
                    button.Size = new Size(64, 40);
                    button.Visible = true;
                    button.UseVisualStyleBackColor = true;
                    x += 100;
                    button.Click += click;
                    this.Controls.Add(button);
                    k++;
                }
                x = 94;
                y += 70;

            }
            k = 0;

        }
        public void click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text = null;
            textBox1.Text = b.Text;

            if (num1 == int.MinValue)
            {
                num1 = int.Parse(b.Text);
                num2 = 0;
            }
            else
            {
                num2 = int.Parse(b.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = num1 + num2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = num1 - num2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = num1 * num2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = num1 / num2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = result.ToString();
        }
    }
}
