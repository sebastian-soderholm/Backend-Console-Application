using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class CustomerCountry
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public CustomerCountry(string name, int count)
        {
            Name = name;
            Count = count;
        }

        /// <summary>
        /// Create string of CustomerCountry properties
        /// </summary>
        /// <returns>String of CustomerCountry details</returns>
        public override string ToString()
        {
            return $"Country: {Name} ({Count})";
        }
    }
}
