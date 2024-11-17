using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_4
{
   internal class Employee
    {
        public int EmpId;
        public string EmpName;
        public float Salary;
       
        public Employee(int eid, string ename, float sal)
        {
            EmpId = eid;
            EmpName = ename;
            Salary = sal;
        }
        public void Display()
        {
            Console.WriteLine($"Id of Enployee is {EmpId} and name is {EmpName} and his (or) her salary is {Salary}");
        }
    }

    class PartTimeEmployee : Employee
    {
        int Wages;
        public PartTimeEmployee(int eid, string ename, float sal) : base(eid, ename, sal)
        {

        }
        public static void Main()
        {
            Console.Write("Enter employye id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Employee Name : ");
            string name = Console.ReadLine();
            
            Console.Write("Enter salary of employee : ");
            float salaryy = (float)Convert.ToInt32(Console.ReadLine());
            
            PartTimeEmployee p1 = new PartTimeEmployee(id, name, salaryy);
            p1.Display();
           
        }
    }

}
