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
            Console.Write("Please enter number to add, subtract, and multiply by 2: ");
            MathProblem mathProblem = new MathProblem();
            int num = mathProblem.num1;
            Console.WriteLine(mathProblem.add);
            Console.WriteLine(mathProblem.sub);
            Console.WriteLine(mathProblem.mul);
            Console.ReadLine();
        }
    }
}
