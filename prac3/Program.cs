class Outparameter
{

    public static void Main(String[] args)
    {
        int total, prod, div;

        int difference=calci(20,5,out total,out prod,out div);

        Console.WriteLine($" {total},{prod},{div},{difference}");

    }


    static int calci(int x, int y, out int sum, out int mul, out int div)
    {

        sum = x + y;
        mul = x * y;
        div = x / y;
        return x - y;

    }



}
