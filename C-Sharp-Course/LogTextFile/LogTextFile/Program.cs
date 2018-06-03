using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"D:\The Tech Academy\Tech-Academy-Projects\C-Sharp-Course\LogTextFile\log.txt", true))
            {
                file.WriteLine(number);
            }
            Console.WriteLine("The number you chose is {0}.", number);
            Console.ReadLine();
        }
    }
}
