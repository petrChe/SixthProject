using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string initialString)
        {
            return "csharp converting in programconverter";
        }

        public string ConvertToVB(string initialString)
        {
            return "vb converting in programconverter";
        }
    }
}
