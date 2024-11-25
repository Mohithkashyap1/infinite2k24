using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class words
    {

        public static void Main(string[] args)
        {
            string[] arr2 = new string[3];

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("Enter the words");
                arr2[i] = Console.ReadLine();

             
                

               



            }

            var output = arr2.Where(y => y.StartsWith("a") && y.EndsWith("m"));

            foreach (var x in output)
            {
                Console.WriteLine("");
                Console.WriteLine("The word is {0}",x);
            }



        }
    }
}
