using RippedAndFit.Domain.Entities;

namespace RippedAndFit.Web.Models;

public class AdministrationDataModel
{
    public required Users user { get; set; }
    public required List<Users> users { get; set; }
}
