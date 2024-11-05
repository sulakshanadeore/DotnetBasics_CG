using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibraryForCalculator;

namespace FirstDemo_BasicsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User Interface

            //int empid=Employee.GenerateEmployeeID();
            //Console.WriteLine(empid);
            //empid = Employee.GenerateEmployeeID();
            //Console.WriteLine(empid);
            //empid = Employee.GenerateEmployeeID();
            //Console.WriteLine(empid);
            //empid = Employee.GenerateEmployeeID();
            //Console.WriteLine(empid);
            //empid = Employee.GenerateEmployeeID();
            //Console.WriteLine(empid);
            //empid = Employee.GenerateEmployeeID();
            //Console.WriteLine(empid);

            Employee emp = new Employee();
            Console.WriteLine("Enter employeename");
            string _ename=Console.ReadLine();
            Console.WriteLine("Enter city");
            string _city=Console.ReadLine();
            Console.WriteLine("Enter sal");
            float _sal=Convert.ToSingle(Console.ReadLine());
            emp.AcceptEmpDetails(_ename, _city, _sal);
           
            
            emp.ShowEmpDetails();


            

            Console.ReadLine();
        }
    }
}
