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

        /// <summary>
        /// Initialize SQL Connection Builder with default values
        /// </summary>
        public CustomerRepository()
        {
            Builder.DataSource = @"5CG05206R1\SQLEXPRESS"; // Peppi - @"5CG05206QV\SQLEXPRESS"
            Builder.InitialCatalog = "Chinook";
            Builder.IntegratedSecurity = true;
        }
        /// <summary>
        /// Initialize SQL Connection Builder with given parameter values
        /// </summary>
        /// <param name="dataSource">Builder.DataSource path to database without @ sign</param>
        /// <param name="initialCatalog">Name of database</param>
        public CustomerRepository(string dataSource, string initialCatalog)
        {
            Builder.DataSource = dataSource;
            Builder.InitialCatalog = initialCatalog;
            Builder.IntegratedSecurity = true;
        }

        public Customer AddCustomer(Customer addCustomer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Builder.ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Customer (FirstName, LastName, Country, PostalCode, Phone, Email) " + 
                        "VALUES (@FirstName, @LastName, @Country, @PostalCode, @Phone, @Email)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", addCustomer.FirstName);
                        command.Parameters.AddWithValue("@LastName", addCustomer.LastName);
                        command.Parameters.AddWithValue("@Country", addCustomer.Country);
                        command.Parameters.AddWithValue("@PostalCode", addCustomer.PostalCode);
                        command.Parameters.AddWithValue("@Phone", addCustomer.PhoneNumber);
                        command.Parameters.AddWithValue("@Email", addCustomer.Email);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }

            return addCustomer;
        }

        public Customer GetCustomerById(int id)
        {
            Customer customerFromDB = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(Builder.ConnectionString))
                {
                    connection.Open();

                    string query = $"SELECT CustomerId, FirstName, LastName, Country, PostalCode, Phone, Email " +
                        $"FROM Customer WHERE CustomerId = {id}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                if (reader.Read())
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
                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.ToString());
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

        public List<Customer> GetCustomers()
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
                                //reader.IsDBNull check usage to prevent first null object??
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
                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.ToString());
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

        public Customer GetCustomerByName(string CustomerName)
        {
            Customer customerFromDB = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(Builder.ConnectionString))
                {
                    connection.Open();

                    string query = $"SELECT CustomerId, FirstName, LastName, Country, PostalCode, Phone, Email FROM Customer WHERE Customer.FirstName LIKE '%{CustomerName}%' OR Customer.LastName LIKE '%{CustomerName}%'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                if (reader.Read())
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
                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.ToString());
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

        public List<Customer> GetCustomersPage(int limit, int offset)
        {
            throw new NotImplementedException();
        }
        //MIKKO
        //vois olla void
        public void UpdateCustomer(Customer customer)
        {
            string query = "UPDATE Customer SET FirstName=@firstName WHERE CustomerId = @customerId;";
            try
            {
                using (SqlConnection connection = new SqlConnection(Builder.ConnectionString))
                //laajenna loppuun!
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@customerId", customer.Id);

                    //tääkin pitäs varmaan trycatchaa
                    //injektioriski?
                    
                    
                    cmd.ExecuteNonQuery();

                  
                    //tulosta juuri muokattu?
                }
                //vähän parantais exceptionii
            } catch (SqlException ex)
            {
                // Wrappaa uuteen repository exceptioniin, joka ottaa alkuperäisen exceptionin sisään. Tallennetaan se propertyyn
               // throw new RepositoryException(ex);
                Console.WriteLine("Error: " + ex.ToString());
            }
            //tarviiko mitään returnia?
        }
        //MIKKO
        public List<CustomerCountry> GetNumberOfCustomersByCountry()
        {
            List<CustomerCountry> customerNumbers = new List<CustomerCountry>();
            string query = $"SELECT Country, COUNT(CustomerId) AS total FROM Customer GROUP BY Country ORDER BY total DESC;";

            try
            {
                using (SqlConnection connection = new SqlConnection(Builder.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {



                        while (reader.Read())
                        {
                            CustomerCountry customerCountryNumber = new CustomerCountry(
                            reader.GetString(0),
                            reader.GetInt32(1)
                            );

                            customerNumbers.Add(customerCountryNumber);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return customerNumbers;
        }
    

        public CustomerSpender GetHighestSpendingCustomers()
        {
            CustomerSpender customerSpender = new CustomerSpender();

            try
            {
                using (SqlConnection connection = new SqlConnection(Builder.ConnectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT Customer.CustomerId, FirstName, LastName, Country, PostalCode, Phone, Email, Invoice.Total
                        FROM Customer 
                        JOIN Invoice  
                        ON Customer.CustomerId = Invoice.CustomerId
                        ORDER BY Invoice.Total DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                //reader.IsDBNull check usage to prevent first null object??
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
                                    double invoiceTotal = reader.GetDouble(7);

                                    customerSpender.AddCustomerSpendings(customerFromDB , invoiceTotal);
                                }
                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.ToString());
                            }
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return customerSpender;
        }

        public CustomerGenre GetMostPopularGenre(Customer customer)
        {
            CustomerGenre customerGenres = new CustomerGenre();
            try
            {
                using (SqlConnection connection = new SqlConnection(Builder.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Genre.Name, COUNT(Genre.Name) AS amount " +
                                    "FROM Customer, Invoice, InvoiceLine, Track, Genre " +
                                    "WHERE Customer.CustomerId = Invoice.CustomerId " +
                                    "AND Invoice.CustomerId = InvoiceLine.InvoiceId " +
                                    "AND InvoiceLine.TrackId = Track.TrackId " +
                                    "AND Track.GenreId = Genre.GenreId " +
                                    $"AND Customer.CustomerId = {customer.Id} " +
                                    "GROUP BY Genre.Name " +
                                    "ORDER BY amount DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                int maxAmountOfGenres = 0;
                                //reader.IsDBNull check usage to prevent first null object??
                                while (reader.Read())
                                {
                                    //Check if several genres with highest number of occurences (ordered DESC)
                                    if (maxAmountOfGenres < reader.GetInt32(1))
                                    {
                                        customerGenres.AddCustomerGenre(reader.GetString(0));
                                        maxAmountOfGenres = reader.GetInt32(1);
                                    }
                                }
                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return customerGenres;
        }
    }
}
