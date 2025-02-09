using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class Reserved_CreditCardNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreditCardNo",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Reserved",
                table: "Listing",
                type: "bit",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreditCardNo",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditCardNo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Reserved",
                table: "Listing");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "810cbfce-aed6-4f37-ab10-fa69f3b7c5f0", "AQAAAAIAAYagAAAAEHMIVNPnUp+B+qK/W/N3kaNH/qG4vwdD5s4pU5Vj+0wM1vkbgF3pdXIwFsx/mkThpg==", "a380c2ca-ff43-4d6b-b455-b109c061ea84" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3593), new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3610), new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3612), new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3613) });
        }
    }
}
