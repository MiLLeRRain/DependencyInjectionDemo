using Demo.Domain.Entities;
using Demo.Domain.IRepositories;

namespace Demo.Application.IService;

/// <summary>
/// Business Interface, define all application service logic methods.
/// </summary>
public interface IUserService
{

    /// <summary>
    /// Registers a new user.
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Status</returns>
    bool Reg(User user);

    /// <summary>
    /// Login
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Status</returns>
    bool Login(User user);

    /// <summary>
    /// Get User info by id
    /// </summary>
    /// <param name="id">User ID</param>
    /// <returns>User info</returns>
    User GetById(int id);

    /// <summary>
    /// Check if the user is existed by email already
    /// </summary>
    /// <param name="email">Email</param>
    /// <returns>Status</returns>
    bool ExistsByEmail(string email);

    /// <summary>
    /// Get all users
    /// </summary>
    /// <returns></returns>
    public List<User> List();

}