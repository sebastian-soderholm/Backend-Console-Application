using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class CustomerSpender
    {
        public Dictionary<int, decimal> CustomerSpendings = new Dictionary<int, decimal>();

        /// <summary>
        /// Add a customer and spendings for given customer
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <param name="spendings">Spendings for given customer (double)</param>
        public void AddCustomerSpendings(int customerId, decimal spendings)
        {
            CustomerSpendings.Add(customerId, spendings);
        }

        /// <summary>
        /// Generate string of customer IDs and spendings in descending order according to spendings
        /// </summary>
        /// <returns>String of customer IDs and amount spending for given customer</returns>
        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();

            foreach (KeyValuePair<int, decimal> customer in CustomerSpendings)
            {
                returnString.Append("Customer Id: " + customer.Key + " Spending: " + customer.Value + "\n\n");
            }
            return returnString.ToString();
        }
    }
}
