using Bookish.Services;
namespace Bookish.Models;

class MemberProfileModel
{

    // public List<CopyDatabaseModel> Copies { get; set; }
    public List<MemberDatabaseModel> Member { get; set; }

    public MemberProfileModel()
    {
    //     this.Copies = new List<CopyDatabaseModel>();
        this.Member = new List<MemberDatabaseModel>();
    }
}
