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

            //Console.WriteLine(customerRepo.GetCustomerById(16).ToString());

            List<Customer> customers = customerRepo.GetAll();

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
    }
}
