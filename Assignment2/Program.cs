using Assignment2.Models;
using Microsoft.Data.SqlClient;
using System;


namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customerRepo = new CustomerRepository();

            customerRepo.GetCustomerById(16);
        }
    }
}
