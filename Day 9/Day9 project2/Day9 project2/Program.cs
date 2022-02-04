using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_project2
{
    class MathTask
    {
        private int a;
        private int b; 

        public void Readinput()
        {
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());

        }
        public int Addnumbers()
        {
            return a + b;
        }
        public int Subtractnumbers()
        {
            return a - b;
        }
        public int Multiplynumbers()
        {
            return a * b; 
        }
        public int Dividenumbers()
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathTask mt = new MathTask();
            mt.Readinput();
            Console.WriteLine(mt.Addnumbers());
            Console.WriteLine(mt.Subtractnumbers());
            Console.WriteLine(mt.Multiplynumbers());
            Console.WriteLine(mt.Dividenumbers());

            Console.ReadLine();
        }
    }
}
