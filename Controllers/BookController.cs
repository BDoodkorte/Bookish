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
        var bookList = context.Books.ToList();

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

}
