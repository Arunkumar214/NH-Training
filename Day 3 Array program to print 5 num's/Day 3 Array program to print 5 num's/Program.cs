using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Array_program_to_print_5_num_s
{
    class Program
    {
        static void Main(string[] args)
        {
            int Avg, 
                sum = 0;
            int[] data = new int[5];
            Console.WriteLine("Enter first number");
            data[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            data[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            data[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter four number");
            data[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter five number");
            data[4] = Convert.ToInt32(Console.ReadLine());

            sum = data[0] + data[1] + data[2] + data[3] + data[4];
            Console.WriteLine(sum);
            Avg = sum / 5;
            Console.WriteLine(Avg);
            Console.ReadLine();

            /*using for loop 
               for (i=0;i<data.length;i++)
            {Console.WriteLine("enter the number")
            data[i]=Console.ReadLine();
            for(i=0;i<data.Length;i++)
            {
            sum=sum+data[i];
            }
            Console.WriteLine(sum);}   */
        }
    }
}
