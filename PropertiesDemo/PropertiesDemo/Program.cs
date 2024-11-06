using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ans = 'Y';
            do
            {
                Employee emp = new Employee();

                //Console.WriteLine("Enter Employee ID");
                //emp.EmployeeID=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Employee Name");
                emp.EmployeeName = Console.ReadLine();

                Console.WriteLine("Enter city");
                emp.EmpCity = Console.ReadLine();


                Console.WriteLine("Enter Deptno");
                emp.Deptno = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Joining Date");
                emp.JoiningDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter your pin/password");
                emp.Password = Console.ReadLine();
                Console.Clear();
                
                Console.WriteLine("Enter Your password");
                emp.CheckPassword = Console.ReadLine();
                if (emp.isCorrect)
                {



                    Console.WriteLine($"Your Employee ID: {emp.EmployeeID}");
                    Console.WriteLine($"Employee Name: {emp.EmployeeName}");
                    Console.WriteLine($"Employee City: {emp.EmpCity}");
                    Console.WriteLine($"Deptno Of Employee: {emp.Deptno}");
                    Console.WriteLine($"Joining Date: {emp.JoiningDate}");
                }
                else
                {
                    Console.WriteLine("U cannot see the data.....");
                    Console.WriteLine("Now exiting the app...");
                    Environment.Exit(1);
                    
                }

                Console.WriteLine("Do u want to add more employees? Press 'Y' to continue...");
                ans = Convert.ToChar(Console.ReadLine());
            }
            while (ans == 'Y');

            Console.Read();

        }
    }
}
