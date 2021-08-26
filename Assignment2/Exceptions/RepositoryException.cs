using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Exceptions
{
    [Serializable]
    public class RepositoryException : Exception
    {
        public RepositoryException() { }

        public RepositoryException(Exception ex) : base(String.Format("RepositoryException: {0}", ex)) { }
    }
}
