class ParameterArray
{


    public int MulElements(params int[] arr)
    {
        int mul = 1;

        foreach(int i in arr)
        {  mul *= i; }
        return mul;
    
     
    
    }




    public static void Main(String[] args)
    {
        ParameterArray PA= new ParameterArray();

        Console.WriteLine("Enter the number");

        int x=PA.MulElements(23,23,43,43,1,2,3);

        Console.WriteLine(x);
    }




}
