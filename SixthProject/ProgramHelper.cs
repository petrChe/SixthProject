using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public string ConvertToCSharp(string initialString)
        {
            return "Charp Coverting is successfully completed";            
        }

        public string ConvertToVB(string initialString)
        {
            return "VB Coverting is successfully completed";
        }
        public bool CodeCheckSyntax(string initialString, string language)
        {
            switch (language)
            {
                case "C#":
                    string regexCSharpString = ConvertToCSharp(initialString);
                    return true;
                case "VB":
                    string regexVBString = ConvertToVB(initialString);
                    return true;
            }
            return false;
        }
    }
}
