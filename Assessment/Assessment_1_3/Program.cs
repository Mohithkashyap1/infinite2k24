class Q1
{

    public static string Del(string input, int pos)
    {
        if(pos<0 || pos>=input.Length)
        {
            Console.WriteLine("invalid");
            return input;
        }

        return input.Substring(0, pos) + input.Substring(pos + 1);
    }

    public static void Main(string[] args)
    {

        Console.WriteLine("Enter a String");
        String g = Console.ReadLine();

        Console.WriteLine("Enter the position of the String to be Removed");
        int a=Convert.ToInt32(Console.ReadLine());

        String result=Del(g, a);

        Console.WriteLine(result);




    }



}
