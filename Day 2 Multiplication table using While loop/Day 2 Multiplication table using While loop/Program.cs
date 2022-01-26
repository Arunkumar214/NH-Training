using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Multiplication_table_using_While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            while(i<=10)
            {
                Console.WriteLine("{0}x{1}={2}",n,i,n*i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
