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
