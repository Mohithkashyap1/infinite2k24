using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_1
{
    class Pos_neg
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            Demo(a);

        }

        public static void Demo(int x)
        {
            if (x >= 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Negative");
        
        }






    }
}
