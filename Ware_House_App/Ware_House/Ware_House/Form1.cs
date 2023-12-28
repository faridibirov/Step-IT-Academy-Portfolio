using System.Xml.Serialization;

namespace Ware_House
{
    public partial class Form1 : Form
    {
        Sign_Up signup = null;
        AddClient add = null;

        AddOrder order = null;

        AddProduct addprod = null;

        public static Users_DB users = new Users_DB();


        public static Product_DB products = new Product_DB();


        public static User user = new User();





        XmlSerializer Saveusers = new XmlSerializer(typeof(Users_DB));
        XmlSerializer Saveproducts = new XmlSerializer(typeof(Product_DB));


        public Form1()
        {
            InitializeComponent();

            panelmenu.Hide();
            panelsignin.Show();
            panelsignin.Dock = DockStyle.Fill;
            this.Width = 524;
            this.Height = 401;

      


            using (Stream fStream = File.OpenRead("../../../../users.xml"))
            {
                users = (Users_DB)Saveusers.Deserialize(fStream);
            }


            using (Stream fStream1 = File.OpenRead("../../../../products.xml"))
            {
                products = (Product_DB)Saveproducts.Deserialize(fStream1);
            }


        }


        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (signup != null) signup.Close();
            signup = new Sign_Up();
            signup.ShowDialog();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (var item in users.users)
            {
                if (signinlogintext.Text == item.Login && signinpasstext.Text == item.Password)
                {
                    panelsignin.Hide();
                    panelmenu.Dock = DockStyle.Fill;
                    panelmenu.Show();
                    this.Width = 816;
                    this.Height = 489;
                    AddClient.login = signinlogintext.Text;
                    AddOrder.login = signinlogintext.Text;

                    
                    foreach (var i in item.clients)
                    {
                        
                            ListViewItem lvitem = new ListViewItem(i.Name);
                            lvitem.SubItems.Add(i.Surname);
                            lvitem.SubItems.Add(i.Email);
                            lvitem.SubItems.Add(i.Phone);
                            lvitem.SubItems.Add(i.Address);
                            listViewclient.Items.Add(lvitem);
                        
                    }


                    foreach (var i in products.products)
                    {
                        ListViewItem lvitem = new ListViewItem(i.Name);
                        lvitem.SubItems.Add(i.Price.ToString());
                        lvitem.SubItems.Add(i.Quantity.ToString());
                        lvitem.SubItems.Add(i.Description);
                        listViewproduct.Items.Add(lvitem);
                    }

                    foreach (var i in item.orders)
                    {
                        ListViewItem lvitem = new ListViewItem(i.Name);
                        lvitem.SubItems.Add(i.Product.ToString());
                        lvitem.SubItems.Add(i.Quantity.ToString());
                        lvitem.SubItems.Add(i.DateTime.ToShortDateString());
                        listVieworder.Items.Add(lvitem);
                    }

                    check++;
                }
               
            }

            if (check == 0)

            {
                MessageBox.Show("Wrong login or password. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (add != null) add.Close();
            add = new AddClient();
            add.ShowDialog();

            if (AddClient.check != 0)
            {
                listViewclient.Items.Add(AddClient.lvitem);

                AddClient.check = 0;
            }

            listToolStripMenuItem_Click( sender,  e);

        }



        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            signinpasstext.UseSystemPasswordChar = false;

        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            signinpasstext.UseSystemPasswordChar = true;

        }

        public void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listViewproduct.Visible = false;
            listViewclient.Visible = true;
            panelsignin.Hide();
            panelorder.Hide();
            panelmenu.Dock = DockStyle.Fill;
            panelmenu.Show();
            this.Width = 816;
            this.Height = 489;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            { 

            panelmenu.Hide();
            panelorder.Hide();
            panelsignin.Show();
            panelsignin.Dock = DockStyle.Fill;
            this.Width = 524;
            this.Height = 401;

            listViewclient.Items.Clear();
            listVieworder.Items.Clear();
            listViewproduct.Items.Clear();

            signinlogintext.Text = "";
            signinpasstext.Text = "";
        }


        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close app ?", "Close app", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panelsignin.Hide();
            panelorder.Hide();
            panelmenu.Dock = DockStyle.Fill;
            panelmenu.Show();
            listViewclient.Visible = false;
            listViewproduct.Visible = true;
            listViewproduct.Dock = DockStyle.Fill;
            this.Width = 816;
            this.Height = 489;

            listViewproduct.Items.Clear();


            foreach (var i in products.products)
            {
                ListViewItem lvitem = new ListViewItem(i.Name);
                lvitem.SubItems.Add(i.Price.ToString());
                lvitem.SubItems.Add(i.Quantity.ToString());
                lvitem.SubItems.Add(i.Description);
                listViewproduct.Items.Add(lvitem);
            }


        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (addprod != null) addprod.Close();
            addprod = new AddProduct();
            addprod.ShowDialog();

            if (AddProduct.check != 0)
            {
                listViewproduct.Items.Add(AddProduct.lvitem);

                AddProduct.check = 0;
            }


            listViewproduct.Items.Clear();


            foreach (var i in products.products)
            {
                ListViewItem lvitem = new ListViewItem(i.Name);
                lvitem.SubItems.Add(i.Price.ToString());
                lvitem.SubItems.Add(i.Quantity.ToString());
                lvitem.SubItems.Add(i.Description);
                listViewproduct.Items.Add(lvitem);
            }

            listToolStripMenuItem2_Click(sender, e);


        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            panelmenu.Hide();
            panelsignin.Hide();
            panelorder.Show();
            panelorder.Dock = DockStyle.Fill;
            this.Width = 607;
            this.Height = 460;



        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            panelmenu.Hide();
            panelsignin.Hide();
            panelorder.Show();
            panelorder.Dock = DockStyle.Fill;
            this.Width = 607;
            this.Height = 460;

            if (order != null) order.Close();
            order = new AddOrder();
            order.ShowDialog();

            if (AddOrder.check != 0)
            {
                listVieworder.Items.Add(AddOrder.lvitem);
                AddOrder.check = 0;
            }
        }


      

        private void textBoxfilter_TextChanged(object sender, EventArgs e)
        {


            listVieworder.Items.Clear();

            foreach (var item in users.users)
            {
                foreach (var i in item.orders)
                {
                    if (item.Login == signinlogintext.Text)
                    {
                        if (i.Name.ToLower().Contains(textBoxfilter.Text.ToLower()) || i.Product.ToLower().Contains(textBoxfilter.Text.ToLower()))
                        {
                            ListViewItem lvitem = new ListViewItem(i.Name);
                            lvitem.SubItems.Add(i.Product.ToString());
                            lvitem.SubItems.Add(i.Quantity.ToString());
                            lvitem.SubItems.Add(i.DateTime.ToShortDateString());
                            listVieworder.Items.Add(lvitem);
                        }
                    }
                }
            }

        }
    }
}