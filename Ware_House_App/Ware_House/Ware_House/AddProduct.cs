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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public static ListViewItem lvitem;

        public static int check = 0;

        XmlSerializer Saveproducts = new XmlSerializer(typeof(Product_DB));

        private void savebtn_Click(object sender, EventArgs e)
        {

            try
            {
                bool check2 = false;
                Product newproduct = new Product() { Name = txtproductname.Text, Price = Double.Parse(textproductprice.Text), Quantity = numprodquantity.Value, Description = textproductdesc.Text };

                if (txtproductname.Text != "" && textproductprice.Text != "" && !textproductprice.Text.Contains('.') && numprodquantity.Text != "" && numprodquantity.Text != "" && textproductdesc.Text != "" && Double.Parse(textproductprice.Text)>0)
                {
                    foreach(var item in Form1.products.products)
                    {
                        if (item.Name==newproduct.Name)
                        {
                            item.Price = newproduct.Price;
                            item.Quantity += newproduct.Quantity;
                            item.Description=newproduct.Description;
                            check2 = true;
                        }
                    }
                    if (!check2)
                    {
                        Form1.products.products.Add(newproduct);
                        lvitem = new ListViewItem(newproduct.Name);
                        lvitem.SubItems.Add(newproduct.Price.ToString());
                        lvitem.SubItems.Add(newproduct.Quantity.ToString());
                        lvitem.SubItems.Add(newproduct.Description);
                        check++;
                    }
                    this.Close();
                }

                else
                    MessageBox.Show("All fields must be filled correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (Stream fStream = File.Create("../../../../products.xml"))

                {
                    Saveproducts.Serialize(fStream, Form1.products);
                }
                    
            }

            catch (FormatException )
            { MessageBox.Show("Fields not filled correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }

    }
