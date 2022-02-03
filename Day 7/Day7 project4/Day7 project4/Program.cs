using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project4
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
            Employee[] emp = new Employee[]
            {
                new Employee(){id=1,name="sai",salary=100},
                new Employee(){id=2,name="rat",salary=200},
                new Employee(){id=3,name="rey",salary=300},
                new Employee(){id=4,name="cat",salary=400},
                new Employee(){id=5,name="oye",salary=500},
            };
            for (int i=0;i<emp.Length;i++)
            {
                Console.WriteLine($"id={emp[i].id},name={emp[i].name},salary={emp[i].salary}");
            }
            //foreach loop
            foreach(var e in emp)
            {
                Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}");
            }
            //Lamda expression
            emp.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));
            Console.ReadLine();
       }
    }
}
