using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_List_t___read_and_find_sum_using_3_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum1 = 0, sum2 = 0, sum3 = 0, temp;
             //Reading values from the user
             for (int i=1;i<=5;i++)
             {
                Console.WriteLine("Enter the numbers");
                temp=Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
               
             }
             //using for loop 
             for (int i=0; i<data.Count;i++)
            
                sum1 = sum1 + data[i];
           
             //using foreach loop 
             foreach (var d in data)
            
                sum2 = sum2 + d; 
            
            //using Lamda Expression
            data.ForEach(p => sum3 = sum3 + p);


            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.ReadLine();
        }
    }
}
