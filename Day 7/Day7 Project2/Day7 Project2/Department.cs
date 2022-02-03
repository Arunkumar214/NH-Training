using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project2
{
    class Department
    {
        private string name;
        private string id;
        private int code; 

        public void ReadDepartment()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("enter id");
            id = Console.ReadLine();

            Console.WriteLine("enter code");
            code = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDepartment()
        {
            Console.WriteLine($"name={name},id={id},code={code}");
        }
    }
}
