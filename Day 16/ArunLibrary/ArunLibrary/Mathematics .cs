using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunLibrary
{
    //Author: Arun 
    // Creating Library and classes using Library
    public class Mathematics
    {
        int n;

        public void ReadData()
        {
            Console.WriteLine("Enter number ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"The factorial of {n} is: {fact}");
        }
    }
}