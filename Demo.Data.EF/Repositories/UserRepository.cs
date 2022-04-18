using Demo.Domain.DBContexts;
using Demo.Domain.Entities;
using Demo.Domain.IRepositories;

namespace Demo.Data.EF.Repositories;

/// <summary>
/// Repository for <see cref="Demo.Domain.Entities.User"/>, all CRUD operations.
/// </summary>
public class UserRepository : IUserRepository
{
    public UserRepository()
    {
        Console.WriteLine("Using EF UserRepository");
    }
    
    /// <summary>
    /// Add user to database.
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Affected rows number</returns>
    public int Add(User user)
    {
        DBContext.Users.Add(user);
        return 1;
    }
    
    /// <summary>
    /// Update user in database.
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Affected rows number</returns>
    public int Update(User user)
    {
        var target = DBContext.Users.Single(x => x.Id == user.Id);
        target.Password = user.Password;
        target.Status = user.Status;
        target.LastLoginTime = user.LastLoginTime;
        target.Username = user.Username;
        return 1;
    }
    
    /// <summary>
    /// Get user by id.
    /// </summary>
    /// <param name="id">User ID</param>
    /// <returns>User info</returns>
    public User GetById(int id)
    {
        return DBContext.Users.SingleOrDefault(x => x.Id == id)!;
    }
    
    /// <summary>
    /// Get user by email.
    /// </summary>
    /// <param name="email">User Email</param>
    /// <returns>User info</returns>
    public User GetByEmail(string email)
    {
        return DBContext.Users.SingleOrDefault(x => x.Email.Equals(email, StringComparison.OrdinalIgnoreCase))!;
    }
    
    /// <summary>
    /// Retrieve all users.
    /// </summary>
    /// <returns>Users list</returns>
    public List<User> List()
    {
        return DBContext.Users;
    }
    
}