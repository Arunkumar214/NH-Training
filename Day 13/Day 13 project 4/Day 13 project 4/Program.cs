using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];

            //Reading the values from the user 
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter the required number at ({i},{j})");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

                //printing the values 
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(arr[i,j]+" ");
                       
                    }
                Console.Write("\n");

                }
            Console.ReadLine();
            }
        }
    }

