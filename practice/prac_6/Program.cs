public class Prac
{
    
    public static string Excep()
    {
        Console.WriteLine("Enter your name");
        String name=Console.ReadLine();

        if(name == null || name=="")
        {
            throw new NamingException();
            return name;
        }
        else
        {
            name=name.ToUpper();

            return name;
        }

    }






}

public class NamingException : ApplicationException
{


    public static void Main(string[] args)
    {
        NamingException ne = new NamingException();

        string e = ne.Excep();





    }






}