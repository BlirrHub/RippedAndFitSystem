using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class HashPasswordOfSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "trainer");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "frontdesk");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "member");
        }
    }
}
