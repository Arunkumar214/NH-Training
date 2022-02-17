using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunKLibrary
{
    public class Algebra

    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return -9999;
            else

            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;

                }
                return fact;
            }
        }

        public static string Palindrome(int n)
        {
            int sum = 0;
            int r;
            int temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            if(temp==sum)
                return "Palindrome";
            else
                return "Not a Palindrome";

        }

    }        
}
 
