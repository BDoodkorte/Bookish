using Bookish.Models;
namespace Bookish.Services;

class CheckoutFromForm
{

public static void CheckoutBook(CopyDatabaseModel arg)
{
 using (var context = new BookishContext())
        {

            // Load book that matches Id from edit form
            var std = context.Copies.Where(s => s.BookId == arg.BookId && s.MemberId == 0).First();
            // Update each value
            std.MemberId = arg.MemberId;
            // Save updated book
            context.SaveChanges();

        }
}
}