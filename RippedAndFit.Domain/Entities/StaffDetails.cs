using RippedAndFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RippedAndFit.Domain.Entities;

public class StaffDetails
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    [Required]
    public required DateOnly DateOfBirth { get; set; }
    [Required]
    public required int Age { get; set; }
    [Required]
    public required Genders Gender { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    [ForeignKey("Staff")]
    [Required]
    public required int StaffId { get; set; }
}
