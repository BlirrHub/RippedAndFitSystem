using RippedAndFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace RippedAndFit.Domain.Entities;

public class Staff
{
    [Key]
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required StaffRoles Role { get; set; }
}
