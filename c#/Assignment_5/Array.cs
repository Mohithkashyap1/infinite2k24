using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Array
    {

        public static void Main(string[] args)
        {

            string[] str = new string[5];

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"Enter string {i+1}:");
                str[i] = Console.ReadLine();
            }


            FileStream fs = new FileStream("file.txt", FileMode.Create, FileAccess.Write);

            StreamWriter sw= new StreamWriter(fs);

            foreach(string s in str)
            {
                sw.WriteLine(s);

            }

            Console.WriteLine("Written to the file successfuly");

            sw.Flush();
            sw.Close();
            fs.Close();





        }




    }
}
