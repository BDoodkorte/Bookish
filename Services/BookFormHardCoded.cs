using Bookish.Models;
namespace Bookish.Services;

class BookForm
{
    public static void AddBookDatabase()
    {
        using (var context = new BookishContext())
        {
            var book1 = new BookDatabaseModel(1, "The Lord of the Rings", "J.R.R. Tolkien", 1954);
            var book2 = new BookDatabaseModel(2, "Frankenstein", "Mary Shelley", 1818);
            var book3 = new BookDatabaseModel(3, "Hunger Games", "Suzanne Collins", 2008);

            context.Books.Add(book1);
            context.Books.Add(book2);
            context.Books.Add(book3);
            context.SaveChanges();
        }
    }
}
