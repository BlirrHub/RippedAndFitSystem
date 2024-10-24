﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RippedAndFit.Infrastructure.Data;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241022053608_AddedPrecisionToHeightAndWeight")]
    partial class AddedPrecisionToHeightAndWeight
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RippedAndFit.Domain.Entities.MemberDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("MemberType")
                        .HasColumnType("int");

                    b.Property<DateOnly>("MembershipDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("MembershipExpiration")
                        .HasColumnType("date");

                    b.Property<int>("MembershipStatus")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

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
                            MembershipDate = new DateOnly(2024, 10, 22),
                            MembershipExpiration = new DateOnly(2025, 10, 22),
                            MembershipStatus = 0,
                            PhoneNumber = "09023517263"
                        });
                });

            modelBuilder.Entity("RippedAndFit.Domain.Entities.MemberHealthDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivityLevel")
                        .HasColumnType("int");

                    b.Property<int>("FitnessGoal")
                        .HasColumnType("int");

                    b.Property<decimal>("Height")
                        .HasPrecision(10, 3)
                        .HasColumnType("decimal(10,3)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("MemberHealthDetails");
                });

            modelBuilder.Entity("RippedAndFit.Domain.Entities.StaffDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

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
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "AQAAAAIAAYagAAAAENarI06Gmf4Q1KP335I1BvJDOn5QVJXkQDxrGukBm8++aRDYCDbudqvx01eDBJY84Q==",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Password = "AQAAAAIAAYagAAAAEH4+uMJgbTU1bfv8uKDFae22OBtmk8tcWpHs7AnYU+A3qgtX13svaW5of4poyK3Xkw==",
                            Role = 2,
                            Username = "trainer"
                        },
                        new
                        {
                            Id = 3,
                            Password = "AQAAAAIAAYagAAAAEBwU6tS17vfM8QbNwGob89M1vAjL9Jp2HIUogvzJpS+CDaqWg3u6gC+rtGKC92FbjA==",
                            Role = 1,
                            Username = "frontdesk"
                        },
                        new
                        {
                            Id = 4,
                            Password = "AQAAAAIAAYagAAAAENHaMCw3ZyRfEwO5tvdzQtMpLbP5kyFpWkK6lao+67SC3aBLhK6Ewj/kKVnSUjFfcw==",
                            Role = 3,
                            Username = "member"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
