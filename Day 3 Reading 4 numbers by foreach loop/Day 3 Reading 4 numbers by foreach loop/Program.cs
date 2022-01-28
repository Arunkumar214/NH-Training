using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Reading_4_numbers_by_foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int []data = new int[4];
            //foreach loop is only used with arrays and conditionals
          

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter number");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
             foreach (int d in data)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
