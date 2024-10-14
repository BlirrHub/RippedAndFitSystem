using RippedAndFit.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RippedAndFit.Domain.Entities;

public class MemberHealthDetails
{
    [Key]
    public int Id { get; set; }
    public required decimal Height { get; set; }
    public required decimal Weight { get; set; }
    public required FitnessGoal FitnessGoal { get; set; }
    public required ActivityLevel ActivityLevel { get; set; }
    [ForeignKey("Member")]
    public int MemberId { get; set; }
}
