using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace MyApp
{
    public partial class Sign_Up : Form
    {

        public Sign_Up()
        {


            InitializeComponent();

        }


        private void submitbtn_Click(object sender, EventArgs e)
        {

            if (txtlogin.Text != "" && textpassword.Text != "" && textrepassword.Text != "" && textsurname.Text != "" && textname.Text != "")
            {
                int check = 0;
                foreach (var item in Form1.users)
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

                    ConfigurationBuilder builder = new ConfigurationBuilder();
                    builder.SetBasePath(Directory.GetCurrentDirectory());
                    builder.AddJsonFile("appconfig.json");
                    var config = builder.Build();

                    var connectionString = config.GetConnectionString("SqlConnectionString");
                    SqlDataReader dataReader = null;

                    SqlConnection connection = null;
                    connection = new SqlConnection(connectionString);

                    var parlogin = txtlogin.Text;
                    var parpassword = textpassword.Text;
                    var parname = textname.Text;
                    var parsurname = textsurname.Text;

                    string insertString = @$"insert into Users (Login, Password, Name, Surname)
                                    values(@parlogin, @parpassword, @parname, @parsurname)";

                    SqlCommand command = new SqlCommand(insertString, connection);

                    command.Parameters.Add(new SqlParameter("@parlogin", System.Data.SqlDbType.NVarChar)).Value = parlogin;
                    command.Parameters.Add(new SqlParameter("@parpassword", System.Data.SqlDbType.NVarChar)).Value = parpassword;
                    command.Parameters.Add(new SqlParameter("@parname", System.Data.SqlDbType.NVarChar)).Value = parname;
                    command.Parameters.Add(new SqlParameter("@parsurname", System.Data.SqlDbType.NVarChar)).Value = parsurname;

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                    }
                    finally
                    {
                        if (connection != null)
                            connection.Close();
                    }
                }
                this.Close();
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



