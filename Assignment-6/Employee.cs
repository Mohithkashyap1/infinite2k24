using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class Employee
    {
        public int EmpID {  get; set; }

        public string EmpName { get; set; }

        public string EmpCity { get; set; }

        public double Salary {  get; set; }

    }


    class Example
    {

        public static void Main(string[] args)
        {

             List<Employee> l1=new List<Employee>();

            l1.Add(new Employee{EmpID = 101,EmpName="Harvey",EmpCity="Bengaluru",Salary=58982});
           
            l1.Add(new Employee{EmpID = 102,EmpName="Damon",EmpCity="Bengaluru",Salary=43500 });
            
            l1.Add(new Employee{EmpID = 103,EmpName="Charlie",EmpCity="Mumbai",Salary=49709 });
            
            l1.Add(new Employee{EmpID = 101,EmpName="Mike",EmpCity="NewYork",Salary=34587});
            
            l1.Add(new Employee{EmpID = 101,EmpName="Alaric",EmpCity="LosAngeles",Salary=56000 });


            Console.WriteLine("---------------All Employee Data---------------");
            
            foreach (var emp in l1)
            {
                Console.WriteLine($"Employee ID:{emp.EmpID}, Employee Name:{emp.EmpName}, Employee City:{emp.EmpCity}, Employee Salary:{emp.Salary}");

            }


            Console.WriteLine("Employee data whose salary is greater than 45000");

            foreach(var Maxsal in l1.Where(e=>e.Salary>45000))
            {
                Console.WriteLine($"Employee ID:{Maxsal.EmpID}, Employee Name:{Maxsal.EmpName}, Employee City:{Maxsal.EmpCity}, Employee Salary:{Maxsal.Salary}");
            }

            Console.WriteLine("Employees data who belong to Bengaluru Region");

            foreach(var city in l1.Where(c=>c.EmpCity=="Bengaluru"))
            {
                Console.WriteLine($"Employee ID:{city.EmpID}, Employee Name:{city.EmpName}, Employee City:{city.EmpCity}, Employee Salary:{city.Salary}");
            }


            Console.WriteLine("Employees data by their names is Ascending order");

            foreach(var asc in l1.OrderBy(a=>a.EmpName))
            {
                Console.WriteLine($"Employee ID:{asc.EmpID}, Employee Name:{asc.EmpName}, Employee City:{asc.EmpCity}, Employee Salary:{asc.Salary}");
            }
        }
    }






}
