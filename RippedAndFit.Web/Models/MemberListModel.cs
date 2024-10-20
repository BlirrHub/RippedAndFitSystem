using RippedAndFit.Domain.Entities;

namespace RippedAndFit.Web.Models;

public class MemberListModel
{
    public required List<Users> Users { get; set; }
    public required List<MemberDetails> MemberDetails { get; set; }
}
