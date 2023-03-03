using Bookish.Models;
namespace Bookish.Services;

class EditMemberFromForm
{

public static void EditMember(MemberDatabaseModel arg)
{
 using (var context = new BookishContext())
        {

            // Load book that matches Id from edit form
            var std = context.Members.Where(s => s.Id == arg.Id).First();
            // Update each value
            std.FirstName = arg.FirstName;
            std.LastName = arg.LastName;
            std.Email = arg.Email;
            std.ContactNumber = arg.ContactNumber;
            // Save updated book
            context.SaveChanges();

        }
}
}