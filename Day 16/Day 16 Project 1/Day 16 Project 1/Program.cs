using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_1
{
    //Author: Arun 
    // Purpose: Hello world program using OOPS
    class Hello
    {
        /*string word;
        public void ReadData()
        {
            Console.WriteLine("Enter the word");
            word = Console.ReadLine();
        }*/

        public void PrintData()
        {
            Console.WriteLine("Hello world");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Hello h = new Hello();
           
            h.PrintData();
            Console.ReadLine();
        }
    }
}
