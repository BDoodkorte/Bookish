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
        // Pull entries from database and display in a list. 
        var context = new BookishContext();
        var bookList = context.Books.OrderBy(order => order.Title).ToList();
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
        AddBookFromForm.AddBook(arg);
        return RedirectToAction("Book");
    }

    public IActionResult EditBookForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult EditBookForm([FromForm] BookDatabaseModel arg) //potentially the incorrect type
    {
        EditBookFromForm.EditBook(arg);
        return RedirectToAction("Book");
    }

}
