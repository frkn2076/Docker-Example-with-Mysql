using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DockerExample {
    class Program {
        static void Main(string[] args) {
            try {
                // Connect to SQL
                string connectionStr = @"server=localhost,3306;userid=root;password=toortoor;database=testdb";
                String query = "select * from MyTable";
                String output = string.Empty;
                using(MySqlConnection connection = new MySqlConnection(connectionStr)) {
                    
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read()) {
                        output = string.Concat(output, reader.GetString("Id"), " - ", reader.GetString("Name"), " ", reader.GetString("Surname"),"\n");
                    }

                    Console.Write(output);

                    connection.Close();
                }
            }
            catch(SqlException e) {
                Console.WriteLine(e.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
