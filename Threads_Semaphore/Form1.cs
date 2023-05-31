using System.Diagnostics.Metrics;
using System.Reflection;
using System.Windows.Forms;

namespace Threads_Semaphore
{
    public partial class Form1 : Form
    {

        Semaphore sema;
        List<Thread> threadsCreated;
        List<Thread> threadsWaiting;
        List<Thread> threadsWorking;
        int count;

        public Form1()
        {
         
            InitializeComponent();

            sema = new Semaphore(6, 6);
            threadsCreated = new List<Thread>();
            threadsWaiting = new List<Thread>();
            threadsWorking = new List<Thread>();
            count = 0;
            numericUpDown1.Value = 2;
        }

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                if (sema.WaitOne())
                {
                    Thread.Sleep(4000);
                    sema.Release();
                    threadsCreated.RemoveAt(0);
                    listBoxworking.Items.RemoveAt(0);
                    count--;
                }
                StartJob();
            }
            );
            threadsWorking.Add(thread);
            listBoxcreated.Items.Add(thread.ManagedThreadId);

        }


        private void StartJob()
        {
            if (count < numericUpDown1.Value && threadsWaiting.Count > 0)
            {
                Thread thread = threadsWaiting[0];
                threadsWaiting.Remove(thread);
                listBoxwaiting.Items.RemoveAt(0);
                threadsCreated.Add(thread);
                listBoxworking.Items.Add(thread.ManagedThreadId);
                count++;
                thread.Start();
            }
        }

        private void listBoxcreated_DoubleClick(object sender, EventArgs e)
        {
            Thread thread = threadsWorking[listBoxcreated.SelectedIndex];
            threadsWaiting.Add(thread);
            listBoxwaiting.Items.Add(thread.ManagedThreadId);
            threadsWorking.Remove(thread);
            listBoxcreated.Items.RemoveAt(listBoxcreated.SelectedIndex);
            StartJob();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            StartJob();
        }
    }
}