using Bookish.Models;
namespace Bookish.Services;

class AddBookFromForm
{

public static void AddBook(BookViewModel arg)
{
        using (var context = new BookishContext())
        {

            // convert from bookviewmodel to bookdatabasemodel
            BookDatabaseModel addedBook = new BookDatabaseModel(arg.Title, arg.Author, arg.Year);
            // Add book to database
            context.Books.Add(addedBook);
            context.SaveChanges();
        }
}
}