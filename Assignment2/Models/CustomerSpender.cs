using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class CustomerSpender
    {
        public Dictionary<Customer, double> CustomerSpendings { get; set; }

        /// <summary>
        /// Add a customer and spendings for given customer
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <param name="spendings">Spendings for given customer (double)</param>
        public void AddCustomerSpendings(Customer customer, double spendings)
        {
            CustomerSpendings.Add(customer, spendings);
        }

        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();

            foreach (KeyValuePair<Customer, double> customer in CustomerSpendings)
            {
                returnString.Append(customer.Key.ToString() + "Spending: " + customer.Key.Value);
            }

            return returnString.ToString();
        }
        
    }
}
