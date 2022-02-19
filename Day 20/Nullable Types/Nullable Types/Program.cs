using System;

namespace Nullable_Types
{
    //Author: Arun 
    //Purpose: Nullable types 
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;

            if (i.HasValue)
                Console.WriteLine(i);
            else
                Console.WriteLine("No value");
            Console.ReadLine();
           
        }
    }
}
