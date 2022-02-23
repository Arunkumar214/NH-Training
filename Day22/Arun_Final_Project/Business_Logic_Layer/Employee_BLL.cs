using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Library; 


namespace Business_Logic_Layer
{
    public static class Employee_BLL
    {
        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
        IsnegoRrepeat:
            var st = Employee_DAL.filepath;
            bool verify = false;
            int emp_id;
            var allEmployees = File.ReadAllLines(st);
            foreach (var employee in allEmployees)
            {
                var emp_split = employee.Split(',');
                if (emp_split[0] == empid.ToString())
                {
                    verify = true;
                    break;
                }
            }
            if (empid<=0||verify)
            {
                Console.WriteLine("Check the enter value greater than zero and number should not be repeated");
                goto IsnegoRrepeat;
            }
            
            else
            {
                emp_id = empid;
            }
            string emp_name;
        NameCheck:
            if(empname.Length<3)
            {
                Console.WriteLine("Enter minimum # characters");
                goto NameCheck;
            }
            else
            {
                emp_name = empname;
            }
        int emp_salary;
            SalaryCheck:
            if(empsalary<12000)
            {
                Console.WriteLine("Enter salary Above 12000");
                goto SalaryCheck;
            }
            else
            {
                emp_salary = empsalary;
            }
            int emp_age;
            AgeCheck:
            if(empage<18||empage>58)
            {
                Console.WriteLine("Enter age above 18 and below 58");
                goto AgeCheck;
            }
            else
            {
                emp_age = empage;
            }
            // to do things 
            var result = Employee_DAL.Add_Employee(emp_id, emp_name, emp_salary, emp_age);
            return result; 

            

            //all success then call Data access layer 
        }

        public static List<string> Get_Emp_By_Id(int id)
        {
            var result = Employee_DAL.Get_Emp_By_Id(id);
            return result; 
        }

        public static  List<string> Get_Emp_Byname(string name)
        {
            var result= Employee_DAL .Get_Emp_Byname(name);
            return result; 
        }

        public static string [] Display_All_Employees()
        {
            var result = Employee_DAL .Display_All_Employees();
            return result; 
        }
    }
}
