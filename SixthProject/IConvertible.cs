using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    interface IConvertible
    {
        string ConvertToCSharp(string initialString);
        string ConvertToVB(string initialString);
    }
}
