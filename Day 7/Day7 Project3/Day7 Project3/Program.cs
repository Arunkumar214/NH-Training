using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project3
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
            Employee emp = new Employee() { id = 5, name = "arun", salary = 700 };
            Console.WriteLine($"id={ emp.id},name={emp.name},salary={emp.salary}");
            Console.ReadLine();
        {

        }
        }
    }
}
