
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Vypis_z_DB_Opakovani
{
    class SqlRepo
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbDemo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<string[]> LoadData()
        {
            List<string[]> data = new List<string[]>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "select IdDemo,Col1,Col2,Col3 from Demo";
                    sqlConnection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string[] row = new string[] { 
                                reader[0].ToString(), 
                                reader[1].ToString(), 
                                reader[2].ToString(), 
                                reader[3].ToString() 
                            };
                            data.Add(row);

                        }
                    }
                    sqlConnection.Close();
                }
            }
            return data;
        }
        
        public void DeleteItem(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"delete from Demo where IdDemo={id}";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateItem(Item item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"update Demo set IdDemo=@IdDemo ,Col1=@Col1,Col2=@Col2,Col3=@Col3 where IdDemo={item.Id}";
                    command.Parameters.AddWithValue("Col1", item.Col1);
                    command.Parameters.AddWithValue("Prijmeni", item.Col2);
                    command.Parameters.AddWithValue("DatumNarozeni", item.Col3);
                    command.ExecuteNonQuery();
                    
                }
                connection.Close();
            }
        }
    }
}
