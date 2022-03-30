// See https://aka.ms/new-console-template for more information


using LumenWorks.Framework.IO.Csv;
using Surayavanshi_Library_Mgt_System.Management;
using System.Data;
using System.Globalization;

class PublisherManagement:FileManagement
{

    public List<Publisher> _publisherList;
    public PublisherManagement(string filePath, string heading):base(filePath, heading)
    {
        _publisherList = new List<Publisher>();
    }
   public void AddPublisher()
    {
        Console.WriteLine("Enter you Publisher Info");
        Console.WriteLine("Publisher Id:");
        var publisherId = Int16.Parse(Console.ReadLine());
        Console.WriteLine("publisher Name");
        var publisherName = Console.ReadLine();

        Console.WriteLine("publisherPhone");
        var publisherPhone = Console.ReadLine();
        Console.WriteLine("publisherEmail");
        var publisherEmail = Console.ReadLine();
        Console.WriteLine("publisher Notes");
        var publisherNotes = Console.ReadLine();

        Publisher publisher = new(publisherId, publisherName, publisherPhone, publisherEmail, publisherNotes);
        _publisherList.Add(publisher);


        var data = $"{publisherId},{publisherName},{publisherPhone},{publisherEmail},{publisherNotes}";
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

    public void GetAllPublisher()
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

    public void UpdatePublisher(int publisherId)
    {

    }

    public void DeletePublisher(int publisherId)
    {

    }






}