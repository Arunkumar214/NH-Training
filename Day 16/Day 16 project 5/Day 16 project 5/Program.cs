using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_project_5
{
    public class MulTable
    {
        public int n;  
        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
           
        }

        public void PrintData()
        {
            for (int i=0;i<=10;i++)
            {
                Console.WriteLine(n + "x" + i +"=" + n*i);
            }
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MulTable m = new MulTable();
            m.ReadData();
            m.PrintData(); 

        }
    }
}
