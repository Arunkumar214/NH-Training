using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArunKLibrary;

namespace Consoleappp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Algebra.Factorial (-4));
            Console.WriteLine(Algebra.Palindrome(121));
            Console.ReadLine();
        }
    }
}
