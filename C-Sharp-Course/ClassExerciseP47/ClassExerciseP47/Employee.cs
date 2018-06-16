using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExerciseP47
{
    public class Employee/*<T>*/ : Person, IQuittable
    {
        public int ID { get; set; }

        //public List<T> Things { get; set; }


        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("Employees that have put in their two weeks notice: " + FirstName + " " + LastName);
        }

        //public Employee(int id, string firstName, string lastName)
        //{
        //    ID = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //}
        //public static bool operator ==(Employee e1, Employee e2)
        //{
        //    return e1.Equals(e2);
        //}
        //public static bool operator !=(Employee e1, Employee e2)
        //{
        //    return !e1.Equals(e2);
        //}
        //public override string ToString()
        //{
        //    return ID.ToString();
        //}
        //public override bool Equals(object obj)
        //{
        //    return this.ToString() == obj.ToString();
        //}
        //public override int GetHashCode()
        //{
        //    return this.ToString().GetHashCode();
        //}

    }
}
