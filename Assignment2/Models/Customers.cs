using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Customers
    {
        public SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public Customers()
        {
            builder.DataSource = @"5CG05206QS\SQLEXPRESS";
            builder.InitialCatalog = "Chinook";
            builder.IntegratedSecurity = true;
        }
        public void GetCustomers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine(builder.ConnectionString);
                    Console.WriteLine("Connection established :D. \n");

                    string query = "SELECT CustomerId, FirstName, LastName, Country, PostalCode, Phone, Email FROM Customer";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine($"{reader.GetName(0)} " +
                                $"{reader.GetName(1)} " +
                                $"{reader.GetName(2)} " +
                                $"{reader.GetName(3)} " +
                                $"{reader.GetName(4)} " +
                                $"{reader.GetName(5)} " +
                                $"{reader.GetName(6)} ");

                            Console.WriteLine("--------------------------------");

                            try
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine($"" +
                                        $"{reader.GetInt32(0)}  " +
                                        $"{reader.GetString(1)} " +
                                        $"{reader.GetString(2)} " +
                                        $"{reader.GetString(3)} " +
                                        $"{reader.GetString(4)} " +
                                        $"{reader.GetString(5)} " +
                                        $"{reader.GetString(6)} "
                                        );                      
                                }

                                Console.WriteLine("----------------------------------");

                                Console.WriteLine(reader.FieldCount);
                                Console.WriteLine(reader.IsClosed);
                                Console.WriteLine(reader.VisibleFieldCount);
                                Console.WriteLine(reader.GetName(2));
                                Console.WriteLine(reader.GetDataTypeName(0));

                            }
                            catch (Exception ex)
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
