namespace Demo.Domain.Entities;

/// <summary>
/// Entity, User info
/// </summary>
public class User
{
    /// <summary>
    /// User ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Email account
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// User password
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// User name
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// User registration date, Last login date
    /// </summary>
    public DateTime RegTime { get; set; }
    public DateTime LastLoginTime { get; set; }

    /// <summary>
    /// User Status
    /// </summary>
    public bool Status { get; set; }
}