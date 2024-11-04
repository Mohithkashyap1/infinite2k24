using System.Runtime.Intrinsics.X86;

class Array_op
{


    public static void Main(string[] args)
    {
        int sum = 0;
        int avg=0;

        int[] arr1 = { 45, 65, 78, 54, 87, 12 };

        foreach(int i in  arr1)
        {
            sum += i;

            avg= sum / arr1.Length;

            
            

        }

        Console.WriteLine(avg);
    }
}

