using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Q1
{


    public static void Main(string[] args)
    {

        int[] arr1=new int[3];

        for(int i=0;i<arr1.Length;i++)
        {
            Console.WriteLine("Enter the numbers");
            arr1[i]=Convert.ToInt32(Console.ReadLine());
        }

        var output = arr1.Where(x => x * x > 20).Select(x => $"{x}-{x * x}");





        foreach(var z in output)
        {
            Console.WriteLine(z);
        }



    }






}


