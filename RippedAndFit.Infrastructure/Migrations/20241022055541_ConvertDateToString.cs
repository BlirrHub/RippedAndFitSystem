using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConvertDateToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEERZ8hpu7VGUNjOxxBLIujSdbfbxoaj+awoLMzCjTNTj7qSq4avbMw5ImVb585h9eg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAELKEsCpgsjLxKuDMgaBt7aPdRmGTwuYgI/hK5zyCjBQ2Pyfz38hL0gDAA/8SfWuOJQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEFfxDhK2bd1poeZn8iYt/46YVQNj6L2UU19QTl7h27peo7G2ce2BzPkVaI24OIeAYQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEGudMk0bpptICz1kN+Ork4mQdnc1z9NyiC9OzcoA/2Pim457ALjJQ4J35ogiTMJfaQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAENarI06Gmf4Q1KP335I1BvJDOn5QVJXkQDxrGukBm8++aRDYCDbudqvx01eDBJY84Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEH4+uMJgbTU1bfv8uKDFae22OBtmk8tcWpHs7AnYU+A3qgtX13svaW5of4poyK3Xkw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEBwU6tS17vfM8QbNwGob89M1vAjL9Jp2HIUogvzJpS+CDaqWg3u6gC+rtGKC92FbjA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAENHaMCw3ZyRfEwO5tvdzQtMpLbP5kyFpWkK6lao+67SC3aBLhK6Ewj/kKVnSUjFfcw==");
        }
    }
}
