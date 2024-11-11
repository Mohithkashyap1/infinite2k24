class GenericClass<T>
{

    T data;

    public T DataValue
    {

        get { return this.data; }

        set { this.data = value; }

    }


    public static void Main(string[] args)
    {

        GenericClass<string> gc =new GenericClass<string>();

        gc.DataValue = "Hello Generics";

        Console.WriteLine(gc.DataValue);


    }






}
