class Pos
{

    static void check(int b)
    {
        if (b >= 0)
            Console.WriteLine("The number is positive");
        else
            Console.WriteLine("The number is negative");

    }

    public static void Main(String[] args)
    {


        Console.WriteLine("Enter the number");
        int a=Convert.ToInt32 (Console.ReadLine());

        check(a);

    }



}