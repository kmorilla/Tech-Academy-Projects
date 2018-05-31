using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    public abstract class Person //Page 58
    {
        public string FirstName { get; set; } //Page 58
        public string LastName { get; set; } //Page 58

        public virtual void SayName()//Page 58
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName); 
        }
    }
}
