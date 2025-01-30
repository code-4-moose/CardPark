upusing System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class RestartDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(4310), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(7974), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8013), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8016), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8018), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8024), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3534), new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3608), new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3611), new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1886), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1959), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1972), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1975), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1977), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1981), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1982) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
