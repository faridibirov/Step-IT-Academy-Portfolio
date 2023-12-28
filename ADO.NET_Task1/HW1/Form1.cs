using System.Data.SqlClient;



namespace HW1
{

    public partial class DataBase : Form
    {

        //public SqlConnection connection = new SqlConnection(@"Data Source = STHQ0116-08; User ID = admin; Password = admin; Initial Catalog = Library;");
        public SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-FARID; Integrated Security = True;   Initial Catalog = Library;");
        public SqlDataReader reader = null;

        string id;
        public void Show()
        {
            
            SqlCommand cmd = new(@"Select * From Authors", connection);

            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listView1.Items.Add($"{reader["Id"]}. {reader["FirstName"]} {reader["LastName"]}");
                    id = reader["Id"].ToString();
                }

            }

            finally
            {
                if (reader != null) reader.Close();
                if (connection != null) connection.Close();

            }
        }


        

        public DataBase()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int idd = Int32.Parse(id);

            string insertString = @$"insert into Authors (Id, FirstName, LastName)
                                    values('{++idd}', '{textBoxName.Text}', '{textBoxSurname.Text}')";



            SqlCommand command = new SqlCommand(insertString, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                textBoxName.Text = "";
                textBoxSurname.Text = "";

            }
            finally
            {
                if (connection != null)
                    connection.Close();
                listView1.Clear();
                Show();
            }
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            Show();
        }
    }
}

