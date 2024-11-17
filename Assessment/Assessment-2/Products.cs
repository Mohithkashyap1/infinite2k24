using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    class Products
    {

        public int PID { get; set; }

        public string PName { get; set; }

        public double price { get; set; }


    }


    class Sorting
    {

        public static void Main(string[] args)
        {

            Products[] p = new Products[10];

            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("Enter the Product Name");
                string input = Console.ReadLine();


                Console.WriteLine("Enter the Product ID's");
                int product_ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Price of the Product");
                double price = Convert.ToDouble(Console.ReadLine());

                p[i] = new Products { PID = product_ID, PName = input, price = price };

            }

            Array.Sort(p, (x,y)=>x.price.CompareTo(y.price));

            Console.WriteLine("Sorted Products");



            foreach (var Products in p)
            {
                Console.WriteLine($"{p}");
            }







        }

    }
}
