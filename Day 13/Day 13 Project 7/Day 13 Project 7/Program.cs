using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int> ();
            data.Push(15);
            data.Push(21);
            data.Push(19);

            Console.WriteLine(data.Count );
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count);

            Console.ReadLine();
        }
    }
}
