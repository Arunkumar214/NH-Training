using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 97; 
            for (int i=1000; i<=1097; i++)
            {
                if (i%n==0)
                {
                    Console.WriteLine(i);
                    break; 
                }
                Console.ReadLine();
            }
        }
    }
}
