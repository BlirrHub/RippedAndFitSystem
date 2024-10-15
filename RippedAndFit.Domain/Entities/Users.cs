using RippedAndFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace RippedAndFit.Domain.Entities;

public class Users
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required string Username { get; set; }
    [Required]
    public required string Password { get; set; }
    [Required]
    public required Roles Role { get; set; }
}
