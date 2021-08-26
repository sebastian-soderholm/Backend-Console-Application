using Assignment2.Exceptions;
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
            ICustomerRepository customerRepo = new CustomerRepository(@"5CG05206QS\SQLEXPRESS", "Chinook");
            //Console.WriteLine(customerRepo.GetCustomerById(45));

            try
            {
                List<Customer> customerPage = customerRepo.GetCustomersPage(2,20);

                foreach(Customer customer in customerPage)
                {
                    Console.WriteLine(customer.ToString());
                }
            }
            catch (RepositoryException re)
            {
                Console.WriteLine();
            }

            //Customer testCustomer = new Customer()
            //{
            //    FirstName = "Bruce",
            //    LastName = "Wayne",
            //    Country = "USA",
            //    PostalCode = "53540",
            //    PhoneNumber = "050123456",
            //    Email = "batman@wayneenterprises.com"
            //};
            //customerRepo.AddCustomer(testCustomer);
            /*
            testCustomer = customerRepo.GetCustomerById(1);
            testCustomer.FirstName = "Luis";
            customerRepo.UpdateCustomer(testCustomer);
            List<CustomerCountry> testList = customerRepo.GetNumberOfCustomersByCountry();
            //LinQ magics
            testList.ForEach(x => Console.WriteLine(x.Name + " | " + x.Count));
            */
        }
    }
}
