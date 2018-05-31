using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the current day of the week: ");
            string userDay = Console.ReadLine();
            bool falseDay = false;
            
                while (falseDay == false)
                {
                    foreach (DaysOfTheWeek day in Enum.GetValues(typeof(DaysOfTheWeek)))
                    {
                        string stringDay = Convert.ToString(day);
                        if (userDay == stringDay)
                        {
                            Console.WriteLine("Correct! It is {0}.", day);
                            falseDay = true;
                        }
                    }
                    if (falseDay == false)
                    {
                        Console.Write("Please enter valid day: ");
                        userDay = Console.ReadLine();
                    }
                }
                Console.ReadLine();
            
        }
    }
}
