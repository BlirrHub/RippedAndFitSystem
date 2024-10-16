﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RippedAndFit.Infrastructure.Data;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241013070106_moreSeedingToStaff")]
    partial class moreSeedingToStaff
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("RippedAndFit.Domain.Entities.Staff", b =>
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

                    b.ToTable("Staffs");

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
                            Password = "password",
                            Role = 1,
                            Username = "JackyChan"
                        },
                        new
                        {
                            Id = 3,
                            Password = "Blaire123",
                            Role = 2,
                            Username = "Blirr"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
