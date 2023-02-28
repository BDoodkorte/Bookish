namespace Bookish.Models;

public class BookViewModel
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public BookViewModel(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}