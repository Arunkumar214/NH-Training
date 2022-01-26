using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Switch_program
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = 'o'; 
           switch(input)
                {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("the input is vowel");
                    break;
                default:
                    Console.WriteLine("consonent");
                    break;
                            }
            Console.ReadLine(); 

        }
    }
}
