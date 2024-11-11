class Sortedd
{

    public static void Main(string[] args)
    {

        SortedList<int,string> sl=new SortedList<int, string>();

        sl.Add(001, "jack");
        sl.Add(002, "mack");
        sl.Add(003, "james");



        foreach(int i in sl.Keys)
        {
            Console.WriteLine(i);
            
        }

        foreach(object o in sl.Values)
        {

            Console.WriteLine(o);
        }


    }






}
