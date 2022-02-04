using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Project1
{
    //Author: Arun 
    //Program: Printing even numbers. 
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 34, 75, 65, 27, 88, 90 };
            
            //for loop 
            for (int i=0;i<data.Count;i++)
            {
                if (data[i]%2==0)
                    Console.WriteLine(data[i]);
            }
            //foreach loop
            foreach(var d in data)
            {
                if(d%2==0)
                    Console.WriteLine(d);
            }
            //Lamda expression 
            data.Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine(d));

            //LINQ Query
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));

            Console.ReadLine();
        }
    }
}
