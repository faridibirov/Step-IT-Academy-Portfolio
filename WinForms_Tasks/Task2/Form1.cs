namespace Task2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            int count = 1;
            while (true)
            {
              var res =   MessageBox.Show($"Your number is {random.Next(1, 100)}", "True?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                   var res2 =  MessageBox.Show("Do you want to play again?", $"Tries: {count}", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (res2 == DialogResult.No)
                        break;
                    else count = 0;
                }

                count++;
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}