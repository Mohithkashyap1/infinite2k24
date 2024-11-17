using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
   
   class Program
   {

        public static int Fare=500;
    static void Main(string[] args)
    {
            

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        ConcessionCalculator calculator = new ConcessionCalculator();
        string result = calculator.CalculateConcession(age,Program.Fare);

        Console.WriteLine($"Hello, {name}! {result}");
        
        
    }
}

public class ConcessionCalculator
{
    public string CalculateConcession(int age,int Fare)
    {
            if (age <= 5)
            {
                return "Little Champs! Free Ticket";
            }

            else if (age >= 60)
            {
                return "Senior Citizen"+0.3*(Fare);
            }
            else
            {
                return "Ticket Booked"+Fare;
            }
            
    }

}
}