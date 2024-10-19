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
                Password = "trainer",
                Role = Roles.Trainer
            },

            new Users
            {
                Id = 3,
                Username = "frontdesk",
                Password = "frontdesk",
                Role = Roles.FrontDesk
            },

            new Users
            {
                Id = 4,
                Username = "member",
                Password = "member",
                Role = Roles.Member
            }
        );

        modelBuilder.Entity<StaffDetails>().HasData(
            new StaffDetails
            {
                Id = 1,
                FirstName = "",
                LastName = "",
                DateOfBirth = new DateOnly(2000, 1, 1),
                Age = 0,
                Gender = Genders.Male,
                Email = "",
                PhoneNumber = "",
                StaffId = 1
            },

            new StaffDetails
            {
                Id = 2,
                FirstName = "frontdesk",
                LastName = "",
                DateOfBirth = new DateOnly(2000, 1, 1),
                Age = 0,
                Gender = Genders.Male,
                Email = "",
                PhoneNumber = "",
                StaffId = 2
            },

            new StaffDetails
            {
                Id = 3,
                FirstName = "trainer",
                LastName = "",
                DateOfBirth = new DateOnly(2000, 1, 1),
                Age = 0,
                Gender = Genders.Male,
                Email = "",
                PhoneNumber = "",
                StaffId = 3
            }
        );

        modelBuilder.Entity<MemberDetails>().HasData(
            new MemberDetails
            {
                Id = 1,
                FirstName = "Juan",
                LastName = "Cruz",
                DateOfBirth = new DateOnly(2000, 1, 1),
                Age = 24,
                Gender = Genders.Male,
                Email = "juancruz@gmail.com",
                PhoneNumber = "09023517263",
                MemberType = MemberType.Standard,
                MembershipStatus = MembershipStatus.Active,
                MemberId = 4
            }
        );
    }
}
