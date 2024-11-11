class Sorted
{

    public static void Main(string[] args)
    {



        SortedList<int,string> ss=new SortedList<int,string>();


        ss.Add(001,"Specter");

        ss.Add(002, "Ross");

        ss.Add(003, "Zane");

        ss.Add(004, "Pearson");


        foreach(KeyValuePair<int,string> kvp in ss)
        {
            Console.WriteLine(kvp.key);


        }




    }








}
