using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedDateOnlyConverter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "MembershipDate", "MembershipExpiration" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEC8aZdGzYazQjKhnXFzIxjKCKLH1kaaBXu2jryq+h3JgKRanYiHtA75c35rXeF8B7Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEAFycO2fg6bS9Lpt/f5FTYuqFPvEPpXefg2dk7ylAnY/KnlscGfPGoiYCKo3dDZ3ig==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEGlQpGKY7Vec+1dH78/W2ps+Kwa0CvVSDcujtw7t0nnSxR6TVNvcWzxRhQ/GhVIR0A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEG8tBnOgdxxnpHOCyIoFpM9OJXPAQGLuLNBVn6w4lJCqqZxw1v5CIBXcTKqL93msyw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "MembershipDate", "MembershipExpiration" },
                values: new object[] { new DateOnly(2000, 1, 1), new DateOnly(2024, 10, 22), new DateOnly(2025, 10, 22) });

            migrationBuilder.UpdateData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateOnly(2000, 1, 1));

            migrationBuilder.UpdateData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateOnly(2000, 1, 1));

            migrationBuilder.UpdateData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateOnly(2000, 1, 1));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEFp4J5JEgufqO/s92ssV8ESO9+M02OHI4Zd+YxAjRq+prhIMF4vskBwnpIaFRYJ7dA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEIfRKhlwzG59ULZDl7mobwxfMDKs4IA5C7yHuvSjcmrQwMGTFH+dKad2D7e0DFguMQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEG/cqwWL+H4pk2cNTwef0EjVT0Knqc6ndmPDqczaJ8M/uPslfZaNYBa8jQ4aF3giNQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEI+MN0NFm4bc0Al2KPR35vOBWp5FrAoONyWPdRl0KBnVrAOS+xIlcboFXxBgptmyPw==");
        }
    }
}
