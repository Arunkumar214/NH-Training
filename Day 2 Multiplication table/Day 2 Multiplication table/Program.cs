using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}X{1}={2}",n,i,n*i);
            }
            Console.ReadLine();
        }
    }
}
