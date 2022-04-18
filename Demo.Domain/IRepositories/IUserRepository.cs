using Demo.Domain.Entities;

namespace Demo.Domain.IRepositories;

/// <summary>
/// Repository interface for <see cref="User"/>, to define all the user related data operations.
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Add user to database.
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Affected rows number</returns>
    int Add(User user);

    /// <summary>
    /// Update user in database.
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Affected rows number</returns>
    int Update(User user);

    /// <summary>
    /// Get user by id.
    /// </summary>
    /// <param name="id">User ID</param>
    /// <returns>User info</returns>
    User GetById(int id);

    /// <summary>
    /// Get user by email.
    /// </summary>
    /// <param name="email">User Email</param>
    /// <returns>User info</returns>
    User GetByEmail(string email);

    /// <summary>
    /// Retrieve all users.
    /// </summary>
    /// <returns>Users list</returns>
    List<User> List();
}