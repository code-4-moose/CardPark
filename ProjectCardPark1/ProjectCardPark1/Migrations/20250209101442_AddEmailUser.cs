using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fad71df-8c12-4159-855f-8d025287fc0b", "AQAAAAIAAYagAAAAEN8KYWX7rLk6wfps4QE8eYHEk4T+sUtZEnlEAoJU0xEX0AXyk4Hwt83OpypzA5ytDQ==", "80d3b051-0321-46f1-8ffe-57c9b8c66045" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2852), new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2873), new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2875), new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1925863-e8de-4f32-b013-3eea1d3b1a73", "AQAAAAIAAYagAAAAEDdrmVjb7ikbkwQ64f9vzSabhXUe97o9d0k46BhfnzaIRqqZFzuE6ehOHXXdT8f0cg==", "d58bf4c0-76b9-4e16-b409-f4d459fc7d52" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 2, 56, 93, DateTimeKind.Local).AddTicks(3175), new DateTime(2025, 2, 9, 18, 2, 56, 93, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 2, 56, 93, DateTimeKind.Local).AddTicks(3191), new DateTime(2025, 2, 9, 18, 2, 56, 93, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 2, 56, 93, DateTimeKind.Local).AddTicks(3193), new DateTime(2025, 2, 9, 18, 2, 56, 93, DateTimeKind.Local).AddTicks(3194) });
        }
    }
}
