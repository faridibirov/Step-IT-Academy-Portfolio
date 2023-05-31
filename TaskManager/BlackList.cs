using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class BlackList : Form
    {
       static public List<string> bl = new List<string>();

        public BlackList()
        {
            InitializeComponent();


            foreach (string item in bl)
            {
                listBoxBL.Items.Add(item);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.Clear();
            listBoxBL.Items.Add(textBoxBL.Text);
            textBoxBL.Text = "";
            foreach (string item in listBoxBL.Items)
            {
                bl.Add(item);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxBL.Items.Remove(listBoxBL.Items[listBoxBL.SelectedIndex]);
            bl.Clear();
            foreach (string item in listBoxBL.Items)
            {
                bl.Add(item);
            }
        }
    }
}
