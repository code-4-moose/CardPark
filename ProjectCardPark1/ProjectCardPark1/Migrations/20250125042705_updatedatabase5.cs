using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ListingStatus",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(5948), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6164), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6167), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6169), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6171), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6172), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6270), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6272), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6274), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ListingStatus" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6372), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6372), null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ListingStatus" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6375), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6375), null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ListingStatus" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6377), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6377), null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ListingStatus" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6379), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6379), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6469), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6472), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6474), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6475), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6477), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6478), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6479) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListingStatus",
                table: "Listing");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(4759), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5023), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5027), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5029), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5031), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5033), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5181), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5185), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5187), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5292), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5295), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5298), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5300), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5401), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5406), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5408), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5412), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5413) });
        }
    }
}
