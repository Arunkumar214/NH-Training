using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_1
{
    class Employees
    {
        public int Id;
        public string name;
        private int salary;

        public void ReadEmployee()
        {
            Console.WriteLine("enter Id");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Id={Id},Name={name},salary={salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employees emp1 = new Employees();
            emp1.ReadEmployee();
            emp1.PrintEmployee();
            Console.ReadLine();
        }
    }
}
        
    
