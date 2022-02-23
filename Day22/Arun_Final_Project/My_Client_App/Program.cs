using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic_Layer;

namespace My_Client_App
{
    public class Program
    {
        public static void Add_Employee()
        {
            int id, salary, age;
            string name;
            Console.WriteLine("enter id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter age ");
            age = Convert.ToInt32(Console.ReadLine());

            //calling BLL

            var result = Employee_BLL.AddEmployee(id, name, salary, age);
            if(result)
            {
                Console.WriteLine("employee details saved");
                
            }
            else
            {
                Console.WriteLine("error occured");
            }
        }
        public static void GetEmpById()
        {
            int id;
            Console.WriteLine("Enter id");
            id=Convert.ToInt32(Console.ReadLine());
            var result=Employee_BLL.Get_Emp_By_Id(id);
            if (result.Count == 0)
                Console.WriteLine("No records");
            else
                result.ForEach(p => Console.WriteLine(p));
        }
        public static void GetEmpByName()
        {
            string name;
            Console.WriteLine("Enter name");
            name=Console.ReadLine();
            var result=Employee_BLL.Get_Emp_Byname(name);
            if(result.Count==0)
                Console.WriteLine("No name Found");

            else
               result.ForEach(p => Console.WriteLine(p));
            
        }
        public static void DisplayAllEmployees()
        {
            var result = Employee_BLL.Display_All_Employees();
            result.ToList().ForEach(r => Console.WriteLine(r));   
        }
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("Employee Management");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. search employee by id");
                Console.WriteLine("3. search employee by name");
                Console.WriteLine("4. display all employees");
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Add_Employee();
                        break;
                    case 2:
                        GetEmpById();
                        break;
                    case 3:
                        GetEmpByName();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("Do you want to Continue (y/n)");
                choice = Console.ReadLine();
            } while (choice.Equals("y"));
        }
    }
}
