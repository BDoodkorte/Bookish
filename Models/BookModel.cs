namespace Bookish.Models;

public class BookModel
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Copies { get; set; }
    public int CopiesAvailable { get; set; }

     public BookModel(int bookID, string title , string author , int year, int copies, int copiesAvailable)
    {
        BookID = bookID;
        Title = title;
        Author = author;
        Year = year;
		Copies = copies;
        CopiesAvailable = copiesAvailable;
    }
}