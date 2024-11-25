using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
        class Writer
        {
            public static void Main(String[] args)
            {
                string filePath = "C:\\dotnet training infinite\\Assessment\\Mohith.txt";
                Console.Write("Enter the text to append: ");
                string txt = Console.ReadLine();

                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(txt);
                }

                Console.WriteLine("Text appended successfully.");
                Console.WriteLine("Appended text:");
                Console.WriteLine(File.ReadAllText(filePath));

                
            }
        }
    }
   

