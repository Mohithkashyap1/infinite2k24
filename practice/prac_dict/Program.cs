using System.Collections;

class dict
{


    public static void Main(string[] args)
    {

        Dictionary<int,string> d= new Dictionary<int,string>();

        d.Add(001, "Max");

        d.Add(002, "Jack");

        d.Add(003, "Harvey");

        d.Add(004, "Mike");


        foreach(string s in d.Values)
        {
            Console.WriteLine(s+"");

        }

        foreach(int i in d.Keys)
        {
            Console.WriteLine(i+"");
        }

        foreach(KeyValuePair<int,string> kvp in d)
        {
            Console.WriteLine(kvp.Key + "-"+ kvp.Value);

        }


    }





}
