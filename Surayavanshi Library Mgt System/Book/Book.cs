// See https://aka.ms/new-console-template for more information






class Book
{

    private string _iSBIN;
    private string _title;
    private int _publisherId;
    private int _authorId;
    private bool _issuedStatus;
    private bool _isDeleted;

    public Book(string iSBIN, string title, int publisherId, int authorId, bool issuedStatus, bool isDeleted)
    {
        ISBIN = iSBIN;
        Title = title;
        PublisherId = publisherId;
        AuthorId = authorId;
        IssuedStatus = issuedStatus;
        IsDeleted = isDeleted;
    }

    public string ISBIN { get => _iSBIN; set => _iSBIN = value; }
    public string Title { get => _title; set => _title = value; }
    public int PublisherId { get => _publisherId; set => _publisherId = value; }
    public int AuthorId { get => _authorId; set => _authorId = value; }
    public bool IssuedStatus { get => _issuedStatus; set => _issuedStatus = value; }
    public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }
}
