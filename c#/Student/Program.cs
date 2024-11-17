
    abstract class Student
    {

        public int SID { get; set; }

        public string SName { get; set; }

        public double grade { get; set; }

        public abstract Boolean ISPassed(double grade);

    }

    class UnderGraduate : Student
    {
        public override Boolean ISPassed(double grade)
        {
            if (grade > 70.0)
            {
                Console.WriteLine("Congratulations, You are an UnderGrad");
                return true;
            }
            else
            {
                Console.WriteLine("The student has failed");
                return false;
            }
        }

    }

    class Graduate : Student
    {

        public override bool ISPassed(double grade)
        {
            if (grade > 80.0)
            {
                Console.WriteLine("Congratulations, You are a Grad");
                return true;
            }
            else
            {
                Console.WriteLine("The student has failed");
                return false;
            }
        }



    }

    public class grad
    {

        public static void Main(string[] args)
        {
            UnderGraduate Ug = new UnderGraduate();

            Ug.SID = 1806366;

            Ug.SName = "Harvey Specter";



            Console.WriteLine($"Name of the Student : {Ug.SName}");

            Console.WriteLine($"Student ID : {Ug.SID}");

            Console.WriteLine("Enter the grades for Mr. Specter");
            double dd = Convert.ToDouble(Console.ReadLine());

            Ug.grade = dd;

            Console.WriteLine($" {Ug.ISPassed(dd)}");


            Graduate G = new Graduate();

            G.SID = 1806367;

            G.SName = "Damon Salvatore";



            Console.WriteLine($"Name of the Student : {G.SName}");

            Console.WriteLine($"Student ID : {G.SID}");

            Console.WriteLine("Enter the grades for Mr. Salvatore");
            double gg = Convert.ToDouble(Console.ReadLine());

            Ug.grade = gg;

            Console.WriteLine($" {G.ISPassed(gg)}");





        }















    }

