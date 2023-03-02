namespace Bookish.Models;

public class BookDatabaseModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public BookDatabaseModel(int id, string title, string author, int year)
    {
        Id = id;
        Title = title;
        Author = author;
        Year = year;
    }

    public BookDatabaseModel(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public BookDatabaseModel()
    {

    }
}