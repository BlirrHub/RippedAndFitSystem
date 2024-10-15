using Microsoft.EntityFrameworkCore;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;

namespace RippedAndFit.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Users> Users { get; set; }
    public DbSet<StaffDetails> StaffDetails { get; set; }
    public DbSet<MemberDetails> MemberDetails { get; set; }
    public DbSet<MemberHealthDetails> MemberHealthDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Users>().HasData(
            new Users
            {
                Id = 1,
                Username = "admin",
                Password = "admin",
                Role = Roles.Admin
            },

            new Users
            {
                Id = 2,
                Username = "trainer",
                Password = "password",
                Role = Roles.Trainer
            },

            new Users
            {
                Id = 3,
                Username = "frontdesk",
                Password = "password",
                Role = Roles.FrontDesk
            },

            new Users
            {
                Id = 4,
                Username = "member",
                Password = "password",
                Role = Roles.Member
            }
        );
    }
}
