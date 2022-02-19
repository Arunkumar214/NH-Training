using System;

namespace CallByReference
{
    class Program
    {
        public static void Add(ref int b)
        {

            b= b*b;
            Console.WriteLine("inside method:" + b);
        }

        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("Before value" + a);
            Add(ref a);
            Console.WriteLine("After value" + a);
            Console.ReadLine();

        }
    }
}
