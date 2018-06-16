using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExerciseP38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first number: ");
            int oneNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pleae enter second number or enter \"Nothing\": ");
            string skip = Console.ReadLine();

            if (skip != "Nothing" )
            {
                int twoNumber = Convert.ToInt32(skip);
                int equals = MathOperation.Math(oneNumber, twoNumber);
                Console.WriteLine("Result: {0}", equals);
            }
            else
            {
                int equals = MathOperation.Math(oneNumber);
                Console.WriteLine("Result: {0}", equals);
            }            
            
            Console.ReadLine();
        }
    }

    class MathOperation
    {
        public static int Math(int numberOne, int numberTwo = 5)
        {
            int result = numberOne + numberTwo;
            return result;
        }
    }
}
