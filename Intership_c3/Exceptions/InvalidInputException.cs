using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intership_c3.Exceptions
{
    class InvalidInputException : Exception
    {
        public InvalidInputException() : base("Invalid input")
        {
        }

        public void ShowMessage()
        {
            Console.Clear();
            Console.WriteLine(Message);
            Console.ReadKey();
        }

        public InvalidInputException(string message) : base(message)
        {
        }
    }
}
