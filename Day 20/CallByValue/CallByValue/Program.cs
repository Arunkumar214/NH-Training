using System;

namespace CallByValue
{
    class Program
    {
        public static void Add(out int p, out int q)
        {
            p = 30;
            q = 4;

        }
        static void Main(string[] args)
        {
            int i, j;
            Add(out i, out j);
            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.ReadLine();


        }
    }
}
