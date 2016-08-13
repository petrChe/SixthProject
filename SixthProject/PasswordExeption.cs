using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    class PasswordExeption:Exception
    {
        public PasswordExeption() { }
        public PasswordExeption(string message) : base(message)
        {
        }
    }
}
