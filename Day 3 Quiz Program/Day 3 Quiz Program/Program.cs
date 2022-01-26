using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Quiz_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("hi {0}, welcome to quiz by arun",name);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
           
            Console.WriteLine("Q1. who is the hero in Bahubali:");
            Console.WriteLine("1.Charan  2.Sai  3.Vinay  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            Console.WriteLine("Q2. who is the hero in brucelee:");
            Console.WriteLine("1.Charan  2.Sai  3.Vinay  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;

            Console.WriteLine("Q3. who is the hero in black and white:");
            Console.WriteLine("1.Charan  2.Sai  3.Vinay  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;


            Console.WriteLine("Q4. who is the hero in solo brathuke:");
            Console.WriteLine("1.Charan  2.Dharam  3.Vinay  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;

            Console.WriteLine("Q1. who is the hero in Bahubali:");
            Console.WriteLine("1.Charan  2.Sai  3.Vinay  4.Prabhas");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;

            if(score>=60)
                Console.WriteLine("congratulations {0}, you got {1}% in the exam",name,score);
            else
                Console.WriteLine("Better luck next time");
            Console.ReadLine();
        }
        
    }
}
