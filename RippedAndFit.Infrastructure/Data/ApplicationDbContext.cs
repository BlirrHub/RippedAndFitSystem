using Microsoft.EntityFrameworkCore;
using RippedAndFit.Domain.Entities;
using RippedAndFit.Domain.Enums;

namespace RippedAndFit.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Staff> Staffs { get; set; }
    public DbSet<StaffDetails> StaffDetails { get; set; }
    public DbSet<Member> Member { get; set; }
    public DbSet<MemberDetails> MemberDetails { get; set; }
    public DbSet<MemberHealthDetails> MemberHealthDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Staff>().HasData(
            new Staff
            {
                Id = 1,
                Username = "admin",
                Password = "admin",
                Role = StaffRoles.Admin
            },

            new Staff
            {
                Id = 2,
                Username = "trainer",
                Password = "password",
                Role = StaffRoles.Trainer
            },

            new Staff
            {
                Id = 3,
                Username = "frontdesk",
                Password = "password",
                Role = StaffRoles.FrontDesk
            }
        );

        modelBuilder.Entity<Member>().HasData(
            new Member
            {
                Id = 1,
                Username = "dummy1",
                Password = "password",
                Status = MembershipStatus.Active,
            },

            new Member
            {
                Id = 2,
                Username = "dummy2",
                Password = "password",
                Status = MembershipStatus.Inactive,
            }
        );
    }
}
