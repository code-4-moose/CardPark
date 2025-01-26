using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class database102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserIdentity",
                table: "Listing",
                newName: "UserName");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1624), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1861), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1865), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1867), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1868), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1870), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1980), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1982), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1984), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2077), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2081), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2085), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2204), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2207), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2208), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2210), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2212), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2214), new DateTime(2025, 1, 25, 22, 45, 30, 940, DateTimeKind.Local).AddTicks(2214) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Listing",
                newName: "UserIdentity");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1687), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1922), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1963), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1965), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1967), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1968), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2080), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2082), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2084), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2176), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2179), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2183), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2278), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2281), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2282), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2284), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2286), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2287), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2288) });
        }
    }
}
