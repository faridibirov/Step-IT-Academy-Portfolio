using System.Xml.Serialization;

namespace ColorApp
{
    public partial class Form1 : Form
    {
        Sign_Up signup = null;
        byte red = 0;
        byte green = 0;
        byte blue = 0;


        public static Users_DB users = new Users_DB();

        XmlSerializer Saveusers = new XmlSerializer(typeof(Users_DB));
        public Form1()
        {
            InitializeComponent();

            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    comboBoxcolor.Items.Add(prop.Name);
            }

            panelmenu.Hide();
            panelcolorlist.Hide();
            panelsignin.Show();
            panelsignin.Dock = DockStyle.Fill;
            this.Width = 315;
            this.Height = 220;

            using (Stream fStream = File.OpenRead("../../../../users.xml"))
            {
                users = (Users_DB)Saveusers.Deserialize(fStream);
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (signup != null) signup.Close();
            signup = new Sign_Up ();
            signup.ShowDialog();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (var item in users.users)
            {
                if (signinlogintext.Text == item.Login && signinpasstext.Text==item.Password)
                {
                    panelsignin.Hide();
                    panelmenu.Dock = DockStyle.Fill;
                    panelmenu.Show();
                    this.Width = 404;
                    this.Height = 480;
                    check++;
                }

            }

            if (check == 0) 

            {
                MessageBox.Show("Wrong login or password. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void colorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelmenu.Hide();
            panelcolorlist.Dock = DockStyle.Fill;
            panelcolorlist.Show();
            this.Width = 350;
            this.Height = 320;
        }

        private void trackBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelcolorlist.Hide();
            panelmenu.Show();
            panelmenu.Dock = DockStyle.Fill;
            this.Width = 404;
            this.Height = 480;
        }



        private void comboBoxcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color c = Color.FromName(comboBoxcolor.SelectedItem.ToString());

            showcolor.BackColor = c;
            if (c.R <= 16)
                textBoxhex.Text = $"#0{c.R.ToString("X")}{c.G.ToString("X")}{c.B.ToString("X")}";
            if (c.G <= 16)
                textBoxhex.Text = $"#{c.R.ToString("X")}0{c.G.ToString("X")}{c.B.ToString("X")}";
            if (c.B <= 16)
                textBoxhex.Text = $"#{c.R.ToString("X")}{c.G.ToString("X")}0{c.B.ToString("X")}";
            else textBoxhex.Text = $"#{c.R.ToString("X")}{c.G.ToString("X")}{c.B.ToString("X")}";


            labelred.Text = $"Red: {c.R}";
            labelgreen.Text = $"Green: {c.G}";
            labelblue.Text = $"Blue: {c.B}";
        }


        private Color getRGBcolor(byte r, byte g, byte b)
        {
            return Color.FromArgb(r, g, b);
        }

        private void trackBarScroll(object sender, EventArgs e)
        {
            red = (byte)redtrackbar.Value;
            string redd = $"{red:X}";
            green = (byte)greentrackbar.Value;
            string greenn = $"{green:X}";
            blue = (byte)bluetrackbar.Value;
            string bluee = $"{blue:X}";
            labelcolor.BackColor = getRGBcolor(red, green, blue);
            if (red <= 16)
                textboxcode.Text = $"#0{redd}{greenn}{bluee}";
            if (green <= 16)
                textboxcode.Text = $"#{redd}0{greenn}{bluee}";
            if (blue <= 16)
                textboxcode.Text = $"#{redd}{greenn}0{bluee}";
            else textboxcode.Text = $"#{redd}{greenn}{bluee}";
            labelredd.Text = $"Red: {red} ";
            labelgreenn.Text = $"Green: {green}";
            labelbluee.Text = $"Blue: {blue}";
        }


        private void button_MouseDown(object sender, EventArgs e)
        {
            signinpasstext.UseSystemPasswordChar = false;
            
        }

        private void button_MouseUp(object sender, EventArgs e)
        {
            signinpasstext.UseSystemPasswordChar = true;
          
        }

    
    }
}