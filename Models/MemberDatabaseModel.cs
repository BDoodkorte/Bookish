namespace Bookish.Models;

public class MemberDatabaseModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

	public string ContactNumber {get; set; }

    public MemberDatabaseModel(int id, string firstName, string lastName, string email, string contactNumber)
    {
    Id = id;
		FirstName = firstName;
		LastName = lastName;
		Email = email;
		ContactNumber = contactNumber;
    }

    public MemberDatabaseModel(string firstName, string lastName, string email, string contactNumber)
    {
    
		FirstName = firstName;
		LastName = lastName;
		Email = email;
		ContactNumber = contactNumber;
    }

    public MemberDatabaseModel()
    {

    }
}