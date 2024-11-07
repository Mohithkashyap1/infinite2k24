using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1_4
{
    internal class ADD__
    {


        static void Sum(int x, int y)
        { 
            if (x == y)
                Console.WriteLine($"{3*(x + y)}");
            else
                Console.WriteLine($"{x+y}");
            
        
        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int b=Convert.ToInt32(Console.ReadLine());

            Sum(a,b);




        }

    }
}
