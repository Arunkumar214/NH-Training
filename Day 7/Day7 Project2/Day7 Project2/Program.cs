using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer_class Cst = new Customer_class();
            Cst. ReadCustomers();
            Cst. PrintCustomers();

            Product Pdt = new Product();
            Pdt.ReadProduct();
            Pdt.PrintProduct();

            Seller_Class Sell = new Seller_Class();
            Sell.ReadSeller();
            Sell.PrintSeller();

            Department Dpt = new Department();
            Dpt.ReadDepartment();
            Dpt.PrintDepartment();

            Console.ReadLine();
            
         
        } 
    }
}
