class Q4
{
    public static int Count(string input, char let)
    {

        int count = 0;

        foreach (char c in input)
        {

            if (c == let) count++;

        }

        return count;

    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the string");
        string f= Console.ReadLine();

        Console.WriteLine("Enter the letter to be counted");
        char letter=Console.ReadKey().KeyChar;

        int occurences=Count(f,letter);

        Console.WriteLine($"The letter {f} appears {occurences} time");

    }



}