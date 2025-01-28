using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDatabase281 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(1880), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2118), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2121), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2124), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2126), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2128), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2307), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2310), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2312), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2427), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2431), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2433), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2435), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2437), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2438), new DateTime(2025, 1, 28, 19, 26, 0, 682, DateTimeKind.Local).AddTicks(2439) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3672), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3924), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3928), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3930), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3932), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3934), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4206), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4209), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4211), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4324), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4326), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4328), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4331), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4332), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4334), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4335) });
        }
    }
}
