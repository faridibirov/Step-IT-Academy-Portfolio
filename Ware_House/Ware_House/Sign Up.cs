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
    public partial class Sign_Up : Form
    {


        XmlSerializer Saveusers = new XmlSerializer(typeof(Users_DB));


        public Sign_Up()
        {
            InitializeComponent();

            using (Stream fStream = File.OpenRead("../../../../users.xml"))
            {
                Form1.users = (Users_DB)Saveusers.Deserialize(fStream);
            }
        }



        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text != "" && textpassword.Text != "" && textrepassword.Text != "" && textsurname.Text != "" && textname.Text != "")
            {
                int check = 0;
                foreach (var item in Form1.users.users)
                {
                    if (txtlogin.Text == item.Login)
                    {
                        MessageBox.Show($"User {txtlogin.Text} already exists, Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Thread.Sleep(1500);
                        check++;
                    }

                }

                if (textpassword.Text != textrepassword.Text)
                {
                    MessageBox.Show("Those passwords didn't match. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check++;
                }

                if (check == 0)
                {
                    Form1.users.users.Add(new User() { Login = txtlogin.Text, Password = textpassword.Text, Name = textname.Text, Surname = textsurname.Text });


                    using (Stream fStream = File.Create("../../../../users.xml"))
                    {
                        Saveusers.Serialize(fStream, Form1.users);
                    }
                    this.Close();
                }
            }

            else
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

     


            private void button_MouseDown(object sender, EventArgs e)
            {
                textpassword.UseSystemPasswordChar = false;
                textrepassword.UseSystemPasswordChar = false;
            }

            private void button_MouseUp(object sender, EventArgs e)
            {
                textpassword.UseSystemPasswordChar = true;
                textrepassword.UseSystemPasswordChar = true;
            }


        }


    }


