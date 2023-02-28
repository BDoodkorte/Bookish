using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

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
        List<BookModel> catalogue = new List<BookModel>(){
        new BookModel(1,"The Lord of the Rings", "J.R.R. Tolkien", 1954, 7,3),
        new BookModel(2,"Frankenstein", "Mary Shelley", 1818, 4,4),
        new BookModel(3,"Hunger Games", "Suzanne Collins", 2008, 3,3)
        };
        return View(catalogue);
    }
}