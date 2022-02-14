using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArunLibrary1;
using PublicLibrary1; 

namespace Clientapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.Addition(3,5);
            m.Multiplication(3, 5);

            Chemistry c = new Chemistry();
            Console.WriteLine(c.Benzene());
            Console.WriteLine(c.Methane()); 

            Console.ReadLine();

        }
    }
}
