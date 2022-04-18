using Demo.Application.IService;
using Demo.Domain.Entities;
using Demo.Domain.IRepositories;

namespace Demo.Application.Service;

/// <summary>
/// Define concrete business logic for the <see cref="Demo.Domain.Entities.User"/> entity.
/// </summary>
public class UserService : IUserService
{
    
    /// <summary>
    /// Dependency injection of the <see cref="Demo.Domain.IRepositories.IUserRepository"/>.
    /// </summary>
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Constructor, initializes
    /// </summary>
    public UserService(IUserRepository userRepository)
    {
        Console.WriteLine("UserService.ctor");
        _userRepository = userRepository;
    }
    
    /// <summary>
    /// Registers a new user.
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Status</returns>
    public bool Reg(User user)
    {
        // 1. Check
        if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
        {
            return false;
        }
        
        // 2. Save Registration info
        user.RegTime = DateTime.Now;
        user.Status = true;
        
        // 3. Save User info
        int count = _userRepository.Add(user);
        
        // 4. Return affected rows
        return count > 0;
    }

    /// <summary>
    /// Login
    /// </summary>
    /// <param name="user">User object</param>
    /// <returns>Status</returns>
    public bool Login(User user)
    {
        // 1. Check
        if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
        {
            Console.WriteLine("Email or password is empty.");
            return false;
        }
        
        // 2. Get User info
        var target = _userRepository.GetByEmail(user.Email);
        if (target == null)
        {
            return false;
        }
        
        // 3. Check Password
        if (target.Password != user.Password)
        {
            return false;
        }
        
        // 4. Update Login info
        target.LastLoginTime = DateTime.Now;
        _userRepository.Update(target);
        
        // 5. Return status
        return true;
    }
    
    /// <summary>
    /// Get User info by id
    /// </summary>
    /// <param name="id">User ID</param>
    /// <returns>User info</returns>
    public User GetById(int id)
    {
        return _userRepository.GetById(id);
    }
    
    /// <summary>
    /// Check if the user is existed by email already
    /// </summary>
    /// <param name="email">Email</param>
    /// <returns>Status</returns>
    public bool ExistsByEmail(string email)
    {
        return _userRepository.GetByEmail(email) != null;
    }
    
    /// <summary>
    /// Get all users
    /// </summary>
    /// <returns></returns>
    public List<User> List() 
    {
        return _userRepository.List();
    }

}