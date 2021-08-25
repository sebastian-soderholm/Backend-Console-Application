using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class CustomerGenre
    {
        public List<string> Name { get; set; }

        public override string ToString()
        {
            string genres = "";
            foreach (string name in Name)
            {
                genres = genres + name;
            }
            return genres;
        }
    }
}
