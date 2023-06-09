using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ware_House
{
    public partial class AddOrder : Form
    {

        public static ListViewItem lvitem;

        public static int check = 0;

        public static string login;

        XmlSerializer Saveusers = new XmlSerializer(typeof(Users_DB));

        XmlSerializer Saveproducts = new XmlSerializer(typeof(Product_DB));


        public AddOrder()
        {
            InitializeComponent();

            foreach(var item in Form1.products.products)
            {

                comboBoxproduct.Items.Add(item.Name);
            }

            foreach (var item in Form1.users.users)
            {
                foreach(var i in item.clients)
                {
                    if (item.Login==AddClient.login)
                    comboBoxname.Items.Add(i.Name);
                }

              
            }



        }

    
        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            bool check2 = false;

            Order order = new Order() { Name = comboBoxname.Text, Product = comboBoxproduct.Text, DateTime = dateTimePickerorder.Value, Quantity = numorderquantity.Value };

            if (comboBoxname.Text != "" && comboBoxproduct.Text != "" && dateTimePickerorder.Text != "" && numorderquantity.Text != "" && dateTimePickerorder.Value>=DateTime.Now)
            {
                foreach (var item in Form1.products.products)
                {
                    if (item.Name == order.Product)
                    {
                        if (order.Quantity <= item.Quantity)
                        {
                            item.Quantity -= order.Quantity;
                            check++;
                            check2 = true;
                            this.Close();
                        }

                        else
                            MessageBox.Show($"There is no such quantity of item in stock\n In Stock {item.Quantity} items ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                if (check2 == true)
                {
                    foreach (var item in Form1.users.users)
                    {
                        if (item.Login == login)
                        {
                            item.orders.Add(order);
                        }
                    }
                    lvitem = new ListViewItem(order.Name);
                    lvitem.SubItems.Add(order.Product);
                    lvitem.SubItems.Add(order.Quantity.ToString());
                    lvitem.SubItems.Add(order.DateTime.ToShortDateString());
                    check2 = false;

                    this.Close();
                }

            }


            else
                MessageBox.Show("All fields must be filled correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


   


            using (Stream fStream = File.Create("../../../../products.xml"))

            {
                Saveproducts.Serialize(fStream, Form1.products);
            }

            using (Stream fStream = File.Create("../../../../users.xml"))
            {
                Saveusers.Serialize(fStream, Form1.users);
            }


        }
    }
}
