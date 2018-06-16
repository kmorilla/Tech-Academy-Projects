using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "kevyn";
            string quote = "The man said, \"Hello\", Kevyn. \nHello on a new line. \n \tHello on a tab."; // \" = quotation marks, \n = new line, \t = tab
            string fileName = "C:\\Users\\Kevyn"; // two foward slashes equals one foward slash \\ = \
            string fileName2 = @"C:\Users\Kevyn"; // an @ symbol signifies that there are no escape sequences happening within it so you can use one foward slash

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("n");

            int length = name.Length;

            name = name.ToUpper();

            Console.WriteLine(name);
            Console.ReadLine();



            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Kevyn");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
