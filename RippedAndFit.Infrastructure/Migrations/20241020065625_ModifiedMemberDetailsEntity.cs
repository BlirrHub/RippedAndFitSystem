using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedMemberDetailsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "MembershipDate",
                table: "MemberDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "MembershipDate",
                value: new DateOnly(2024, 10, 20));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEHIHIaUa9dNipaTBzFnSMNMIfbbg1GSzNSSC/AyuTtWFaaGhXrDxZ7D8x4oom7btvw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAECwxgSESJ10jIZnO0gZs6Whzof4ilpea6m1v/7eLdnpD4M92qFtKu1xS7LMtUUX+8w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEKd5+UNURjgnkwQfLfvLoCw/B1lqdn/1Jv3+vpw4vGYCmGf2M/NPJoXCutdjPsAZIw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEMjGMe6KuvOTWy4ARAdO7AQwTP5xSFCJ5r60HekBVuHmlGZdpUby690608DQ7TTS+w==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MembershipDate",
                table: "MemberDetails");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEHM37xoqiR5NtYNKpzbYJwVDn/LJb49Utz7HLHDyJyLmz+P7muP2OJcOwb0S8IAVRw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEBuRlHCrPDolVVm8N6jdRR0z6fHVe2730SQwzGUdTFztvmfDGPk5SZcOGnJO9FMiZA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEHvt5FfljpmTy2tmNJOViioGqQDM9zPcaR7Ac4FrqMx4ECPHZ9OxLXUO6QzQYTKyxw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEJTJZo4ljSy4Kzc5PkjVq8wvtVacq5yzOoTB7IiPIB8jAKa0vpEUbWa3MX40NTekOA==");
        }
    }
}
