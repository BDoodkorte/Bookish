using Bookish.Models;
namespace Bookish.Services;

class EditBookFromForm
{

public static void EditBook(BookDatabaseModel arg)
{
 using (var context = new BookishContext())
        {

            // Load book that matches Id from edit form
            var std = context.Books.Where(s => s.Id == arg.Id).First();
            // Update each value
            std.Title = arg.Title;
            std.Author = arg.Author;
            std.Year = arg.Year;
            // Save updated book
            context.SaveChanges();

        }
}
}