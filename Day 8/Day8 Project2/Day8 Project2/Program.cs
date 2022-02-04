using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Project2
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
                {
                new Employee(){id=1,name="arun",salary=6000},
                new Employee(){id=2,name="rey",salary=4000},
                new Employee(){id=3,name="sai",salary=5500},
                new Employee(){id=4,name="cat",salary=4500},
                new Employee(){id=5,name="rat",salary=6500}
            };

            //for loop 
            for (int i=0;i<employees.Count;i++)
            {
                Console.WriteLine($"id={employees[i].id}, name={employees[i].name},salary={employees[i].salary}");
            }

            //foreach loop
             foreach (var e in employees)
            {
                Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}");
            }

            //Lamda expression

            employees.ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));
            //LINQ Query

            var result = from e in employees
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));
            Console.ReadLine();
        }   
    }
}
