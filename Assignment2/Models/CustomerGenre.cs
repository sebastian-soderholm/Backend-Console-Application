using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class CustomerGenre
    {
        public Dictionary<string, int> GenreAmount = new Dictionary<string, int>();

        /// <summary>
        /// Add genre as string for CustomerGenre
        /// </summary>
        /// <param name="genre">Genre name as string</param>
        public void AddCustomerGenreAmount(string genre, int amount)
        {
            GenreAmount.Add(genre, amount);
        }

        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();

            foreach (KeyValuePair<string, int> genreamount in GenreAmount)
            {
                returnString.Append($"Genre: {genreamount.Key} ({genreamount.Value})\n");
            }

            return returnString.ToString();

        }
    }
}
