class Assign1
{

    public static void Main(String[] args)
    {
        Console.WriteLine(" enter the first number");
        int x=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        int y=Convert.ToInt32(Console.ReadLine());  

        Test_case.Test(x, y);




    }


}

class Test_case
{

    public static void Test(int x, int y)
    {
    
        if (x == y)
            Console.WriteLine("{0} and {1} are equal ",x,y);
    
    }
}
