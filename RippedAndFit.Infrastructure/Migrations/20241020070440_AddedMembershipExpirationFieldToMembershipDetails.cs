using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedMembershipExpirationFieldToMembershipDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "MembershipExpiration",
                table: "MemberDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "MembershipExpiration",
                value: new DateOnly(2025, 10, 20));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEDJMcXU954KvVy/fNEhY691iD1eL+IiIkUsuPZ3+Ofv72+LfY+XkqJ6XQFzFgjVHLw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEHpEDA4hzxMhn9IA6KVIBUl2ULQJ+hwdJM2D37guuA+REybKroFit3l6ukaVhCeMcA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEDEmcSjWD5rXc327a53fU4L2vYJZmMUoPcNM3CjbeFVKs9kMKz0dqkWE8bGHy+13mw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEKVMPSOMfyMHy3AkYDjFtqw1elMB8TDEsFQDfg2l5/UDKpeI4H4QnwJu9ug2oCfKnw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MembershipExpiration",
                table: "MemberDetails");

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
    }
}
