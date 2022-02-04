using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Project3
{
    class Employee
    {
        private int Id;
        public string name;
        private int Salary;
        private static string Company = "Nations Benefits";

       /// <summary>
       /// Reads data from the user 
       /// </summary>
        public void Readdata()
        {
            Console.WriteLine("Enter id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = (Console.ReadLine());
            Console.WriteLine("Enter salary");
            Salary = Convert.ToInt32(Console.ReadLine());


        }
        /// <summary>
        /// Prints data of the employee 
        /// </summary>
        public void Printdata()
        {
            Console.WriteLine($"id={Id},name={name},salary={Salary},company={Company}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
                Employee emp = new Employee();
                emp.Readdata();
                emp.Printdata();
        }
    }
}
