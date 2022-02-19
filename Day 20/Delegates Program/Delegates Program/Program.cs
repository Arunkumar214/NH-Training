using System;

namespace Delegates_Program
{
    //Author: Arun 
    //Purpose: Using Delegates in the program
   
    class Program
    {
        public delegate void Arun(int a, int b);

        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Adding and Multiplication");
            Arun a = new Arun(Add);
            a += Mul;
            a(6, 7);
            Console.WriteLine("Addition removal");
            a -= Add;
            a(3, 6);
            Console.ReadLine();
        }
    }
}
