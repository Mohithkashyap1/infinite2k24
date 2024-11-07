using System;

class Arr
{


    public static void Main(string[] args)
    {

        int Total = 0;

        int avg = 0;

        int[] arry = new int[10];

        for (int i = 0; i < arry.Length; i++)
        {

            arry[i] = Convert.ToInt32(Console.In.ReadLine());

        }
        for (int i = 0; i < arry.Length; i++)
        {
            Total += arry[i];
         

        }

        avg = Total / arry.Length;

        Console.WriteLine($"Average = {avg}");

        Array.Sort( arry );

        foreach (int i in arry)
        {
            Console.Write(i +" ," );
        }


        Console.WriteLine(" ");


        Array.Reverse( arry );

        foreach(int i in arry)
        {
            Console.Write(i + " ,");
        }

        Console.WriteLine(" ");

        Console.WriteLine($"Maximum marks = {arry[arry.Length - 1]}");

        Console.WriteLine($"Minimum marks = {arry[0]}");

       



    }


}
