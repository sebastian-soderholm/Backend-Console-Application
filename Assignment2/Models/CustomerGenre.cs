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

        public CustomerGenre()
        {
            Genre = new List<string>();
        }
        /// <summary>
        /// Add genre as string for CustomerGenre
        /// </summary>
        /// <param name="genre">Genre name as string</param>
        public void AddCustomerGenre(string genre)
        {
            Genre.Append(genre);
        }

        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();

            foreach (string genre in Genre)
            {
                returnString.Append(genre);
            }

            return returnString.ToString();

        }
    }
}
