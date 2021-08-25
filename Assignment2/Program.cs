using Assignment2.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customerRepo = new CustomerRepository();

            CustomerSpender customerSpendings = customerRepo.GetHighestSpendingCustomers();

            customerSpendings.ToString();
        }
    }
}
