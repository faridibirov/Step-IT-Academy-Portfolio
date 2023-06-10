namespace Farid2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Netbutton_MouseHover(object sender, EventArgs e)
        {
            Random x = new Random();
            Random y = new Random();

            Netbutton.Left = x.Next(0, this.Width - Netbutton.Width);
            Netbutton.Top = y.Next(0, this.Height - Netbutton.Height);

           
        }

        private void Dabutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы очень рады!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}