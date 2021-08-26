using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class CustomerSpender
    {
        public Dictionary<Customer, decimal> CustomerSpendings = new Dictionary<Customer, decimal>();

        /// <summary>
        /// Add a customer and spendings for given customer
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <param name="spendings">Spendings for given customer (double)</param>
        public void AddCustomerSpendings(Customer customer, decimal spendings)
        {
            CustomerSpendings.Add(customer, spendings);
        }

        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();

            foreach (KeyValuePair<Customer, decimal> customer in CustomerSpendings)
            {
                returnString.Append(customer.Key.ToString() + "Spending: " + customer.Value + "\n\n");
            }

            return returnString.ToString();
        }
        
    }
}
