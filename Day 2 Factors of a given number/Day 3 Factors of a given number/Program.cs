using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Factors_of_a_given_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter the number");
            n =Convert.ToInt32( Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
