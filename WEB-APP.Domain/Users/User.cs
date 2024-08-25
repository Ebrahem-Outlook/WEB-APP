using WEB_APP.Domain.Core.BaseType;

namespace WEB_APP.Domain.Users;

public sealed class User : AggregateRoot
{
    private User(string firstName, string lastName, string email, string password)
        : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    private User() : base() { }

    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string Password { get; private set; } = default!;

    public static User Create(string firstName, string lastName, string email, string password)
    {
        User user = new User(firstName, lastName, email, password);

        // Raise DomainEvent.

        return user;
    }

    public void UpdateUser(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        // Raise DomainEvent.
    }

    public void UpdateEmail(string email)
    {
        Email = email;

        // Raise DomainEvent.
    }

    public void UpdatePassword(string password)
    {
        Password = password;

        // Raise DomainEvent.
    }
}
