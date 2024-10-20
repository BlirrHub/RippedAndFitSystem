using RippedAndFit.Domain.Entities;

namespace RippedAndFit.Web.Models;

public class StaffModel
{
    public required Users User { get; set; }
    public required StaffDetails StaffDetails { get; set; }
}
