using Consolee1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolee1
{
    //Author: Arun  

    //Purpose: Creating a web service and console application to consume that webservice  
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient ws = new WebService1SoapClient ();

            Console.WriteLine(ws.Factorial (5));
            Console.WriteLine(ws.Add (2,2));
            Console.WriteLine(ws.Mul(2, 2));
            Console.WriteLine(ws.Div (2, 2));

            Console.ReadLine();
        }
    }
}
