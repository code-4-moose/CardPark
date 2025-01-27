using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class Category1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(2955), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3216), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3219), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3221), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3223), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3224), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3321), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3324), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3326), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3412), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3415), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3417), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3419), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3572), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3575), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3577), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3578), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3580), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3582), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3582) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Listing");

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
    }
}
