using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{   [Serializable]
    class PasswordExeption:Exception
    {
        public PasswordExeption() { }
        public PasswordExeption(string message) : base(message) { }
        public PasswordExeption(string message, Exception inner) : base(message, inner) { }
        protected PasswordExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
