using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;
using Microsoft.Data.SqlClient;

namespace Bookish.Controllers;

public class BookController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public BookController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // DISPLAY CATALOGUE OF BOOKS IN DATABASE
    [HttpGet]
    public IActionResult Book()
    {
        // Pull entries from database and display in a list. 
        var context = new BookishContext();
        var bookList = context.Books.OrderBy(order => order.Title).ToList();
        return View(bookList);
    }

    // DISPLAY PROFILE OF BOOKS IN DATABASE
    [HttpGet]
    public IActionResult BookProfile(int id){


   var context = new BookishContext();
   var copyList = context.Copies.Where(s => s.BookId == id).ToList();

        //for loop that goes through copies database and counts the amount copies
        // if i.bookId = arg.bookId copyAmount++
        return View(copyList);
    }

    // DISPLAY ADD BOOK FORM
    public IActionResult AddBookForm()
    {
        return View();
    }

    // TAKE ADD BOOK FORM DATA AND ADD BOOK TO DATABASE
    [HttpPost]
    [ActionName("AddBookForm")]
    public IActionResult AddBookForm([FromForm] BookViewModel arg) //potentially the incorrect type
    {
        ValidateFormData.ValidateData(arg);
        AddBookFromForm.AddBook(arg);
        return RedirectToAction("Book");
    }

    // DISPLAY EDIT BOOK FORM
    public IActionResult EditBookForm()
    {
        return View();
    }

    // TAKE EDIT BOOK DATA AND EDIT BOOK IN DATABASE
    [HttpPost]
    public IActionResult EditBookForm([FromForm] BookDatabaseModel arg) //potentially the incorrect type
    {
        ValidateFormData.ValidateDatabaseData(arg);
        EditBookFromForm.EditBook(arg);
        return RedirectToAction("Book");
    }

    // DISPLAY ADD COPY FORM
    public IActionResult AddCopyForm()
    {
        var context = new BookishContext();
        var bookList = context.Books.OrderBy(order => order.Id).ToList();
        return View(bookList);
    }

    // TAKE ADD BOOK FORM DATA AND ADD BOOK TO DATABASE
    [HttpPost]
    [ActionName("AddCopyForm")]
    public IActionResult AddCopyForm([FromForm] CopyDatabaseModel arg)
    {
        // ValidateFormData.ValidateData(arg);

        AddCopyFromForm.AddCopy(arg);
        return RedirectToAction("Book");
    }

}
