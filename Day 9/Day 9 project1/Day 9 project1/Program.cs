using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_project1
{
    class Mathsoperations
    {
        private int input; 

        public void Readinput()
        {
            Console.WriteLine("Enter the number");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public void Factorial()
        {
            int fact = 1; 
            for (int i=1;i<=input; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }

        public void Printfactors()
        {
            for(int i=1;i<=input;i++)
            {
                if (input%i==0)
                    Console.WriteLine(i);
            }
        }

        public bool Isprime()
        {
            int count = 0; 
            for (int i=1;i<=input;i++)
            {
                if (input%i==0)
                    count++;

            }
            if (count == 2)
                return true;
            else
                return false; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathsoperations obj = new Mathsoperations();
            obj.Readinput();
            obj.Factorial();
            obj.Printfactors();
            if(obj.Isprime())
                Console.WriteLine("Input is prime");
            else
                Console.WriteLine("Input is not prime");

            Console.ReadLine();

        }
    }
}
