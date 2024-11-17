using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class lines
    {
        public static void Main(string[] args)
        {
            string path = "C:\\dotnet training infinite\\c#\\c#.txt";

            
            
            if(File.Exists(path))
            {
                int count = File.ReadAllLines(path).Length;
                Console.WriteLine($"Path has {count} lines");

            }
            else
            {

                Console.WriteLine("Given path does not exist");
            }






        }

    }
}
