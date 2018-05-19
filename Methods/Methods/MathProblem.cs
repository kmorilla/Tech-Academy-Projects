using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class MathProblem
    {
        public MathProblem()
        {
            num1 = Convert.ToInt32(Console.ReadLine());
            add = num1 + 2;
            sub = num1 - 2;
            mul = num1 * 2;
            
        }
        public int num1 { get; set; }  
        public int add { get; set; }
        public int sub { get; set; }
        public int mul { get; set; }
    }
}
