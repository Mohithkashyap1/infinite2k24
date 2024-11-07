class Calci
{


       public static void Main(string[] args)
    {

        Char grad;

        int a, b;

        Console.WriteLine("Enter the first number");
        a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        b=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operation to be performed: a)Add b)Sub c)Mul d)Div");
        grad=Convert.ToChar(Console.ReadLine());

        switch (grad)
        {

            case 'a':
                Console.WriteLine(a + b);
                break;
            case 'b':
                Console.WriteLine(a - b);
                break;
            case 'c':
                Console.WriteLine(a * b);
                break;
            case 'd':
                Console.WriteLine(a / b);
                break;
            default:
                Console.WriteLine("please enter the correct option");
                break;
        }

    }

}