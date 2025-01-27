using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class categoryupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1639), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1914), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1917), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1919), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1921), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1923), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2110), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2113), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2115), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2227), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2229), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2231), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2233), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2235), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2236), new DateTime(2025, 1, 27, 20, 44, 38, 578, DateTimeKind.Local).AddTicks(2237) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Listing",
                columns: new[] { "Id", "AdminId", "Amount", "CategoryId", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ListingId", "ListingImage", "ListingImageUrl", "ListingStatus", "Name", "Price", "UpdatedBy", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, 1, 100, 1, null, "System", new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3412), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3413), null, 1, null, null, null, null, 5.21, "System", 1, null },
                    { 2, 1, 20, 2, null, "System", new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3415), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3415), null, 2, null, null, null, null, 1000.1, "System", 1, null },
                    { 3, 1, 10, 3, null, "System", new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3417), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3417), null, 3, null, null, null, null, 55.600000000000001, "System", 1, null },
                    { 4, 1, 8, 2, null, "System", new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3419), new DateTime(2025, 1, 27, 13, 40, 1, 801, DateTimeKind.Local).AddTicks(3419), null, 4, null, null, null, null, 23.399999999999999, "System", 2, null }
                });

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
    }
}
