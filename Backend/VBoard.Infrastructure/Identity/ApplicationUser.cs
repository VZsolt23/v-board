using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace VBoard.Infrastructure.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    [MaxLength(128)]
    public required string FirstName { get; set; }
    [MaxLength(128)]
    public required string LastName { get; set; }
    public DateTime RegisteredAtUtc { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}