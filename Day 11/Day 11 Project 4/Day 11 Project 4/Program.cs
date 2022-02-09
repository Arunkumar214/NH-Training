using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Project_4
{
    class Mathematics
    {
        public static int add(int a, int b)
        {
            return a + b; 
        }

        public static int sub(int a, int b)
        {
            return a - b; 
        }

        public static int mul(int a,int b)
        {
            return a * b; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            Console.WriteLine(Mathematics.add(5,7));
            Console.WriteLine(Mathematics .sub(6,3));
            Console.WriteLine(Mathematics.mul(2,2));
        }
    }
}
