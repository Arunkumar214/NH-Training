using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 30; 
            for (int i=1; i<=n; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
               
            }
            Console.ReadLine();
        } 
    }
}
