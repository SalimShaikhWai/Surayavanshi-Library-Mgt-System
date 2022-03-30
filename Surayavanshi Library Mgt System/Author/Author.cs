// See https://aka.ms/new-console-template for more information






public class Author
{
    private int _authorId;
    private string _authorName;
    private string _authorNotes;

    public Author(int authorId, string authorName, string authorNotes)
    {
        _authorId = authorId;
        _authorName = authorName;
        _authorNotes = authorNotes;
    }

    public int AuthorId { get => _authorId; set => _authorId = value; }
    public string AuthorName { get => _authorName; set => _authorName = value; }
    public string AuthorNotes { get => _authorNotes; set => _authorNotes = value; }
}
