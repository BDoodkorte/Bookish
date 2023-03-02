using Bookish.Models;
namespace Bookish.Services;

class AddCopyFromForm
{

    public static void AddCopy(CopyDatabaseModel arg)
    {
        using (var context = new BookishContext())
        {
            // Add copy to database
            context.Copies.Add(arg);
            context.SaveChanges();
        }
    }
}