using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_4
{
    public interface IStudent
    {
        int Student_Id { get; set; }
        string Name { get; set; }
        void show_details();
    }


    class Day_Scholar : IStudent
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }
        public void show_details()
        {
            Console.WriteLine($"Student id is {Student_Id} Student name {Name}");
        }

    }
    class Resident : IStudent
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }
        public void show_details()
        {
            Console.WriteLine($"Student id is {Student_Id} Student Name : {Name}");
        }
    }


    class Interface
    {
        static void Main(string[]args)
        {
            Console.WriteLine("    Day Scholar Student Details  ");
            Console.Write("Enter Student Id : ");
            int sid1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Student name : ");
            string stud_name1 = Console.ReadLine();

            
            Console.WriteLine("   Resident Student Details   ");
            
            Console.Write("Enter Student Id : ");
            int sid2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Student name : ");
            string stud_name2 = Console.ReadLine();


            IStudent d = new Day_Scholar();
            d.Student_Id = sid1;
            d.Name = stud_name1;
            
            Console.WriteLine("   Day Scholar Details     ");
            d.show_details();

            IStudent r = new Resident();
            r.Student_Id = sid2;
            r.Name = stud_name2;
            
            Console.WriteLine("*** Resident students details ***");
            r.show_details();
          

        }

    }
}
