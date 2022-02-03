using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project2
{
    class Seller_Class
    {
        private string id;
        private string name;
        private string location;

        public void ReadSeller()
        {
            Console.WriteLine("enter id");
            id = Console.ReadLine();

            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("enter location");
            location = Console.ReadLine();

        }

        public void PrintSeller()
        {
            Console.WriteLine($"id={id},name={name},location={location}");
        }
    }
}
