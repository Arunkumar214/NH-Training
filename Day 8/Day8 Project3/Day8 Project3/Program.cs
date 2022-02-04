using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Project3
{
    //Author: Arun 
    //Program: Own class with own variables and calling for,foreach,Lamda,LINQ
    class Office
    {
        public string name;
        public string location;
        public string type;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Office> off = new List<Office>()
                {
            new Office(){name="nbhealthcare",location="Madhapur",type="IT"},
            new Office(){name="eenadu",location="Irrummanzil",type="Paper"},
            new Office(){name="byjus",location="jubliee hills",type="education"},
            new Office(){name="sutherland",location="Lanco hills",type="IT"},
            new Office(){name="accenture",location="Mindspace",type="IT"},
            };


            //for loop
            for(int i=0;i<off.Count;i++)
            {
                Console.WriteLine($"name={off[i].name},location={off[i].location},type={off[i].type}");
            }

            //foreach loop 
            foreach(var o in off)
            {
                Console.WriteLine($"name={o.name},location={o.location},type={o.type}");
            }

            //Lamda Expression

            off.ToList().ForEach(o => Console.WriteLine($"name={o.name},location={o.location},type={o.type}"));

            //LINQ Query
            var result = from o in off
                         select o;
            result.ToList().ForEach(o => Console.WriteLine($"name={o.name},location={o.location},type={o.type}"));

            Console.ReadLine();



        }
    }
}
