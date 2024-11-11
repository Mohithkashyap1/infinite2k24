class Gen<T>
{
    T data;

    public T DataValue
    {
        get { return this.data; }

        set { this.data = value; }

    }


}

class Program
{



    public static void Main(string[] args)
    {

        Gen<string> g= new Gen<string>();

        g.DataValue = "Hey this Genric class";

        Console.WriteLine(g.DataValue);


        Gen<int> g2 = new Gen<int>();

        g2.DataValue = 007;

        Console.WriteLine(g2.DataValue);



    }








}