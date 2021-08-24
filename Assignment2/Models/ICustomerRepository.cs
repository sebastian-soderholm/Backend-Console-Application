using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public interface ICustomerRepository
    {
        void GetAll();
        void GetCustomerById(int CustomerId);
        void GetCustomreByName(string CustomerName);
        void GetCustomersPage(int limit, int offset);
        void AddCustomer();

    }
}
