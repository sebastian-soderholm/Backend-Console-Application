using Microsoft.Data.SqlClient;
using System;


namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"5CG05206QS\SQLEXPRESS";
            builder.InitialCatalog = "Chinook";
            builder.IntegratedSecurity = true;

            Console.WriteLine(builder.ConnectionString);

            
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection established :D. \n");

                    string query = "SELECT * FROM Artist";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine($"{reader.GetName(0)} \t {reader.GetName(1)}");
                            Console.WriteLine("--------------------------------");

                            try
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine($"{reader.GetInt32(0)} \t {reader.GetString(1)}");
                                }

                                Console.WriteLine("----------------------------------");

                                Console.WriteLine(reader.FieldCount);
                                Console.WriteLine(reader.IsClosed);
                                Console.WriteLine(reader.VisibleFieldCount);
                                Console.WriteLine(reader.GetName(2));
                                Console.WriteLine(reader.GetDataTypeName(0));
                                
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine("This is fine :D");
                            }
                                

                        }
                    }


                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }






        }
    }
}
