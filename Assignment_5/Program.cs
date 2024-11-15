class Books
{

    string BookName;

    string AuthorName;


    public Books(string bkn,string autn)
    {
       this.BookName = bkn;

       this.AuthorName = autn;


    }

    public void Display()
    {
        Console.WriteLine($"Name of the Book : {BookName} Author of the Book : {AuthorName}");
    }



}

class BookShelf
{

    public Books[] b = new Books[10];

    public Books this[int i]
    {
        get { return b[i]; }
        set { b[i] = value; }
    }


    public static void Main(string[] args)
    {
        BookShelf s = new BookShelf();

        for (int i = 0;i<5;i++)
        {
            Console.WriteLine($"Enter Book {i+1} details ");
            Console.WriteLine("Enter the Book Name:");
            
            string book_name=Console.ReadLine();

            Console.WriteLine("Enter the book Author Name");
            string author_name=Console.ReadLine();

            s[i]=new Books(book_name, author_name);


        }

        Console.WriteLine("--------------Book Details---------------");

        for (int j = 0; j<5;j++)
        {
            s[j].Display();
        }




    }

}


