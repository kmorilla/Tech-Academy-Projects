using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number to do math operations on: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int addEqual = MathClass.Add(number);
            int subEqual = MathClass.Subtract(number);
            int mulEqual = MathClass.Multiply(number);

            Console.WriteLine("Addition: " + addEqual);
            Console.WriteLine("Subtracion: " + subEqual);
            Console.WriteLine("Multiply: " + mulEqual);
            Console.ReadLine();            
        }        
    }
}
