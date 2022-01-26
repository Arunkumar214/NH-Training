using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_factorial_of_n_number_decrement_model
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, product = 1;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = n; i >= 1; i--)
            {
                product = product * i;

            }
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
