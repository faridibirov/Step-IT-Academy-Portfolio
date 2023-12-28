namespace Task1
{
    public partial class Form1 : Form
    {
        string ms1 = "Name: Farid\nSurname: Dibirov\nAge: 26";
        string ms2 = "Country: Azerbaijan\nCity: Baku\n";
        string ms3 = "Education: Step IT\n";
        string ms4 = "Skills: C#, C++, Python\n";


        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(ms1, "CV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(ms2, "CV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(ms3, "CV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(ms4, $"Avarage number of symbols: {(double)(ms1.Length + ms2.Length + ms3.Length + ms4.Length) / 4}", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       
            
        
    }
}