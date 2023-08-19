namespace PhoneBook;

internal class Contact
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public long PhoneNumber { get; }

    public Contact(string firstName, string lastName, long phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}