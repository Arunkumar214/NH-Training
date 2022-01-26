using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Sum_of_n_natural_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n, sum = 0;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32 (Console.ReadLine());
            for (i=1;i<=n;i++)   
                sum = sum + i;
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
