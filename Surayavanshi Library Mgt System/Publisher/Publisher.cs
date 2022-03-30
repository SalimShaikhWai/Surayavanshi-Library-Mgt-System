// See https://aka.ms/new-console-template for more information






class Publisher
{
    private int _publisherId;
    private string _publisherName;
    private string publisherPhone;
    private string publisherEmail;
    private string _publisherNotes;

    public int PublisherId { get => _publisherId; set => _publisherId = value; }
    public string PublisherName { get => _publisherName; set => _publisherName = value; }
    public string PublisherPhone { get => publisherPhone; set => publisherPhone = value; }
    public string PublisherEmail { get => publisherEmail; set => publisherEmail = value; }
    public string PublisherNotes { get => _publisherNotes; set => _publisherNotes = value; }

    public Publisher(int publisherId, string publisherName, string publisherPhone, string publisherEmail, string publisherNotes)
    {
        PublisherId = publisherId;
        PublisherName = publisherName;
        PublisherPhone = publisherPhone;
        PublisherEmail = publisherEmail;
        PublisherNotes = publisherNotes;

    }
}
