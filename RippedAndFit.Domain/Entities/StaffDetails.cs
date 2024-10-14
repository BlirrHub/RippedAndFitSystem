using RippedAndFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RippedAndFit.Domain.Entities;

public class StaffDetails
{
    [Key]
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public int Age { get; set; }
    public Genders Gender { get; set; }
    public string? Email { get; set; }
    [ForeignKey("Staff")]
    public int StaffId { get; set; }
}
