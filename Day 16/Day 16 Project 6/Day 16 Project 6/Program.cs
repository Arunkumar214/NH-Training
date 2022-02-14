using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_6
{
    class Palindrome
    {
        int sum = 0;
        int remainder;
        int n, temp;

        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
        }
         public void PrintData()
        {
             temp = n;
            while(n>0)
            {
                remainder = n % 10;
                sum = sum * 10 + remainder;
                n = n / 10;
            }
            if(temp==sum)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("not a Palindrome");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            p.ReadData();
            p.PrintData();
            Console.ReadLine();
        }
        
    }
    
}
