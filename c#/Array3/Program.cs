class Swap
{


    public static void Main(string[] args)
    {
        int[] arr1 = new int[4];

        int[] arr2 = new int[4];

        Console.WriteLine("Enter the elements of the array");

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());

        }

        for(int i = 0;i < arr1.Length; i++)
        {

            arr2[i] = arr1[i];
        }

        for (int i=0;i<arr1.Length;i++)
        {
            Console.WriteLine("Array 1 = {0}", arr1[i]);
        }

        for(int i=0;i < arr2.Length;i++)
        {
            Console.WriteLine("Array 2 = {0}", arr2[i]);
        }





    }

}
