using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arun_Library; 

namespace Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            Console.WriteLine(m.Addition(8, 9));

            Console.WriteLine(m.subtraction(8, 2)) ;


            Physics p = new Physics();
            {
              p.TotalVelocity(5, 6, 5);
            }


            Chemistry c = new Chemistry();
            c.Benzene();
            c.Water();
            c.Methane();

            Console.ReadLine();


        }
    }
}
