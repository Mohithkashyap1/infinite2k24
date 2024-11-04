class Mul
{

    public static void Main(string[] args)
    {
        Console.WriteLine("enter the number for multiplication");
        int n=Convert.ToInt32(Console.ReadLine());

        int m = 10;

        for(int i=0; i<=m; i++)
        {

            Console.WriteLine($"{n} x {i}={i*n}");

        }






    }


}
