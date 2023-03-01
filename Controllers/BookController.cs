using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;



namespace Bookish.Controllers;

public class BookController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public BookController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Book()
    {
        // List<BookDatabaseModel> catalogue = new List<BookDatabaseModel>(){
        // new BookDatabaseModel(1,"The Lord of the Rings", "J.R.R. Tolkien", 1954),
        // new BookDatabaseModel(2,"Frankenstein", "Mary Shelley", 1818),
        // new BookDatabaseModel(3,"Hunger Games", "Suzanne Collins", 2008)
        // };

        // pull entries from database and display in a list. 
        var context = new BookishContext();
        var bookList = context.Books.OrderBy(order => order.Title).ToList();
        // var sortedBookList = bookList.

        // var form = new BookForm();
        // BookForm.AddBookDatabase();
        return View(bookList);
    }



    public IActionResult AddBookForm()
    {
        return View();
    }

    [HttpPost]
    [ActionName("AddBookForm")]
    public IActionResult AddBookForm([FromForm] BookViewModel arg) //potentially the incorrect type
    {


        using (var context = new BookishContext())
        {

            // convert from bookviewmodel to bookdatabasemodel
            BookDatabaseModel addedBook = new BookDatabaseModel(arg.Title, arg.Author, arg.Year);
            context.Books.Add(addedBook);
            context.SaveChanges();


            return RedirectToAction("Book");
        }
    }

    //incomplete
    public IActionResult EditBookForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult EditBookForm([FromForm] BookDatabaseModel arg) //potentially the incorrect type
    {


        using (var context = new BookishContext())
        {

            //load old data
            var std = context.Books.Where(s => s.Id == arg.Id).First(); // call upon arg.id
            std.Title = arg.Title;
            std.Author = arg.Author;
            std.Year = arg.Year;
            std.Id = arg.Id;
            context.SaveChanges();


            return RedirectToAction("Book");
        }
    }

}
