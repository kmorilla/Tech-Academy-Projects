using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExerciseP39
{
    class Math
    {
        static void Main(string[] args)
        {            
            MathOperation(numberOne: 1, numberTwo: 3);
            Console.ReadLine();
        }

        static void MathOperation(int numberOne, int numberTwo)
        {
            int result = numberOne + 3;
            Console.WriteLine("Second number: {0}", numberTwo);
        }
    }
}
