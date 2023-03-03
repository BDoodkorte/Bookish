namespace Bookish.Models;

public class CopyDatabaseModel
{
    public int Id { get; set; }
    public int BookId { get; set; }

    public int MemberId { get; set; }


    public CopyDatabaseModel(int id, int bookId, int memberId)
    {
        Id = id;
        BookId = bookId;
        MemberId = memberId;

    }

    public CopyDatabaseModel(int bookId, int memberId)
    {
        BookId = bookId;
        MemberId = memberId;
    }

    public CopyDatabaseModel(int memberId)
    {
        MemberId = memberId;
    }

    public CopyDatabaseModel()
    {

    }
}