using Bookish.Models;
namespace Bookish.Services;

class AddMemberFromForm
{

public static void AddMember(MemberViewModel arg)
{
        using (var context = new BookishContext())
        {

            // convert from bookviewmodel to bookdatabasemodel
            MemberDatabaseModel addedMember = new MemberDatabaseModel(arg.FirstName, arg.LastName, arg.Email, arg.ContactNumber);
            // Add book to database
            context.Members.Add(addedMember);
            context.SaveChanges();
        }
}
}