namespace Bookish.Models;

public class CopyDatabaseModel
{
    public int Id { get; set; }
    public int BookId { get; set; }

    public CopyDatabaseModel(int id, int bookId)
    {
        Id = id;
        BookId = bookId;

    }

    public CopyDatabaseModel(int bookId)
    {
        BookId = bookId;

    }

    public CopyDatabaseModel()
    {

    }
}