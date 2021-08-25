using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class CustomerGenre
    {
        public List<string> Genre { get; set; }

        /// <summary>
        /// Add genre as string for CustomerGenre
        /// </summary>
        /// <param name="genre">Genre name as string</param>
        public void AddCustomerGenre(string genre)
        {
            Genre.Append(genre);
        }
        
    }
}
