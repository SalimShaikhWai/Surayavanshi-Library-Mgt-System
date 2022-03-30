// See https://aka.ms/new-console-template for more information
using Surayavanshi_Library_Mgt_System.Management;
//authorInfo.GetAllAuthor();

class TransactionManagement:FileManagement
{
    public List<Transaction> _transactionList;
    public TransactionManagement(string filePath, string heading):base(filePath,heading)
    {
        _transactionList = new List<Transaction>();
    }

    public void AddTransaction()
    {
        Console.WriteLine("Enter you Transaction Info");
        Console.WriteLine("Transaction Id:");
        var transactionId = Int16.Parse(Console.ReadLine());
        Console.WriteLine("Book Id");
        var bookId = Console.ReadLine();
        Console.WriteLine("Customer Id");
        var customerId =int.Parse( Console.ReadLine());


        Transaction transaction = new Transaction(transactionId, bookId, customerId,"12/12/1997","");
        _transactionList.Add(transaction);

       var data = $"{transactionId},{ bookId}, {customerId},{"12/12/1997"},{" "}";
        if (!File.Exists(FilePath))
            File.WriteAllText(FilePath, Heading);
        try
        {
            File.AppendAllText(Heading, data);
            Console.WriteLine("added into file");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }



}