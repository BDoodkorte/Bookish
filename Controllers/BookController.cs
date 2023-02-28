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

    public IActionResult Book()
    {
        // create book objects book 1 = new Book etc
        List<BookDatabaseModel> catalogue = new List<BookDatabaseModel>(){
        new BookDatabaseModel(1,"The Lord of the Rings", "J.R.R. Tolkien", 1954),
        new BookDatabaseModel(2,"Frankenstein", "Mary Shelley", 1818),
        new BookDatabaseModel(3,"Hunger Games", "Suzanne Collins", 2008)
        };

        // var form = new BookForm();
        BookForm.AddBookDatabase();
        return View(catalogue);
    }

    public IActionResult AddBookForm()
    {
        return View();
    }

    // public IActionResult CreateBook()
    // {
    //     // send user to different page
    //     // add post request to our api

    // }
}