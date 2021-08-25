using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public interface ICustomerRepository
    {
        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns>List of customer objects</returns>
        public List<Customer> GetCustomers();
        /// <summary>
        /// Get customer by Id number
        /// </summary>
        /// <param name="CustomerId">Customer Id number in database</param>
        /// <returns>Customer object</returns>
        public Customer GetCustomerById(int CustomerId);
        /// <summary>
        /// Get customer by name
        /// </summary>
        /// <param name="CustomerName">Customer name string in database</param>
        /// <returns>Customer object</returns>
        public Customer GetCustomerByName(string CustomerName);
        /// <summary>
        /// Get a specified max number of customers starting from a specified offset
        /// </summary>
        /// <param name="limit">Max number of customer objects to return</param>
        /// <param name="offset">Number of customers to skip from the beginning of the table</param>
        /// <returns>List of customer objects</returns>
        public List<Customer> GetCustomersPage(int limit, int offset);
        /// <summary>
        /// Add customer to database
        /// </summary>
        /// <param name="customer">Customer to add to the database</param>
        public void AddCustomer(Customer customer);
        /// <summary>
        /// Update a customer's info (with same Id)
        /// </summary>
        /// <param name="customer">Customer object to update</param>
        public void UpdateCustomer(Customer customer);
        /// <summary>
        /// Get number of customers in given country
        /// </summary>
        /// <param name="country">Name of country as string</param>
        /// <returns>Customer count as int</returns>
        public int GetNumberOfCustomersByCountry(string country);
        /// <summary>
        /// Get highest spending customers in descending order
        /// </summary>
        /// <returns>List of customer objects</returns>
        public List<Customer> GetHighestSpendingCustomers();
        /// <summary>
        /// Get most popular genres for a given customer
        /// </summary>
        /// <param name="CustomerId">Customer's id number to get genres of</param>
        /// <returns>List of genres as strings, contains multiple genres in the case of a tie</returns>
        public CustomerGenre GetMostPopularGenre(int CustomerId);


    }
}
