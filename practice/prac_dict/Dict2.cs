using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_dict
{
    public class Dict2
    {


        public static void Main(string[] args)
        {

            Dictionary<string, string> d2 = new Dictionary<string, string>();

            d2.Add("EMP001", "DAMON");

            d2.Add("EMP002", "STEPHAN");

            d2.Add("EMP003", "ELENA");

            d2.Add("EMP004", "KLAUS");


            Console.WriteLine("enter the key");

            string k = Console.ReadLine();


            if (d2.ContainsKey(k))
            {
                Console.WriteLine(k+"-"+ d2[k]);

            }
            else
            {
                Console.WriteLine("Enter an appropriate key");

            }
        }


      
    }
}
