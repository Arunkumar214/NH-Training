using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_List_string___add_5_values_using_3_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("arun");
            data.Add("rajesh");
            data.Add("Sai");
            data.Add("Kiran");
            data.Add("Kumar");
            for (int i=0;i<data.Count;i++)
            {
                Console.WriteLine(data[i]);

            }
            foreach (var d in data)
            {
                Console.WriteLine(d);
            }
            //Lamda Expression
            data.ForEach(p => Console.WriteLine(p));
            Console.ReadLine();
        }
    }
}
