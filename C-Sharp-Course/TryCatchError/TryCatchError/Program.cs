using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchError
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Please enter age: ");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer)
                    {
                        throw new Exception();
                    }
                }
                if (age < 0)
                {
                    throw new ZeroException();
                }
                int birthYear = 2018 - age;
                Console.WriteLine("You were born on the year {0}.", birthYear);
                Console.ReadLine();
            }
            catch (ZeroException)
            {
                Console.WriteLine("An error occured. Please enter a date greater than zero.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please enter a number or contact your System Administrator.");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
