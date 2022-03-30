// See https://aka.ms/new-console-template for more information
using LumenWorks.Framework.IO.Csv;
using Surayavanshi_Library_Mgt_System.Management;
using System.Data;


//authorInfo.GetAllAuthor();

class CustomerManagement:FileManagement
{
    public List<Customer> _customerList;
   public CustomerManagement(string filePath, string filehandling) : base(filePath, filehandling)
    {
        _customerList = new List<Customer>();
    }



    public void AddCutomer()
    {
        Console.WriteLine("Enter you Customer Info");
        Console.WriteLine("Customer Id:");
        var customerId = Int16.Parse(Console.ReadLine());
        Console.WriteLine("Customer Name");
        var customerName = Console.ReadLine();
        Console.WriteLine("Customer Email");
        var cutomerEmail = Console.ReadLine();

        Console.WriteLine("Customer Phone");
        var customerPhone = Console.ReadLine();
        Console.WriteLine("Customer Adreess");
        var customerAddress = Console.ReadLine();
        

        Customer customer = new Customer(customerId,customerName, cutomerEmail, customerPhone, customerAddress);
        _customerList.Add(customer);

        var data = $"{customerId},{customerName},{cutomerEmail},{customerPhone},{customerAddress},{true}";
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

    public void GetAllCustomer()
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

}