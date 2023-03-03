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
    public IActionResult BookProfile(int id)
    {
        BookProfileModel profile = new BookProfileModel();

        var context = new BookishContext();
        profile.Copies = context.Copies.Where(s => s.BookId == id).ToList();
        profile.Book = context.Books.Where(s => s.Id == id).ToList();
        profile.Member = context.Members.ToList();

        return View(profile);
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

    // DISPLAY  MEMBER LIST
    public IActionResult Member()
    {
        var context = new BookishContext();
        var memberList = context.Members.OrderBy(order => order.Id).ToList();
        return View(memberList);
    }
    // DISPLAY ADD MEMBER FORM
    public IActionResult AddMemberForm()
    {
        return View();
    }

    // TAKE ADD MEMBER FORM DATA AND ADD MEMBER TO DATABASE
    [HttpPost]
    [ActionName("AddMemberForm")]
    public IActionResult AddMemberForm([FromForm] MemberViewModel arg)
    {
        // ValidateFormData.ValidateData(arg);

        AddMemberFromForm.AddMember(arg);
        return RedirectToAction("Book");
    }

    // DISPLAY EDIT MEMBER FORM
    public IActionResult EditMemberForm()
    {
        return View();
    }

    // TAKE EDIT MEMBER DATA AND EDIT MEMBER IN DATABASE
    [HttpPost]
    public IActionResult EditMemberForm([FromForm] MemberDatabaseModel arg) //potentially the incorrect type
    {
        ValidateFormData.ValidateMemberDatabaseData(arg);
        EditMemberFromForm.EditMember(arg);
        return RedirectToAction("Member");
    }

    // DISPLAY PROFILE OF MEMBERS IN DATABASE
    [HttpGet]
    public IActionResult MemberProfile(int id)
    {
        MemberProfileModel profile = new MemberProfileModel();

        var context = new BookishContext();
        //    profile.Copies = context.Copies.Where(s => s.BookId == id).ToList();
        profile.Member = context.Members.Where(s => s.Id == id).ToList();
        profile.Copies = context.Copies.Where(s => s.MemberId == id).ToList();
        profile.Book = context.Books.ToList();
        return View(profile);
    }

    // DISPLAY CHECKOUT FORM
    public IActionResult CheckoutForm()
    {
        return View();
    }

    // TAKE CHECKOUT DATA AND EDIT COPIES IN DATABASE
    [HttpPost]
    public IActionResult CheckoutForm([FromForm] CopyDatabaseModel arg)
    {
        // ValidateFormData.ValidateMemberDatabaseData(arg);
        CheckoutFromForm.CheckoutBook(arg);
        return RedirectToAction("Member");
    }

}
