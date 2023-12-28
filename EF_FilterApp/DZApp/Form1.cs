namespace DZApp
{
    public partial class Form1 : Form
    {
        List<string> filters = new List<string>() { "Authors", "Themes", "Categories" };

        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = filters;
            comboBox1.SelectedItem = null;
            listBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new LibraryContext())
            {
                var authors = db.Authors.ToList();
                var themes = db.Themes.ToList();
                var categories = db.Categories.ToList();
                comboBox2.SelectedItem = null;
                if (comboBox1.SelectedIndex == 0)
                    comboBox2.DataSource = authors;
                if (comboBox1.SelectedIndex == 1)
                    comboBox2.DataSource = themes;
                if (comboBox1.SelectedIndex == 2)
                    comboBox2.DataSource = categories;

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            using (var db = new LibraryContext())
            {
                string Name = comboBox2.Text.Split(' ')[0];

                var authors = db.Authors.Where(c => c.FirstName.Contains(Name)).Select(a => new
                {
                    Books = a.Books
                }).ToList();

                foreach (var author in authors)
                {
                    foreach (var book in author.Books)
                    {
                        listBox1.Items.Add(book);
                    }
                }


                var themes = db.Themes.Where(c => c.Name.Equals(comboBox2.Text)).Select(a => new
                {
                    Books = a.Books
                }).ToList();

                foreach (var theme in themes)
                {
                    foreach (var book in theme.Books)
                    {
                        listBox1.Items.Add(book);
                    }
                }


                var categories = db.Categories.Where(c => c.Name.Equals(comboBox2.Text)).Select(a => new
                {
                    Books = a.Books
                }).ToList();

                foreach (var category in categories)
                {
                    foreach (var book in category.Books)
                    {
                        listBox1.Items.Add(book);
                    }
                }

            }
        }
    }
}