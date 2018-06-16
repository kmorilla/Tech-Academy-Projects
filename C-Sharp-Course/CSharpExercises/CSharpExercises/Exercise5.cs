using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class Exercise5
    {
        public static void MakeListOfUniqueNames()
        {
            List<string> uniqueNames = new List<string>() { "Kevyn", "Alex", "Aaron", "Mark" };
            Console.Write("Please enter name to find index number: ");
            string name = Console.ReadLine();
            int i = 0;
            foreach (string uniqueName in uniqueNames)
            {
                if (name == uniqueName)
                {
                    Console.Write("The index number of " + name + " is: " + i);
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
