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
            MathClass math = new MathClass();
            Console.WriteLine("Please enter first number: ");
            math.num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            math.num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter \"Add,\" \"Subtract,\" or \"Multiply\": ");
            string addSubMul = Console.ReadLine();
            

            if (addSubMul == "Add")
            {
                math = Add(math);
                Console.WriteLine(math.num1 + " plus " + math.num2 + " equals " + math.result);
            }
            else if (addSubMul == "Subtract")
            {
                math = Subtract(math);
                Console.WriteLine(math.num1 + " minus " + math.num2 + " equals " + math.result);

            }
            else if (addSubMul == "Multiply")
            {
                math = Multiply(math);
                Console.WriteLine(math.num1 + " times " + math.num2 + " equals " + math.result);
            }

            Console.ReadLine();            
        }

        public static MathClass Add(MathClass math)
        {
            math.result = math.num1 + math.num2;
            return math;
        }

        public static MathClass Subtract(MathClass math)
        {
            math.result = math.num1 - math.num2;
            return math;
        }

        public static MathClass Multiply(MathClass math)
        {
            math.result = math.num1 * math.num2;
            return math;
        }
    }
}
