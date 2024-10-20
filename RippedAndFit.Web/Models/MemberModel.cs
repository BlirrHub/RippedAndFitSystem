using RippedAndFit.Domain.Entities;

namespace RippedAndFit.Web.Models;

public class MemberModel
{
    public required Users User { get; set; }
    public required MemberDetails MemberDetails { get; set; }
}
