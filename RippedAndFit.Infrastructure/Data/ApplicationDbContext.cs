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
                Username = "JackyChan",
                Password = "password",
                Role = StaffRoles.Trainer
            },

            new Staff
            {
                Id = 3,
                Username = "Blirr",
                Password = "Blaire123",
                Role = StaffRoles.FrontDesk
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
                Gender = Genders.Other,
                Email = "",
                StaffId = 1,
            },

            new StaffDetails
            {
                Id = 2,
                FirstName = "Jackie",
                LastName = "Chan",
                DateOfBirth = new DateOnly(1954, 5, 7),
                Age = 70,
                Gender = Genders.Male,
                Email = "jackychan@gmail.com",
                StaffId = 2,
            },

            new StaffDetails
            {
                Id = 3,
                FirstName = "Blaire Cyrel",
                LastName = "Dela Cruz",
                DateOfBirth = new DateOnly(2003, 10, 28),
                Age = 20,
                Gender = Genders.Male,
                Email = "blairecyreldc@gmail.com",
                StaffId = 3,
            }
        );
    }
}
