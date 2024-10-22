using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class StaffDetailBdayToDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEFkxQ+W0aJ6vcnqt0SGYrplh+99OiLKTrbBt0lVnIntIvSOyeDKsSdoUnyd4MwIppw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEN31Op/Svub7aGcEx/XH7tS/TJprTTB5+xV0M5FHB2foIWZZ409nDLO61PFxvT5lCg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEDM3qh0cu/fDMmQ7E537UC53uG6Y6xavQAlaJMuAohMmgi594vZDUprFn3zYJiiIww==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAECa0nWjYc1yNfZN1YMA3nzZi6kuu1z2XL77KKe0mZrdcgfUxsj2t9/r6Uy3dMZ7fTA==");
        }
    }
}
