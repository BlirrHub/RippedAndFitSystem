using RippedAndFit.Domain.Enums;

namespace RippedAndFit.Domain.Entities;

public class Staff
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required StaffRoles Role { get; set; }
}
