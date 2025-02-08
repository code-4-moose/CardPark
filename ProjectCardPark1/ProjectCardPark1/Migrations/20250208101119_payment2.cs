using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class payment2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49d417f5-0926-47e9-ad1b-0a40491cfc59", "AQAAAAIAAYagAAAAEKsH7Qv0QFtdv2si+Fi1ddCd7BoBkdzPNO14oPVb4xtrVPlISRX92aIsSp26pVdG4Q==", "ab61561f-0b93-412e-bc33-fb181c52b6fb" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2463), new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2484), new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2485), new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2486) });
        }
    }
}
