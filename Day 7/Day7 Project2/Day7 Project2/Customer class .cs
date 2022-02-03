using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project2
{
    class Customer_class
    {
        private string Cstname;
        private string Cstid;
        private int Cstmbno; 

        public void ReadCustomers()
        {
            Console.WriteLine("Enter Cstname");
            Cstname = Console.ReadLine();

            Console.WriteLine("Enter Cstid");
            Cstid = Console.ReadLine();

            Console.WriteLine("Enter Cstmbno");
            Cstmbno = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintCustomers()
        {
            Console.WriteLine($"Cstname={Cstname},Cstid={Cstid},Cstmbno={Cstmbno}");
        }
    }
}
