using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConvertBdayToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
