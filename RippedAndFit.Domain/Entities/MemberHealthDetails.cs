using RippedAndFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RippedAndFit.Domain.Entities;

public class MemberHealthDetails
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required decimal Height { get; set; }
    [Required]
    public required decimal Weight { get; set; }
    [Required]
    public required FitnessGoal FitnessGoal { get; set; }
    [Required]
    public required ActivityLevel ActivityLevel { get; set; }
    [ForeignKey("Member")]
    [Required]
    public required int MemberId { get; set; }
}
