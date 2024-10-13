using Microsoft.EntityFrameworkCore;
using RippedAndFit.Domain.Entities;

namespace RippedAndFit.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Staff> Staffs { get; set; }
}
