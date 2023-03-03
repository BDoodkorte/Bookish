using Bookish.Models;
using Microsoft.AspNetCore.Mvc;
using Bookish.Services;

namespace Bookish.Services;

class ValidateFormData
{

public static void ValidateData(BookViewModel arg)
{
    // Validate Title is not empty or a whitespace
    if(String.IsNullOrEmpty(arg.Title) || String.IsNullOrWhiteSpace(arg.Title)) 
    {
        throw new ArgumentOutOfRangeException ("Title invalid. Please try again");
    }
    // Validate Author is not empty or a whitespace
    if(String.IsNullOrEmpty(arg.Author) || String.IsNullOrWhiteSpace(arg.Author))
    {
        throw new ArgumentOutOfRangeException ("Author name is invalid.");
    }

    // Validate Year falls between 1500-2023
    if(arg.Year < 1500 || arg.Year > 2023)
    {
        throw new ArgumentOutOfRangeException ("Year entered must be between 1500 and 2023.");
    }
    


}

public static void ValidateDatabaseData(BookDatabaseModel arg)
{
    // Validate Title is a string

    if(String.IsNullOrEmpty(arg.Title) || String.IsNullOrWhiteSpace(arg.Title)) 
    {
        throw new ArgumentOutOfRangeException ("Title invalid. Please try again");
    }
    // Validate Author is a string
    if(String.IsNullOrEmpty(arg.Author) || String.IsNullOrWhiteSpace(arg.Author))
    {
        throw new ArgumentOutOfRangeException ("Author name is invalid.");
    }

    // Validate Year falls between 1500-2023
    if(arg.Year < 1500 || arg.Year > 2023)
    {
        throw new ArgumentOutOfRangeException ("Year entered must be between 1500 and 2023.");
    }
}

public static void ValidateMemberDatabaseData(MemberDatabaseModel arg)
{
    // Validate Title is a string

    if(String.IsNullOrEmpty(arg.FirstName) || String.IsNullOrWhiteSpace(arg.FirstName)) 
    {
        throw new ArgumentOutOfRangeException ("First Name is invalid.");
    }
    // Validate Author is a string
    if(String.IsNullOrEmpty(arg.LastName) || String.IsNullOrWhiteSpace(arg.LastName))
    {
        throw new ArgumentOutOfRangeException ("Last name is invalid.");
    }
        if(String.IsNullOrEmpty(arg.Email) || String.IsNullOrWhiteSpace(arg.Email))
    {
        throw new ArgumentOutOfRangeException ("Last name is invalid.");
    }
        if(String.IsNullOrEmpty(arg.ContactNumber) || String.IsNullOrWhiteSpace(arg.ContactNumber))
    {
        throw new ArgumentOutOfRangeException ("Last name is invalid.");
    }

}

}