using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_declaring_list___assign_some_values_and_find_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
              int sum = 0;
            data.Add(5);
            data.Add(10);
            data.Add(15);
            data.Add(20);
            data.Add(25);
             foreach (var d in data)
            {
                sum = sum + d;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
