using System.Data.SqlClient;

namespace WDF_Vypis_z_DB
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbConsole;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Id,Col1,Col2,Col3 FROM Demo";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string[] row = new string[]
                            {
                                reader[0].ToString(),
                                reader[1].ToString(),
                                reader[2].ToString(),
                                reader[3].ToString(),
                                
                            };
                            ListViewItem item = new ListViewItem(row);
                            listView1.Items.Add(item);
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}