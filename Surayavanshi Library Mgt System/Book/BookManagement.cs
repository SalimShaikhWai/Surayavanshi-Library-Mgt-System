// See https://aka.ms/new-console-template for more information
using LumenWorks.Framework.IO.Csv;
using Surayavanshi_Library_Mgt_System.Management;
using System.Data;

class BookManagement:FileManagement
{

    public List<Book> _bookList;
    public BookManagement(string filePath,string filehandling) : base(filePath,filehandling)
    {
        _bookList = new List<Book>();
    }

    public void AddBook()
    {
        Console.WriteLine("Enter you Publisher Info");
        Console.WriteLine("Book ISBN:");
        var bookIsbn = Console.ReadLine();
        Console.WriteLine("Book Title");
        var bookTitle = Console.ReadLine();

        Console.WriteLine("Publisher Id");
        var publisherId =int.Parse( Console.ReadLine());
        Console.WriteLine("Author Id :");
        var authorId = int .Parse( Console.ReadLine());
        
        var issueStatus = true;
        var isDeleted = false;


        Book book = new(bookIsbn, bookTitle, publisherId, authorId, issueStatus,isDeleted);
        _bookList.Add(book);


        var data = $"{bookIsbn},{bookTitle},{publisherId},{authorId},{issueStatus},{isDeleted}";
        if (!File.Exists(FilePath))
            File.WriteAllText(FilePath, Heading);
        try
        {
            File.AppendAllText(FilePath, data);
            Console.WriteLine("added into file");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

    }

    public void GetAllBook()
    {
        var csvTable = new DataTable();
        using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(FilePath)), true))
        {
            csvTable.Load(csvReader);
        }
        int row, col = 0;
        row = csvTable.Rows.Count;
        col = csvTable.Columns.Count;

        for (int r = 0; r < row; r++)
        {
            for (int c = 0; c < col; c++)
            {
                Console.Write(csvTable.Rows[r][c].ToString() + "  ");
            }
            Console.WriteLine();
        }


    }

    public void UpdateBookByID(int bookId)
    {

    }

    public void DeleteBookByID(int bookId)
    {

    }
}
