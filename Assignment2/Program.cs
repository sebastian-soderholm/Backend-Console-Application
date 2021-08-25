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
            /*
            Console.WriteLine(customerRepo.GetCustomerById(16).ToString());

            List<Customer> customers = customerRepo.GetCustomers();

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }

            Console.WriteLine(customerRepo.GetCustomerByName("Hannah"));
            
            Customer testCustomer = new Customer()
            {
                FirstName = "Bruce",
                LastName = "Wayne",
                Country = "USA",
                PostalCode = "53540",
                PhoneNumber = "050123456",
                Email = "batman@wayneenterprises.com"
            };
            customerRepo.AddCustomer(testCustomer);

            testCustomer = customerRepo.GetCustomerById(1);
            testCustomer.FirstName = "Luis";
            customerRepo.UpdateCustomer(testCustomer);
            */
            List<CustomerCountry> testList = customerRepo.GetNumberOfCustomersByCountry();
            //LinQ magics
            testList.ForEach(x => Console.WriteLine(x.Name + " | " + x.Count));

        }
    }
}
