using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Min_Max
    {


        public static void Main(string[] args)
        {

            int[] arr = { 21, 32, 33, 45, 12, 25 };

            Array.Sort(arr);

            Console.WriteLine($"min value of array is {arr[0]}");
            Console.WriteLine($"max value of array is {arr[arr.Length - 1]}");

        }


    }
}
