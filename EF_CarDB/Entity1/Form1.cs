namespace Entity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttondelete.Enabled= false;
            buttonupdate.Enabled= false;
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (CarContext database = new CarContext())
                {
                    Car car = new()
                    {
                        Mark = textBoxmarka.Text,
                        Model = textBoxmodel.Text,
                        Year = Int32.Parse(textBoxyear.Text),
                        Number = textBoxnomer.Text,
                    };
                    database.Cars.Add(car);
                    database.SaveChanges();
                }


                textBoxmarka.Text = "";
                textBoxmodel.Text = "";
                textBoxyear.Text = "";
                textBoxnomer.Text = "";

                listViewData.Items.Clear();

                Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occured, Please check entered data and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show();

        }


        public void Show()
        {
            using (var db = new CarContext())
            {
                var cars = db.Cars.ToList();
                foreach (var car in cars)
                {
                    ListViewItem lv = new ListViewItem(car.Mark);
                    lv.SubItems.Add(car.Year.ToString());
                    lv.SubItems.Add(car.Number);
                    lv.SubItems.Add(car.Model);
                    listViewData.Items.Add(lv);
                }
            }
        }

        private void listViewData_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                using (var context = new CarContext())
                {
                    Car car = null;
                    car = context.Cars.FirstOrDefault(s => s.Mark == listViewData.SelectedItems[0].Text);

                    textBoxmodel.Text = car.Model;

                    textBoxmarka.Text = car.Mark;

                    textBoxnomer.Text = car.Number;

                    textBoxyear.Text = car.Year.ToString();

                }
            }
            catch (Exception ex)
            {

            }

            buttondelete.Enabled = true;
            buttonupdate.Enabled = true;
            buttoninsert.Enabled = false;
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = null;

                using (var database = new CarContext())
                {
                    car = database.Cars.FirstOrDefault(s => s.Mark == listViewData.SelectedItems[0].Text);
                    car.Model = textBoxmodel.Text;
                    car.Mark = textBoxmarka.Text;
                    car.Number = textBoxnomer.Text;
                    car.Year = Int32.Parse(textBoxyear.Text);
                    database.SaveChanges();
                }

                listViewData.Items.Clear();

                Show();

                textBoxmarka.Text = "";
                textBoxmodel.Text = "";
                textBoxyear.Text = "";
                textBoxnomer.Text = "";
                buttoninsert.Enabled = true;
                buttondelete.Enabled = false;
                buttonupdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, Please check entered data and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            using (var database = new CarContext())
            {
                database.Remove(database.Cars.FirstOrDefault(car => car.Mark == listViewData.SelectedItems[0].Text));
                database.SaveChanges();
            }

            listViewData.Items.Clear();

            Show();

            textBoxmarka.Text = "";
            textBoxmodel.Text = "";
            textBoxyear.Text = "";
            textBoxnomer.Text = "";
            buttoninsert.Enabled = true;
            buttondelete.Enabled = false;
            buttonupdate.Enabled = false;
        }
    }
}