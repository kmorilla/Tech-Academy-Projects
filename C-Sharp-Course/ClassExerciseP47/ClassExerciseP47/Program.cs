using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExerciseP47
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise on page 43
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //employee.SayName();
            //Console.ReadLine();

            //Exercise on page 47
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //employee.Quit();
            //Console.ReadLine();

            //Employee employee1 = new Employee(1, "Kevyn", "Morilla");
            //Employee employee2 = new Employee(1, "Kevyn", "Morilla");
            //Console.WriteLine(employee1 == employee2);
            //Console.ReadLine();

            //Employee<string> employee1 = new Employee<string>();
            //employee1.Things = new List<string> { "Money", "House", "Cars" };
            //Employee<int> employee2 = new Employee<int>();
            //employee2.Things = new List<int> { 1, 2, 3, 4 };

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { ID = 1, FirstName = "Kevyn", LastName = "Morilla" });
            employees.Add(new Employee { ID = 2, FirstName = "Alex ", LastName = "Morilla" });
            employees.Add(new Employee { ID = 3, FirstName = "Joe", LastName = "Johnson" });
            employees.Add(new Employee { ID = 4, FirstName = "Andrea", LastName = "Cotton" });
            employees.Add(new Employee { ID = 5, FirstName = "Saul", LastName = "Fernandez" });
            employees.Add(new Employee { ID = 6, FirstName = "Luis", LastName = "Cervantes" });
            employees.Add(new Employee { ID = 7, FirstName = "Josue", LastName = "Rodriguez" });
            employees.Add(new Employee { ID = 8, FirstName = "Joe", LastName = "Hoover" });
            employees.Add(new Employee { ID = 9, FirstName = "Julian", LastName = "Hernandez" });
            employees.Add(new Employee { ID = 10, FirstName = "Tony", LastName = "Le" });

            List<Employee> employeesJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesJoe.Add(employee);
                }
            }

            //List<Employee> employeesJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            //foreach (Employee employee in employeesJoe)
            //{
            //    Console.WriteLine("Employee: {0} {1} {2}", employee.ID, employee.FirstName, employee.LastName);
            //}
            //Console.ReadLine();

            //List<Employee> employeesID = employees.Where(x => x.ID > 5).ToList();
            //foreach (Employee employee in employeesID)
            //{
            //    Console.WriteLine("Employee: {0} {1} {2}", employee.ID, employee.FirstName, employee.LastName);
            //}
            Console.ReadLine();
        }
    }
}
