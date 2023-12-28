using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyApp
{


    public partial class Form1 : Form
    {

        public static List<User> users = new List<User>();

        Sign_Up signup = null;

        public Form1()
        {
            InitializeComponent();

        }


        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (signup != null) signup.Close();
            signup = new Sign_Up();
            signup.ShowDialog();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("AppConfig.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("SqlConnectionString");

            SqlDataReader dataReader = null;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"select * from Users", connection);
                dataReader = cmd.ExecuteReader();
                do
                {
                    while (dataReader.Read())
                    {
                        users.Add(new User() { Login = dataReader[0].ToString(), Password = dataReader[1].ToString(), Name = dataReader[2].ToString(), Surname = dataReader[3].ToString() });
                    }
                   
                } while (dataReader.NextResult());

            }


            int check = 0;
            foreach (var item in users )
            {
                if (signinlogintext.Text == item.Login && signinpasstext.Text == item.Password)
                {
                    check++;
                }

            }


            if (check == 0)

            {
                MessageBox.Show("Wrong login or password. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }

            else
            {
            
                MessageBox.Show("You successfully logged in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                signinlogintext.Text = "";
                signinpasstext.Text = "";
            }
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            signinpasstext.UseSystemPasswordChar = false;

        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            signinpasstext.UseSystemPasswordChar = true;

        }


    }
}