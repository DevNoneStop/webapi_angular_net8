using Microsoft.AspNetCore.Identity;

namespace API.Models;

public class AppUser : IdentityUser
{
    // Additional properties for the AppUser class

    /// <summary>
    /// Gets or sets the first name of the user.
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Gets or sets the date of birth of the user.
    /// </summary>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the user's profile picture URL.
    /// </summary>
    public string? ProfilePictureUrl { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the user is active.
    /// </summary>
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// Gets or sets a collection of roles assigned to the user.
    /// </summary>
    public virtual ICollection<IdentityRole> Roles { get; set; }
}
