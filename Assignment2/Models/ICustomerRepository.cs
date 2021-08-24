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
        void GetCustomerById(int id);
    }
}
