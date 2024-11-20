using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    internal class Box
    {
        public int Length {  get; set; }
        public int Breadth {  get; set; }

        public Box(int Length,int Breadth)
        { 
            this.Length = Length;
            this.Breadth = Breadth;
        
        
        }
        public Box Add(Box box2)
        {

            Box sum =new Box(this.Length + box2.Length,this.Breadth+box2.Breadth);

            return sum;

        }

        public void Display()
        {
            Console.WriteLine($"Box Length = {Length}");

            Console.WriteLine($"Box Width = {Breadth}");

        }



    }

    class Test
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Length of box 1 :");
            int l1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Breadth of Box 1:");
            int b1=Convert.ToInt32(Console.ReadLine());

            Box box1 = new Box(l1,b1);



            Console.WriteLine("Enter Length of box 2 :");
            int l2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Breadth of Box 2:");
            int b2 = Convert.ToInt32(Console.ReadLine());

            Box box2 = new Box(l2, b2);

            Box box3 = box1.Add(box2);

            box3.Display();

           
        }






    }
}
