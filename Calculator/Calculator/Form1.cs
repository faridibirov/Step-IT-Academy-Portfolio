namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (equallabel.Text != "=")
            number.Text += button.Text;

            else
            {
                number.Text = "";
                number1.Text = "";
                sign.Text = "";
                number2.Text = "";
                equallabel.Text = "";
                number.Text += button.Text;

            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            number1.Text = number.Text;
            number.Text = "";
            Button button = (Button)sender;
            sign.Text = button.Text;

        }

        private void equal_Click(object sender, EventArgs e)
        {
            number2.Text = number.Text;
            equallabel.Text = "=";

            if (sign.Text == "+")
                number.Text = $"{Double.Parse(number1.Text) + Double.Parse(number2.Text) }";

            if (sign.Text == "-")
                number.Text = $"{Double.Parse(number1.Text) - Double.Parse(number2.Text) }";

            if (sign.Text == "*")
                number.Text = $"{Double.Parse(number1.Text) * Double.Parse(number2.Text) }";

            if (sign.Text == "/")
            {
                if (number2.Text != "0")
                    number.Text = $"{Double.Parse(number1.Text) / Double.Parse(number2.Text) }";

                else
                    number.Text = "Error";
            }



        }

   

        private void percentage_Click(object sender, EventArgs e)
        {
            if (number1.Text!="" && sign.Text!="")
            {
                number2.Text = $"{(Double.Parse(number1.Text) * Double.Parse(number.Text))/100 }";
                number.Text = number2.Text;
            }
        }

        private void ce_Click(object sender, EventArgs e)
        {
            number.Text = "";

            if (equallabel.Text=="=")
            {
                number.Text = "";
                number1.Text = "";
                sign.Text = "";
                number2.Text = "";
                equallabel.Text = "";
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            number.Text = "";
            number1.Text = "";
            sign.Text = "";
            number2.Text = "";
            equallabel.Text = "";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            number.Text = Math.Sqrt(Double.Parse(number.Text)).ToString();
        }

        private void to2_Click(object sender, EventArgs e)
        {
           number.Text = Math.Pow(Double.Parse(number.Text), 2).ToString();
        }

        private void tominus_Click(object sender, EventArgs e)
        {
            

            if (number.Text[0] != '-')
            {
                number.Text = number.Text.Insert(0, "-");
            }

           else
            {
                number.Text = number.Text.Remove(0, 1);
            }

        }

        private void del1_Click(object sender, EventArgs e)
        {
            number.Text = (1/Double.Parse(number.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number.Text = number.Text.Remove(number.Text.Length-1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}