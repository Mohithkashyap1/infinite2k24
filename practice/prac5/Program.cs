class Inputarray
{

    public static int AddElements(params int[] arr)
    {

        int Sum = 0;

        foreach (var x in arr)
        { 
            Sum+= x;    
        }
        return Sum;
    
    
    
    }




    public static void Main(String[] args)
    {


        int[] arr1= new int[4];

        Console.WriteLine("write down the numbers");

        for(int i=0;i<arr1.Length;i++)
        {
            arr1[i]=Convert.ToInt32(Console.In.ReadLine());
        }

        int gee= AddElements(arr1);

        Console.WriteLine(gee);

    }


}
