using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    class Program
    {
        //const string vb = "Dim str As String\nPublic Sub Main()\n" +
        //    "str = \"Not a hello, world\"\nEnd Sub";
        //const string cs = "string str;\nstatic void Main(string[] args)\n" +
        //    "str = \"Not a hello, world\";\n";
        private const string PATH = @"D:\testfile.txt";

        static void Main(string[] args)
        {
            //    Convertor conv = new Convertor();
            //    Console.WriteLine(conv.ConvertToCSharp(vb));
            //    Console.WriteLine(conv.ConvertToVB(cs));
            //    Console.WriteLine();
            //    ProgramHelper ph = new ProgramHelper();
            //    Console.WriteLine(ph.CodeCheckSyntax(vb,"C#"));
            //    Console.WriteLine();
            //    ProgramConverter[] programConverters =
            //    {
            //        new ProgramConverter(),
            //        new ProgramConverter(),

            //    };
            //    ProgramHelper[] programhelpers =
            //    {
            //        new ProgramHelper(),
            //        new ProgramHelper(),

            //    };
            //    foreach (ProgramConverter pc in programConverters)
            //    {
            //        pc.ConvertToCSharp(vb);
            //        pc.ConvertToVB(cs);
            //        //CodeCheckSyntax не вызывает
            //    }
            //    foreach (ProgramHelper phelpers in programhelpers)
            //    {
            //        phelpers.ConvertToCSharp(vb);
            //        phelpers.ConvertToVB(cs);
            //        //phelpers.CodeCheckSyntax

            //    }

            FileStream fileStream = new FileStream(PATH, FileMode.Open, FileAccess.Read);
            Console.WriteLine("Please, write the password:");
            string userPass = Console.ReadLine();
            StreamWithPassword passStream = new StreamWithPassword(fileStream, userPass);
            byte[] bytes = new byte[5];
            passStream.Read(bytes,0,bytes.Length);
            
            foreach(byte b in bytes)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
