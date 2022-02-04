using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_project4
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> pro = new List<Product>()
            {
                new Product(){id=11,name="wallet",price=100,brand="Levis"},
                new Product(){id=12,name="shoes",price=350,brand="bata"},
                new Product(){id=13,name="shirt",price=450,brand="roadster"},
                new Product(){id=14,name="geyser",price=3000,brand="AO Smith"},

            };


            //for loop 
            for (int i=0;i<pro.Count;i++)
            {
               if(pro[i].price>500)
                    Console.WriteLine($"name={pro[i].name},brand={pro[i].brand}");
            }
            
           //foreach loop 
            foreach(var p in pro)
            {
                if (p.price>500)
                Console.WriteLine($"name={p.name},brand={p.brand}");
            }

            //Lamda Expression
            pro.ToList().Where(p => p.price > 500).ToList().ForEach(p => Console.WriteLine($"name={p.name},brand={p.brand}"));
            //LINQ Query  
            var result = from p in pro
                         where p.price > 500
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"name={p.name},brand={p.brand}"));


            Console.ReadLine();
           
        }
    }
}
