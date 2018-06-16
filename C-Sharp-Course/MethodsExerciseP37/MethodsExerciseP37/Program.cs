using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExerciseP37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number to perform a math operation on: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int addNumber = MathOperation.Math(numberOne);
            Console.WriteLine("Addition: " + addNumber);

            Console.Write("Now please enter a decimal number to perform a math operation on: ");
            double numberTwo = Convert.ToDouble(Console.ReadLine());
            double mulNumber = MathOperation.Math(numberTwo);
            Console.WriteLine("Muliply: " + mulNumber);

            Console.Write("Now please enter a number to perform a math operation on: ");
            string numberThree = Console.ReadLine();
            int subNumber = MathOperation.Math(numberThree);
            Console.WriteLine("Subtract: " + subNumber);

            Console.ReadLine();
        }
    }
}
