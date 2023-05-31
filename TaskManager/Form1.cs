using System.Diagnostics;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        NewTask newtask = null;

        BlackList blacklist = null;


        public TaskManager()
        {
            InitializeComponent();

           

        }

        private void ShowProcess()
        {
           
            var processes = Process.GetProcesses().ToList();

            foreach (var proc in processes)
            {
                ListViewItem lv = new ListViewItem(proc.Id.ToString());
                lv.SubItems.Add(proc.ProcessName);
                lv.SubItems.Add(proc.Threads.Count.ToString());
                lv.SubItems.Add(proc.BasePriority.ToString());
                listViewData.Items.Add(lv);

             
            }
        }


        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonendtask_Click(object sender, EventArgs e)
        {

            try
            {
                var pr = Process.GetProcessById(Int32.Parse(listViewData.SelectedItems[0].Text));

                pr.Kill();

                listViewData.Items.Clear();

                ShowProcess();
            }

            catch (Exception)
            {
                MessageBox.Show("Task  cannot be closed at this time. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void buttonnewtask_Click(object sender, EventArgs e)
        {
            if (newtask != null) newtask.Close();
            newtask = new NewTask();
            newtask.ShowDialog();
        }

        private void buttonblist_Click(object sender, EventArgs e)
        {
            if (blacklist != null) blacklist.Close();
            blacklist = new BlackList();
            blacklist.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowProcess();

            var processes = Process.GetProcesses().ToList();

            foreach (var proc in processes)
            {
                if (BlackList.bl.Contains(proc.ProcessName.ToString()))
                {
                   proc.Kill();
                }
            }
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ShowProcess();
        }
    }
}