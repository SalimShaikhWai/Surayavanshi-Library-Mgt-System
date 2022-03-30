// See https://aka.ms/new-console-template for more information


//authorInfo.GetAllAuthor();



class Transaction
{
    private int _transactionID;
    private string _bookId;
    private int _customerId;
    private string _dateOfIssue;
    private string _dateOfReturn;

    public Transaction(int transactionID, string bookId, int customerId, string dateOfIssue, string dateOfReturn)
    {
        TransactionID = transactionID;
        BookId = bookId;
        CustomerId = customerId;
        DateOfIssue = dateOfIssue;
        DateOfReturn = dateOfReturn;
    }

    public int TransactionID { get => _transactionID; set => _transactionID = value; }
    public string BookId { get => _bookId; set => _bookId = value; }
    public int CustomerId { get => _customerId; set => _customerId = value; }
    public string DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }
    public string DateOfReturn { get => _dateOfReturn; set => _dateOfReturn = value; }
}
