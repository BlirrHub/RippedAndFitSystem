using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RippedAndFit.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AzureInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MembershipDate", "MembershipExpiration" },
                values: new object[] { new DateOnly(2024, 10, 22), new DateOnly(2025, 10, 22) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAELcJp0yVrZGRdq2V8g44AnBfKtOn34BfZ4UrmBJPKf2D48A1xqC+SFW2eUFF9FlnHw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEHzFbJFgvxql1scqHr9xJvKxjR/q08FLsmM+T8ymMHTDAx52BV7J1duH5NE+8zn0dw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEGoAJ2TLv0IGwjkcP3QQWaTaW/AsZrtKoQgxDqtN7Wi9fx5pcG4Jo/gl79uUKv3gZA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEJODnLfu1uXAuSWKYg9sLb7Pbku+8rOVHiF6Am9QWLtSV1Vq0OmVlhSuRzQovVeRAg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MembershipDate", "MembershipExpiration" },
                values: new object[] { new DateOnly(2024, 10, 20), new DateOnly(2025, 10, 20) });

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
    }
}
