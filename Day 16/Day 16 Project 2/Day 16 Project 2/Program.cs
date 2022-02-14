using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_2
{
    //Author: Arun 
    //Factorial using oops 
    class Factorial
    {
        int n;
         
        public void ReadData()
        {
            Console.WriteLine("Enter number ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        {
            int fact=1; 
            for (int i=1;i<=n; i++)
            {
                fact = fact * i; 
            }
            Console.WriteLine($"The factorial of {n} is: {fact}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            f.ReadData();
            f.PrintData();
            Console.ReadLine();

        }
    }
}
