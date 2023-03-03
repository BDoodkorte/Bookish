using Bookish.Services;
namespace Bookish.Models;

class BookProfileModel
{

    public List<CopyDatabaseModel> Copies { get; set; }
    public List<BookDatabaseModel> Book { get; set; }
    public List<MemberDatabaseModel> Member { get; set; }


    public BookProfileModel()
    {
        this.Copies = new List<CopyDatabaseModel>();
        this.Book = new List<BookDatabaseModel>();
        this.Member = new List<MemberDatabaseModel>();

    }
}
