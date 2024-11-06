using System.ComponentModel.DataAnnotations;

class Q2
{
    static string swap(string arr)
    {

        char begin = arr[0];

        char end = arr[arr.Length - 1];

        if(arr.Length>2)
        {
            return end + arr.Substring(1, arr.Length - 2) + begin;
        }
        else
        {
            return end +""+ begin;
        }



    }
    public static void Main(String[]args)
    {
        Console.WriteLine("Enter the string to be reversed");
        String m = Console.ReadLine();

        String result=swap(m);

        Console.WriteLine(result);
       
    }





}
