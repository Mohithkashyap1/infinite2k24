namespace Assessment_2
{
    class Pos_Neg
    {

        public static void Check_Input(int input)
        {
            if (input < 0)
            {
                throw new ArgumentException("Invalid Input , Number cannot be Negative ");

            }
            else
            {
                Console.WriteLine("The Number is Positive");
            }
        }


        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Number");
                int c = Convert.ToInt32(Console.ReadLine());

                Check_Input(c);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter an integer only");
            }



        }






    }
}
