// See https://aka.ms/new-console-template for more information
using LumenWorks.Framework.IO.Csv;


using Surayavanshi_Library_Mgt_System.Management;
using System.Globalization;
using System.Text;
using System.Data;

class AuthorManagement:FileManagement
{
    public List<Author> _authorList;

    public AuthorManagement(string filePath, string heading):base(filePath,heading)
    {
        _authorList = new List<Author>();
    }

     public void  AddAuthor()
    {
        Console.WriteLine("Enter you Author Info");
        Console.WriteLine("Author Id:");
        var authorId=Int16.Parse(Console.ReadLine());
        Console.WriteLine("Author Name");
        var authorName=Console.ReadLine();
        Console.WriteLine("Author Notes");
        var authorNotes=Console.ReadLine();

        Author author = new Author(authorId, authorName,authorNotes);
        _authorList.Add(author);

        var data = $"{authorId},{authorName},{authorNotes}\n";
        if (!File.Exists(FilePath))
            File.WriteAllText(FilePath, Heading);
        try
        {
            File.AppendAllText(FilePath, data);
            Console.WriteLine("added into file");
        }
        catch (Exception exception)
        {Console.WriteLine(exception.Message);
        }
    }


    public void GetAllAuthor()
    {
        //using (StreamReader sr = File.OpenText(FilePath))
        //{
        //    string s;
        //    int i = 0;
        //    while ((s = sr.ReadLine()) != null)
        //    {
        //        if (i++ == 0)
        //            continue;
        //        i++;
        //        string[] strArray = s.Split(",");

        //        _authorList.Add(new Author(int.Parse(strArray[0]), strArray[1], strArray[2]));
        //    }

        //    foreach (var item in _authorList)
        //    {
        //        Console.Write(item.AuthorName);
        //    }

        //}

        var csvTable = new DataTable();
        using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(FilePath)), true))
        {
            csvTable.Load(csvReader);
        }
        int row, col = 0;
        row = csvTable.Rows.Count;
        col=csvTable.Columns.Count;

        for(int r=0;r<row;r++)
        {
            for(int c=0;c<col;c++)
            {
                Console.Write(csvTable.Rows[r][c].ToString()+"  ");
            }
            Console.WriteLine();
        }




    }
    public void UpdateAuthor(int authorId)
    {
        
    }

    public void DeleteAuthor(int authorId)
    {

    }



}
