using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("The date and time is " + dateTime);

            Console.Write("Please enter a number of hours to add: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} hour(s) =  {2}", dateTime, number, dateTime.AddHours(number));
            Console.ReadLine();
        }
    }
}
