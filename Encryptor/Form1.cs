using System.Diagnostics;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        static CancellationTokenSource cts=null;
        CancellationToken token;


        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void buttonopen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            textBoxfrom.Text = openFileDialog1.FileName;
        }


        void Start (CancellationToken token)
        {

            try
            {
                cts = new CancellationTokenSource();
                token = cts.Token;

                string key = textBoxpass.Text;
                string outputText = "";


                string inputText = File.ReadAllText(openFileDialog1.FileName);

                progressBar1.Maximum = inputText.Length;

                for (int i = 0; i < inputText.Length; i++)
                {
                    token.ThrowIfCancellationRequested();
                    char c = (char)(inputText[i] ^ key[i % key.Length]);
                    outputText += c;
                    progressBar1.Value = i + 1;
                    Thread.Sleep(500);

                }

                File.WriteAllText(openFileDialog1.FileName, outputText);

            }
            catch (ArgumentException)
            {
                MessageBox.Show("File not chosen! Please choose the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           catch(OperationCanceledException)
            {
                MessageBox.Show("Operation was canceled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread thread = new Thread(() =>
                {
                    while (progressBar1.Value > 0)
                    {
                        progressBar1.Value--;
                        Thread.Sleep(500);
                    }
                    textBoxfrom.Text = String.Empty;
                    textBoxpass.Text = String.Empty;
                });
                thread.Start();
            }

        }


        private void buttonstart_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                
                Start(token);
   
            });

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            
        }
    }

}