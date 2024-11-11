using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_4
{
    class MarksException : ApplicationException
    {
        public MarksException(string msg) { }
    }
    class Scholarship
    {
        int amount;
        public int Merit(int M, int F)
        {
            if (M > 100) throw new MarksException("Marks should be below or equal to 100");
            else
            {
                return amount = (M >= 70 && M <= 80) ? (F * 20 / 100) : (M > 80 && M <= 90) ? (F * 30 / 100) : (M > 90) ? (F * 50 / 100) : 0;
            }
        }
        static void Main()
        {
            Scholarship s1 = new Scholarship();
            try
            {
                Console.Write("Enter the marks of the student : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the College Fee : ");
                int b = Convert.ToInt32(Console.ReadLine());
                s1.Merit(a, b);
            }
            catch (MarksException e)
            {
                Console.WriteLine("Enter a marks between 0 to 100 ", e.Message);
            }
           
            Console.WriteLine("Scholarship amount for student is : {0}", s1.amount);
            Console.ReadKey();

        }
    }

}
