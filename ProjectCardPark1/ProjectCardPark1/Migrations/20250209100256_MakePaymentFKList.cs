using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class MakePaymentFKList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Payment_UserId",
                table: "Payment");

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

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UserId",
                table: "Payment",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Payment_UserId",
                table: "Payment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "211d799d-1788-4073-8c83-2e047200352e", "AQAAAAIAAYagAAAAEJrFqjlrPMoibTrqiLXuc99iLvS87CQxA1iHkXDsfXbdoY6/cFNA6ps4+qRW5kh/fA==", "bd6b2945-df7a-48a0-a387-5a0ea640dc8f" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 35, 33, 640, DateTimeKind.Local).AddTicks(4683), new DateTime(2025, 2, 9, 15, 35, 33, 640, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 35, 33, 640, DateTimeKind.Local).AddTicks(4699), new DateTime(2025, 2, 9, 15, 35, 33, 640, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 35, 33, 640, DateTimeKind.Local).AddTicks(4702), new DateTime(2025, 2, 9, 15, 35, 33, 640, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UserId",
                table: "Payment",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }
    }
}
