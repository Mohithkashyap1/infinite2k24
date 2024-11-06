class Q3
{

    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the first number");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number");
        int c = Convert.ToInt32(Console.ReadLine());


        if (a > b && a > c)
        {
            Console.WriteLine($"{a} is the greatest integer");
        }
        else if (b > a && b > c)
        {

            Console.WriteLine($"{b} is the greatest interger");

        }
        else
        {
            Console.WriteLine($"{c} is the greatest integer");
        }


    }

}
