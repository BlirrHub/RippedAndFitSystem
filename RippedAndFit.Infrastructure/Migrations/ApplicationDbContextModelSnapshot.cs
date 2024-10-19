﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RippedAndFit.Infrastructure.Data;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("RippedAndFit.Domain.Entities.MemberDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("MemberId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MemberType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MembershipStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MemberDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 24,
                            DateOfBirth = new DateOnly(2000, 1, 1),
                            Email = "juancruz@gmail.com",
                            FirstName = "Juan",
                            Gender = 0,
                            LastName = "Cruz",
                            MemberId = 4,
                            MemberType = 0,
                            MembershipStatus = 0,
                            PhoneNumber = "09023517263"
                        });
                });

            modelBuilder.Entity("RippedAndFit.Domain.Entities.MemberHealthDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActivityLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FitnessGoal")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Height")
                        .HasColumnType("TEXT");

                    b.Property<int>("MemberId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MemberHealthDetails");
                });

            modelBuilder.Entity("RippedAndFit.Domain.Entities.StaffDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("StaffId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("StaffDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 0,
                            DateOfBirth = new DateOnly(2000, 1, 1),
                            Email = "",
                            FirstName = "",
                            Gender = 0,
                            LastName = "",
                            PhoneNumber = "",
                            StaffId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 0,
                            DateOfBirth = new DateOnly(2000, 1, 1),
                            Email = "",
                            FirstName = "frontdesk",
                            Gender = 0,
                            LastName = "",
                            PhoneNumber = "",
                            StaffId = 2
                        },
                        new
                        {
                            Id = 3,
                            Age = 0,
                            DateOfBirth = new DateOnly(2000, 1, 1),
                            Email = "",
                            FirstName = "trainer",
                            Gender = 0,
                            LastName = "",
                            PhoneNumber = "",
                            StaffId = 3
                        });
                });

            modelBuilder.Entity("RippedAndFit.Domain.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Password = "trainer",
                            Role = 2,
                            Username = "trainer"
                        },
                        new
                        {
                            Id = 3,
                            Password = "frontdesk",
                            Role = 1,
                            Username = "frontdesk"
                        },
                        new
                        {
                            Id = 4,
                            Password = "member",
                            Role = 3,
                            Username = "member"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
