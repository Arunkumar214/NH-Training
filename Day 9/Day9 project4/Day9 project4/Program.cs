using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_project4
{
    class Employee
    {
        private int id;
        public string name;
        private int salary;
        public string location;
        public int code;
        public string type;
            
        public Employee(int id, string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public Employee (string location, int code, string type)
        {
            this.location = location;
            this.code = code; 
            this.type = type;
        }
        /*
        public void Readdata()
        {
            Console.WriteLine("enter id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            name = (Console.ReadLine());
            Console.WriteLine("enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void Readdata2()
        {
            
            Console.WriteLine("enter location");
            location = (Console.ReadLine());
            Console.WriteLine("enter code");
            code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter type");
            type = (Console.ReadLine());
        }*/
        public void Printdata()
        {
            Console.WriteLine($"id={id},name={name},salary={salary}");
        }

        public void Printdata2()
        {
            Console.WriteLine($"location = {location}, code= {code}, type={type}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Arun", 5000);
            Employee emp1 = new Employee("Hyd", 12345, "It");
            
            emp.Printdata();
            emp1.Printdata2();

            Console.ReadLine();
        }
    }
}
