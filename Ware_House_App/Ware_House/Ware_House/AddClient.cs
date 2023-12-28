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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        public  static ListViewItem lvitem;

        public static string login;

        public static int check = 0;

        XmlSerializer Saveusers = new XmlSerializer(typeof(Users_DB));
       

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (txtclientname.Text != "" && textclientsurname.Text != "" && textclientemail.Text != "" && maskedTextclientphone.Text != "" && maskedTextclientphone.Text.Length==18  && textclientaddress.Text != "")
            {
                Client newclient = new Client() { Name = txtclientname.Text, Surname = textclientsurname.Text, Email = textclientemail.Text, Phone = maskedTextclientphone.Text, Address = textclientaddress.Text };
                
                foreach ( var item in Form1.users.users)
                {
                    if (item.Login==login)
                    {
                        item.clients.Add(newclient);
                    }
                }


                lvitem = new ListViewItem(newclient.Name);
                lvitem.SubItems.Add(newclient.Surname);
                lvitem.SubItems.Add(newclient.Email);
                lvitem.SubItems.Add(newclient.Phone);
                lvitem.SubItems.Add(newclient.Address);

                using (Stream fStream = File.Create("../../../../users.xml"))
                {
                    Saveusers.Serialize(fStream, Form1.users);
                }

                check++;

                this.Close();
            }

            else
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
