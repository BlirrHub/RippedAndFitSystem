using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    MemberType = table.Column<int>(type: "INTEGER", nullable: false),
                    MembershipStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    MemberId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberHealthDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Height = table.Column<decimal>(type: "TEXT", nullable: false),
                    Weight = table.Column<decimal>(type: "TEXT", nullable: false),
                    FitnessGoal = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivityLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    MemberId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberHealthDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    StaffId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MemberDetails",
                columns: new[] { "Id", "Age", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "MemberId", "MemberType", "MembershipStatus", "PhoneNumber" },
                values: new object[] { 1, 24, new DateOnly(2000, 1, 1), "juancruz@gmail.com", "Juan", 0, "Cruz", 4, 0, 0, "09023517263" });

            migrationBuilder.InsertData(
                table: "StaffDetails",
                columns: new[] { "Id", "Age", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "StaffId" },
                values: new object[,]
                {
                    { 1, 0, new DateOnly(2000, 1, 1), "", "", 0, "", "", 1 },
                    { 2, 0, new DateOnly(2000, 1, 1), "", "frontdesk", 0, "", "", 2 },
                    { 3, 0, new DateOnly(2000, 1, 1), "", "trainer", 0, "", "", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "admin", 0, "admin" },
                    { 2, "trainer", 2, "trainer" },
                    { 3, "frontdesk", 1, "frontdesk" },
                    { 4, "member", 3, "member" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberDetails");

            migrationBuilder.DropTable(
                name: "MemberHealthDetails");

            migrationBuilder.DropTable(
                name: "StaffDetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
