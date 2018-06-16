using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExerciseP41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Math(numberOne);
            Console.Write("Please enter another number: ");
            string numberTwo = Console.ReadLine();
            int minus = 0;
            Math(numberTwo, out minus);

            Console.ReadLine();
        }

        static void Math(int number)
        {
            int equals = number / 2;
            Console.WriteLine(number + " divided by 2 equals " + equals);

            
        }

        static void Math(string numberString, out int minus)
        {
            int number = Convert.ToInt32(numberString);
            minus = number - 5;
            Console.WriteLine(number + " minus 5 equals " + minus);
        }
    }
}
