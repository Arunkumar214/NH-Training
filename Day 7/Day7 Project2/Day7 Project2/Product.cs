using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project2
{
    class Product
    {
        private string name;
        private int mftyear;
        private string type; 

        public void ReadProduct()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("enter mftyear");
            mftyear =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("enter type");
            type = Console.ReadLine();
        }

        public void PrintProduct()
        {
            Console.WriteLine($"name={name},mftyear={mftyear},type={type}");
        }
    }
}
