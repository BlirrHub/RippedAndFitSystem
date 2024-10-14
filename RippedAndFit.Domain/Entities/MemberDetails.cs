using RippedAndFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RippedAndFit.Domain.Entities;

public class MemberDetails
{
    [Key]
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    public required DateOnly DateOfBirth { get; set; }
    public required int Age { get; set; }
    public required Genders Gender { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public required MemberType MemberType { get; set; }
    [ForeignKey("Member")]
    public int MemberId { get; set; }
}
