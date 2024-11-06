using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public class Employee
    {
        static int EmpCnt = 1000;


        private int _empid;
        public int EmployeeID {
            get 
            {
                //reading the value from the variable
                
                _empid = EmpCnt + 1;
                EmpCnt = _empid;
            return _empid;
            }
            private set
            {
                //writing the value to the varibale
                _empid = value;

            }

        }

        private string _password;
        public string Password {
            set { _password = value; }


        }

        private string _Checkpassword;
        public string CheckPassword
        {
            set
            {
                _Checkpassword = value;
                if (_password == _Checkpassword)
                {
                    //Console.WriteLine("U entered it correct....");
                    isCorrect = true;

                }
                else
                {
                    //Console.WriteLine("Wrong Password...");
                    isCorrect=false;
                }

            }
        }

        bool _iscorrect;
        public bool isCorrect {
            set { _iscorrect = value; }
            get { return _iscorrect; }
        
        }


        public Employee DisplayEmployeeDetails()
        {
            Employee edata = new Employee();
            edata.EmployeeID = EmployeeID;
            edata.EmployeeName = EmployeeName;
            edata.EmpCity = EmpCity;
            edata.Deptno = Deptno;

            return edata;
        }




        private string _ename;

        public string EmployeeName
        {
            get { return _ename; }
            set 
            {
                if (string.IsNullOrEmpty(value) || (value.Length<5))
                {
                    Console.WriteLine("Not a valid value");
                    Console.ReadLine();
                }
                else
                {
                    _ename = value;
                }
            
            }
        }


        private string _city;
        

        public string EmpCity//fully implemented, validations
        {
            get { return _city; }
            set { _city = value; }
        }


        public int Deptno { get; set; }//auto-implemented , just accept & display

        public DateTime JoiningDate { get; set; }


        //Readonly--- only set code is available
        //Writeonly---only get code is available
        //ReadWrite---set and get code is available













    }
}
