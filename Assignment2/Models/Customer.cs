using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Customer
    {
        public Customer(int id, string firstName, string lastName, string country, string postalCode, string phoneNumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// Create string of customer properties
        /// </summary>
        /// <returns>String of customer details</returns>
        public override string ToString()
        {
            StringBuilder customerStringBuilder = new StringBuilder();

            return customerStringBuilder.AppendFormat(
                $"First name: {FirstName} \n" +
                $"Last name: {LastName} \n" +
                $"Country: {Country} \n" +
                $"Postal code: {PostalCode} \n" +
                $"Phone number: {PhoneNumber} \n" +
                $"Email: {Email} \n"
             ).ToString();
        }
    }
}
