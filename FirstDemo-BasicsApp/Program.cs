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

            //Employee emp = new Employee();
            //Console.WriteLine("Enter employeename");
            //string _ename=Console.ReadLine();
            //Console.WriteLine("Enter city");
            //string _city=Console.ReadLine();
            //Console.WriteLine("Enter sal");
            //float _sal=Convert.ToSingle(Console.ReadLine());
            //Employee.AcceptEmpDetails(_ename, _city, _sal);
           
            
            //emp.ShowEmpDetails();

            
            Console.WriteLine("Enter movie name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the ticketid");
            int ticketId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter seat number");
            string seatNo=Console.ReadLine();   
            MovieClass m=new MovieClass();    
           MovieClass details= m.ReturnMovieDetails(name,ticketId,seatNo);
            Console.WriteLine(MovieClass.moviename);
            Console.WriteLine(details.ticketId);
            Console.WriteLine(details.seatNumber);



            

            Console.ReadLine();
        }
    }
}
