using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    public class Employee<T>  : Person, IQuittable //Page 58: Person, Page 60: IQuittable, Page 65: <T>
    {
        public int ID { get; set; } //Page 58
        public List<T> Things { get; set; } //Page 65

        public override void SayName() //Page 58
        {
            base.SayName();
        }

        public void Quit() //Page 60
        {
            Console.WriteLine("Employees that have put in their two weeks notice: " + FirstName + " " + LastName);
        }

        //public Employee(int id, string firstName, string lastName) //Page 63
        //{
        //    ID = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //}
        //public static bool operator ==(Employee e1, Employee e2) //Page 63
        //{
        //    return e1.Equals(e2);
        //}
        //public static bool operator !=(Employee e1, Employee e2) //Page 63
        //{
        //    return !e1.Equals(e2);
        //}
        //public override string ToString() //Page 63
        //{
        //    return ID.ToString();
        //}
        //public override bool Equals(object obj) //Page 63
        //{
        //    return this.ToString() == obj.ToString(); //Page 63
        //}
        //public override int GetHashCode()
        //{
        //    return this.ToString().GetHashCode(); //Page 63
        //}
    }
}
