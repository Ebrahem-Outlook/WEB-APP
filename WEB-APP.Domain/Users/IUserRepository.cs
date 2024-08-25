namespace WEB_APP.Domain.Users;

public interface IUserRepository
{
    // Commands.
    Task AddAsync(User user, CancellationToken cancellationToken);
    Task UpdateAsync(User user, CancellationToken cancellationToken);
    Task DeleteAsync(User user, CancellationToken cancellationToken);

    // Queries.
    Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken);
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken);
    Task<IEnumerable<User>> GetByNameAsync(string name, CancellationToken cancellationToken);
}
