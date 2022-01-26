using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("enter any number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=10;i++)
            {
                Console.WriteLine(n+"x"+i+"="+n*i);
            }
            Console.ReadLine();

        }
    }
}
