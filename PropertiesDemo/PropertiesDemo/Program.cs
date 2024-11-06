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


        //Out parameters
        public static void CalculateSquareCube(int no,out int squareOutput,out int cubeOutput)
        {
            squareOutput = no * no;
            cubeOutput = no * no * no;
            
        
        }


        public static int CalculateSquareCubeUsingOutParameter(int no, out int cubeOutput)
        {
          int  squareOutput = no * no;
            cubeOutput = no * no * no;
            return squareOutput;

        }

        public static void SquareRoot(int no, out int sqRoot,out int square)
        { 
        sqRoot=Convert.ToInt32(Math.Sqrt(no));
            square = no * no;

        }

        static void Main(string[] args)
        {
            // workingWithProperties();

            int rt,sq;
            SquareRoot(100, out  rt, out  sq);
            Console.WriteLine("Squre Root=" + rt);
            Console.WriteLine("Squre =" + sq);

            Console.WriteLine("-----------");
            int input = 10;
            CalculateSquareCube(input, out int sq_op, out int cube_op);
            Console.WriteLine(sq_op);
            Console.WriteLine(cube_op);

            Console.WriteLine("***Using single output parameter***");
            int SquareAns=CalculateSquareCubeUsingOutParameter(input,out int cubeAnswer);
            Console.WriteLine("Square= " +SquareAns);
            Console.WriteLine("Cube=" + cubeAnswer);



            Console.WriteLine("============");
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
