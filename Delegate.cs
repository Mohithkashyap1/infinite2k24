using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    delegate int CalculatorDelegate(int num1, int num2);

    class Delegate
    {
        public static int Add(int num1, int num2)
        { return num1 + num2; }
        public static int Subtract(int num1, int num2)
        { return num1 - num2; }
        public static int Multiply(int num1, int num2)
        { return num1 * num2; }

         public static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            CalculatorDelegate calcDelegate;

            calcDelegate = Add;
            Console.WriteLine($"Addition: {calcDelegate(num1, num2)}");

            calcDelegate = Subtract;
            Console.WriteLine($"Subtraction: {calcDelegate(num1, num2)}");

            calcDelegate = Multiply;
            Console.WriteLine($"Multiplication: {calcDelegate(num1, num2)}");
        }
    }
}
