using Demo.Domain.Entities;

namespace Demo.Domain.DBContexts;

/// <summary>
/// DbContext, simulates a database   
/// </summary>
public class DBContext
{
    /// <summary>
    /// List of all the users, simulates user database table
    /// </summary>
    public static List<User> Users = new List<User>()
    {
        new User()
        {
            Id = 1001,
            Username = "Alice",
            Email = "Alice@qq.com",
            Password = "123456",
            RegTime = DateTime.Now,
            LastLoginTime = DateTime.Now,
            Status = true,
        },
        new User()
        {
            Id = 1002,
            Username = "Bob",
            Email = "Bob@qq.com",
            Password = "123456",
            RegTime = DateTime.Now,
            LastLoginTime = DateTime.Now,
            Status = false,
        },
        new User()
        {
            Id = 1003,
            Username = "Charlie",
            Email = "Charlie@qq.com",
            Password = "123456",
            RegTime = DateTime.Now,
            LastLoginTime = DateTime.Now,
            Status = true,
        }
    };
    
    
}