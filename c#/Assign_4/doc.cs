using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_4
{
    internal class doc
    {
        class Doctor
        {

            int reg_no;
            string name;
            double fees_charged;
            public int Reg_No
            {
                get { return reg_no; }
                set { reg_no = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }

            }
            public double Fees_charged
            {
                get { return fees_charged; }
                set { fees_charged = value; }
            }

        }
        class Books
        {
            string Book_Name;
           
            string Author_Name;
            public Books(string book_name, string author_name)
            {
                this.Book_Name = book_name;
                this.Author_Name = author_name;

            }
            public void Display()
            {
                Console.WriteLine($"Book name is {Book_Name} and Author name is {Author_Name}");
            }
        }
        class Bookshelf
        {
            Books[] b = new Books[5];
            public Books this[int pos]
            {
                get { return b[pos]; }
                set { b[pos] = value; }
            }
        }
        class Driver
        {
            public static void Main()
            {
                Console.WriteLine("   Enter Doctor details ");
                                
                Console.Write("Enter the Registred number : ");
                int reg_num = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Enter the Name : ");
                string Name1 = Console.ReadLine();
               
                Console.Write("the amoubnt of fee charged is : ");
                double fees = Convert.ToDouble(Console.ReadLine());
               
                Doctor d = new Doctor();
                Console.WriteLine();

                Console.WriteLine(" *** Doctor Details ***");
                d.Reg_No = reg_num;
               
                Console.WriteLine($"Registration number : {d.Reg_No}" );
                d.Name = Name1;
                
                Console.WriteLine($"Name : {d.Name}");
                d.Fees_charged = fees;
                
                Console.WriteLine($"fees chaged is : {d.Fees_charged}" );

                // Book details
                Console.WriteLine();
                Console.WriteLine("    Book Details   ");
               
                Console.Write("Enter the Book name : ");
                string bname = Console.ReadLine();
                
                Console.Write("Enter the author name : ");
                string aname = Console.ReadLine();
               
                Books b = new Books(bname, aname);
                              
                Console.WriteLine("*** Book details ***");
                b.Display();

                // BookShelf
                
                Console.WriteLine(" ----- Indexers ----");
                Bookshelf book_shelf = new Bookshelf();
               
                Console.WriteLine("Book details");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter the Book name : ", i + 1);
                    string bookname = Console.ReadLine();
                    
                    Console.Write("Enter the author name :", i + 1);
                    string authorname = Console.ReadLine();
                    
                    book_shelf[i] = new Books(bookname, authorname);
                }
                
                Console.WriteLine("*** Book details as follows ***");
                
                for (int j = 0; j <= 5; j++)
                {
                    book_shelf[j].Display();
                }
                
            }

        }

    }
}
