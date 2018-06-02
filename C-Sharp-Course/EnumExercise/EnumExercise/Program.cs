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
            try
            {
                Console.Write("Please enter a value within the DaysOfWeek enumeration: ");
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
                if (Enum.IsDefined(typeof(DaysOfWeek),day))
                {
                    Console.WriteLine("The day you picked was {0}.", day);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid value within the DaysOfWeek enumeration.", day);
                }
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("That value is not within the DaysOfWeek enumeration.");
                Console.ReadLine();
            }                       
        }
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
