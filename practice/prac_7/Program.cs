using System.Collections;
class Prac6
{

    static void Sl()
    {


        List<Employee> emp = new List<Employee>();

        emp.Add(new Employee(1806366,"Moh"));

        emp.Add(new Employee(1806322,"jack"));




    }




    public static void Main(string[] args)
    {


    }





}

class Employee : IComparable
{

    int EMID;
    string EMPNAME;

    public Employee(int EMID, string EMPNAME)
    {
        this.EMID = EMID;
        this.EMPNAME = EMPNAME;

    }







}