using RippedAndFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RippedAndFit.Domain.Entities;

public class MemberDetails
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
    [EmailAddress]
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    [Required]
    public required MemberType MemberType { get; set; }
    [Required]
    public required MembershipStatus MembershipStatus { get; set; }
    [ForeignKey("Member")]
    [Required]
    public required int MemberId { get; set; }
}
