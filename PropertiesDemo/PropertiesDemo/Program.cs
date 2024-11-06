using System;
using System.Threading;

namespace PropertiesDemo
{
    internal class Program
    {
        public static void SwapNos(int fno, int sno)
        {
            int tno = fno;
            fno = sno;
            sno = tno;
            Console.WriteLine($"After the swapping,First Number={fno}");
            Console.WriteLine($"After the swapping, Second Number={sno}");
        }


        public static void SwapNosAddress(ref int fno, ref int sno)
        {
            int tno = fno;
            fno = sno;
            sno = tno;
            Console.WriteLine($"After the swapping,First Number={fno}");
            Console.WriteLine($"After the swapping, Second Number={sno}");
        }


        static void Main(string[] args)
        {
            // workingWithProperties();
            int fno = 10;
            int sno = 20;
            
            Console.WriteLine($"Now the value of fno={fno}");
            Console.WriteLine($"Now the value of sno{sno}");

            //SwapNos(fno, sno);
            SwapNosAddress(ref fno,ref sno);
            Console.WriteLine($"Now the value of fno={fno}");
            Console.WriteLine($"Now the value of sno{sno}");


            Console.Read();

        }

        private static void workingWithProperties()
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
                    Employee empdetails = emp.DisplayEmployeeDetails();

                    Console.WriteLine($"Your Employee ID: {empdetails.EmployeeID}");
                    Console.WriteLine($"Employee Name: {empdetails.EmployeeName}");
                    Console.WriteLine($"Employee City: {empdetails.EmpCity}");
                    Console.WriteLine($"Deptno Of Employee: {empdetails.Deptno}");
                    Console.WriteLine($"Joining Date: {empdetails.JoiningDate}");
                }
                else
                {
                    Console.WriteLine("U cannot see the data.....");
                    Console.WriteLine("Now exiting the app...");

                    Thread.Sleep(2000);
                    Environment.Exit(1);

                }

                Console.WriteLine("Do u want to add more employees? Press 'Y' to continue...");
                ans = Convert.ToChar(Console.ReadLine());
                if (ans == 'N')
                {
                    Environment.Exit(1);
                }
            }
            while (ans == 'Y');
        }
    }
}
