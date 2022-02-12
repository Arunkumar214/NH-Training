using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = 9; 
            for (i=2;i<n;i++)
            {
                if (n % i == 0)
                    break; 
            }
            if (i==n)
                Console.WriteLine("It's a prime number {0}",n);
            else
                Console.WriteLine("Given number is not prime");

            Console.ReadLine();
        }
    }
}
