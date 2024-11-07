namespace Assignment_3
{


    class SalesDetails
    {
        public static int Sales_No;
        public static int Product_No;
        public static int Price;
        public static DateTime DateofSale;
        public static int Quantity;
        public static int TotalAmount;


        public SalesDetails(int sales_no, int product_no, int price, int qty, DateTime Dos)
        {
            Sales_No = sales_no;
            Product_No = product_no;
            Price = price;
            Quantity = qty;
            DateofSale = Dos;

        }

      
        public void Sales(int price, int qty)
        {
            TotalAmount = qty * price;
        }
    }
    class SalesDetails1 : SalesDetails
    {
        public SalesDetails1(int sales_no, int product_no, int price, int qty, DateTime date_of_sale)
            : base(sales_no, product_no, price, qty, date_of_sale)
        {

        }

        
        public static void Show_Data()
        {
            Console.WriteLine("========== Total Bill ============");
            Console.WriteLine($"Sales No: { Sales_No}");
            Console.WriteLine($"Product No: {Product_No}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Quantity : {Quantity}");
            Console.WriteLine($"Date of sale : {DateofSale}");
            Console.WriteLine($"Total Amount : {TotalAmount}");
        }
        public static void Main()
        {
            Console.Write("Enter the Sales Number:");
            int sale_no = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the Product Number:");
            int product_no = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the Price:");
            int price = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the Quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the Date of sale:");
            DateTime dateofsale = Convert.ToDateTime(Console.ReadLine());
            
            SalesDetails Sdetails = new SalesDetails(sale_no, product_no, price, quantity, dateofsale);
            Sdetails.Sales(price, quantity);
            
            Show_Data();
           
        }
    }
}