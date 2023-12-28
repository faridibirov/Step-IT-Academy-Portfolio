namespace Notepad
{
    public partial class Form1 : Form
    {
        string filename = "";
        bool ischanged = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ischanged == true) Check();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    notepadtext.Text = sr.ReadToEnd();
                    sr.Close();
                }

            }
            filename = openFileDialog.FileName;
            this.Text = filename + " - Notepad";
            ischanged = false;
        }

        private void notepadtext_TextChanged(object sender, EventArgs e)
        {
            if (!ischanged)
            {
                ischanged = true;
                this.Text = this.Text.Insert(0, "*");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ischanged == true) Check();
            
                this.Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            notepadtext.Font = fontDialog.Font;


        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            notepadtext.ForeColor = colorDialog.Color;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saveas();
        }

        public void Saveas()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save as";
            save.Filter = "Text files(*.txt)|*.txt|All Files (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter wr = new StreamWriter(save.FileName))
                {
                    wr.Write(notepadtext.Text);
                }
            }
            filename = save.FileName;
            this.Text = filename + " - Notepad";
            ischanged = false;
        }


        public void Save()
        {
            using (StreamWriter wr = new StreamWriter(filename))
            {
                wr.Write(notepadtext.Text);
            }
            if (ischanged)
            {
                ischanged = false;
                this.Text = this.Text.Remove(0, 1);
            }
        }




        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer: Farid\nVersion: 1.0\nYear: 2022\n\nAll Rights Reserved ©", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                Saveas();
            }

            else
                Save();

        }



        public void Check()
        {
            var result = MessageBox.Show("Do you want to save changes?", "Save file", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                if (this.Text != "*Notepad")
                    Save();

                else Saveas();

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ischanged == true) Check();

                notepadtext.Text = "";
                filename = "";
                this.Text = "Notepad";
                ischanged = false;
            }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customizeToolStripMenuItem.Checked)
            notepadtext.Multiline = true;
            else notepadtext.Multiline=false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(ischanged==true) Check();
        }
    }
    }

