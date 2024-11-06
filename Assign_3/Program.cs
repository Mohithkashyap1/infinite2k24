class Q1
{


    public static void Main(string[] args)
    {
        Console.WriteLine("What's on your mind?");
        String m= Console.ReadLine();

        Console.WriteLine("Length :");

        Console.WriteLine(m.Length);

        Console.WriteLine("======================================================");


       
        Console.WriteLine("Lets Reverse this");
        char[] arr= m.ToCharArray();

        Array.Reverse(arr);

        Console.WriteLine(arr);



        Console.WriteLine("Enter the 1st word");
        String g= Console.ReadLine();

        Console.WriteLine("Enter the 2nd word");
        String h= Console.ReadLine();

        bool moh= g.Equals(h);

        Console.WriteLine(moh);

    }



}