using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExerciseP37
{
    class MathOperation
    {
        public static int Math(int number)
        {
            int result = number + 3;
            return result;
        }
        public static double Math(double number)
        {
            double result = number * 5;
            return result;
        }
        public static int Math(string number)
        {
            int stringNumber = Convert.ToInt32(number);
            int result = stringNumber - 1;
            return result;
        }
    }
}
