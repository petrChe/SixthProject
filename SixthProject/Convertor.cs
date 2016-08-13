using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    class Convertor : IConvertible
    {
        public string ConvertToCSharp(string initialString)
        {
            StringBuilder resultSb = new StringBuilder();
            string[] stringArray = initialString.Split('\n');
            StringBuilder[] codeParts = new StringBuilder[stringArray.Length];
            for(int i = 0; i < stringArray.Length; i++)
            {
                codeParts[i] = new StringBuilder();
                codeParts[i].Append(stringArray[i]);
            }
            foreach (StringBuilder sb in codeParts)
            {
                sb.Replace("Dim", "string").Replace(" As String", ";");
                sb.Replace("Public Sub Main()", "static void Main(string[] args)");
                sb.Replace("str = \"Not a hello, world\"", "str = \"Not a hello, world\";");
                sb.Replace("End Sub", "");
                resultSb.AppendFormat("{0}{1}",sb,'\n');
            } 
            return resultSb.ToString();
        }

        public string ConvertToVB(string initialString)
        {
            StringBuilder resultSb = new StringBuilder();
            string[] stringArray = initialString.Split('\n');
            StringBuilder[] codeParts = new StringBuilder[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                codeParts[i] = new StringBuilder();
                codeParts[i].Append(stringArray[i]);
            }
            foreach (StringBuilder sb in codeParts)
            {
                sb.Replace("string", "Dim").Replace(";", " As String");
                sb.Replace("static void Main(string[] args)", "Public Sub Main()");
                sb.Replace("str = \"Not a hello, world\";", "str = \"Not a hello, world\"\nEnd Sub");
                resultSb.AppendFormat("{0}{1}", sb, '\n');
            }
            return resultSb.ToString();
        }
    }
}
