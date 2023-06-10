namespace Task1
{
    public partial class Form1 : Form
    {
        Point start;
        Point end;
        int tries = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
            int x;
            int y;
            end= e.Location;

            if (start.X < end.X)
            {
                x = start.X;
            }
            else
            {
                x = end.X;
            }

            if (start.Y < end.Y)
            {
                y = start.Y;
            }
            else
            {
                y = end.Y;
            }

            Label label = new Label();
            label.BackColor = Color.DarkGreen;
            label.ForeColor = Color.White;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Text = $"{tries}";
            label.Location = new Point(x, y);
            label.Size = new Size((int)(end.X - start.X), (int)(end.Y - start.Y));
            if (label.Size.Width < 10 && label.Size.Height < 10) MessageBox.Show("Minimum size should be 10x10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Controls.Add(label);
                tries++;
            }
            label.MouseDoubleClick += Label_MouseDoubleClick;
            label.MouseClick += Label_MouseClick;
        }

        private void Label_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
               foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                        MessageBox.Show($"Square: {item.Width * item.Height}\nNumber: {item.Text}\nCoordinates: X= {item.Location.X} and Y={item.Location.Y}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Label_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int t = tries;
            if (e.Button == MouseButtons.Left)
            {
                foreach(Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        if (t > Convert.ToInt32(item.Text))
                            t = Convert.ToInt32(item.Text);
                    }
                }

                foreach (Label item in Controls)
                {

                    if (t == Convert.ToInt32(item.Text))
                        Controls.Remove(item);
                }
            }


        }

        
    }
}