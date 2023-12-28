using System.Text;
using System.IO;
using System.ComponentModel;

namespace Copier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void buttonfrom_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

           textBoxfrom.Text = openFileDialog1.FileName;

        }

        private void buttonto_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;

            textBoxto.Text = openFileDialog2.FileName;
        }

        private void buttoncopy_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
  

                if (textBoxfrom.Text == "" || textBoxto.Text == "")
                {
                    MessageBox.Show("Please specify source and destination files.");
                    return;
                }

                if (!File.Exists(textBoxfrom.Text))
                {
                    MessageBox.Show("Source file does not exist.");
                    return;
                }


                progressBar1.Value = 0;
                FileStream sourceStream = new FileStream(textBoxfrom.Text, FileMode.Open, FileAccess.Read);
                FileStream destinationStream = new FileStream(textBoxto.Text, FileMode.Create, FileAccess.Write);

                byte[] buffer = new byte[4096];
                long totalBytes = sourceStream.Length;
                long bytesWritten = 0;
                int bytesRead;


                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                    bytesWritten += bytesRead;
                    int percentComplete = (int)((double)bytesWritten / totalBytes * 100);
                    progressBar1.Value+= percentComplete;
                    Thread.Sleep(100);
                   
                }

                sourceStream.Close();
                destinationStream.Close();
            });

            thread.Start();
           
        }


        }
    }
