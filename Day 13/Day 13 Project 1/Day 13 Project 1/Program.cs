﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2,2];
            data[0, 0] = 5;
            data[0, 1] = 6;
            data[1, 0] = 7;
            data[1, 1] = 8;
            
            for (int i=0;i<2;i++)
            {
                for (int j=0;j<2;j++)
                {
                    Console.Write(data[i, j]+ " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
           
        }
    }
}
