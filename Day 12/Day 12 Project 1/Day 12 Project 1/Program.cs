using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12_Project_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("enter a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
            }
              catch (OverflowException e)
            {
                Console.WriteLine("Enter digits in the range of 9-99999");
                Console.ReadLine();
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("never divide a number with 0");
                Console.ReadLine();
            }

            catch (FormatException fe)
            {
                Console.WriteLine("only numbers dude");
                Console.ReadLine();
            }

            catch (Exception gh)
            {
                Console.WriteLine("Why late .. call customer care");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Well done boy");
                Console.ReadLine();
            }
        }
    }
}
