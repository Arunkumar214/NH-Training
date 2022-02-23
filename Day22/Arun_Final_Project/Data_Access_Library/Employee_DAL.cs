using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data_Access_Library
{
    //Author: Arun 
    //Purpose: To create a employee management app
    public class Employee_DAL
    {
        public static  string filepath = "C:\\Users\\91832\\Desktop\\Arun_Final_Project\\File.txt.txt";
        /// <summary>
        /// This method is used to add employees
        /// </summary>
        /// <param name="empid"></param>
        /// <param name="empname"></param>
        /// <param name="empsalary"></param>
        /// <param name="empage"></param>
        /// <returns> Either True or False </returns>
        public static bool Add_Employee(int empid, string empname, int empsalary, int empage)
        {
            //Code which appends data is as follows: 
            try 
            {
                string textcontent= string.Concat (empid, ",", empname, "," , empsalary, "," , empage);
                File.AppendAllText(filepath, textcontent+Environment.NewLine );
                return true; 
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// method searches for employee through id
        /// </summary>
        /// <param name="empid"></param>
        /// <returns></returns>
        public static List<string> Get_Emp_By_Id(int empid)
        {
            var allEmployees=File.ReadAllLines (filepath);
            bool isFound = false; 
            List<string> employees = new List<string> ();   
            foreach (string emp in allEmployees)
            {
                var employeeDetails = emp.Split(',');
                if (Convert.ToInt32(employeeDetails[0]) == empid)
                {
                    isFound = true;
                    employees.Add(emp);
                    break;
                }

            }
            return employees;
        }
        /// <summary>
        /// searching employees through name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>employees with the given name</returns>
        public static List<string> Get_Emp_Byname(string name)
        {
            var allEmployees = File.ReadAllLines(filepath);
            List<string> employees = new List<string>();
            foreach (string emp in allEmployees)
            {
                var employeeDetails = emp.Split(',');
                if  (employeeDetails[1].Contains(name))             
                employees.Add(emp);
                

            }
            return employees;
        }

        public static String[] Display_All_Employees()
        {
            var allEmployees = File.ReadAllLines (filepath);
            return allEmployees;
        }
    }
}
