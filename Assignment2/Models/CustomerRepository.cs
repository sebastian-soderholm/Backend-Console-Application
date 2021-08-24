using Assignment2.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CustomerRepository : ICustomerRepository
    {
        public SqlConnectionStringBuilder Builder = new SqlConnectionStringBuilder();
        public Customer Customer;

        public CustomerRepository()
        {
            Builder.DataSource = @"5CG05206QS\SQLEXPRESS";
            Builder.InitialCatalog = "Chinook";
            Builder.IntegratedSecurity = true;
        }

        public CustomerRepository(string dataSource, string initialCatalog, bool integratedSecurity)
        {
            Builder.DataSource = "@" + dataSource;
            Builder.InitialCatalog = initialCatalog;
            Builder.IntegratedSecurity = integratedSecurity;
        }

        public void AddCustomer(Customer addCustomer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customerToReturn = new List<Customer>();
            
            try
            {
                using (SqlConnection connection = new SqlConnection(Builder.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT CustomerId, FirstName, LastName, Country, PostalCode, Phone, Email FROM Customer";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                while (reader.Read())
                                {
                                    Customer customerFromDB = new Customer(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetString(5),
                                    reader.GetString(6)
                                    );

                                    customerToReturn.Add(customerFromDB);
                                }
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
            
            return customerToReturn;
        }

        public Customer GetCustomerById(int id)
        {
            Customer customerFromDB = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(Builder.ConnectionString))
                {
                    connection.Open();

                    string query = $"SELECT CustomerId, FirstName, LastName, Country, PostalCode, Phone, Email FROM Customer WHERE CustomerId = {id}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                while (reader.Read())
                                {
                                    customerFromDB = new Customer(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetString(5),
                                    reader.GetString(6)
                                    );
                                }
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

            return customerFromDB;
        }

        public Customer GetCustomerByName(string CustomerName)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomersPage(int limit, int offset)
        {
            throw new NotImplementedException();
        }

        public void GetCustomreByName(string CustomerName)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetHighestSpendingCustomers()
        {
            throw new NotImplementedException();
        }

        public List<string> GetMostPopularGenre(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfCustomersByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
