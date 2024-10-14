using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "Password", "Status", "Username" },
                values: new object[,]
                {
                    { 1, "password", 0, "dummy1" },
                    { 2, "password", 1, "dummy2" }
                });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Username",
                value: "trainer");

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Username" },
                values: new object[] { "password", "frontdesk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "StaffDetails",
                columns: new[] { "Id", "Age", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "StaffId" },
                values: new object[,]
                {
                    { 1, 0, new DateOnly(2000, 1, 1), "", "", 2, "", null, 1 },
                    { 2, 70, new DateOnly(1954, 5, 7), "jackychan@gmail.com", "Jackie", 0, "Chan", null, 2 },
                    { 3, 20, new DateOnly(2003, 10, 28), "blairecyreldc@gmail.com", "Blaire Cyrel", 0, "Dela Cruz", null, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Username",
                value: "JackyChan");

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Username" },
                values: new object[] { "Blaire123", "Blirr" });
        }
    }
}
