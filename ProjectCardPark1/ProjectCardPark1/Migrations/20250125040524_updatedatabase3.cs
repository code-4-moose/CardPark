using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ListingImage",
                table: "Listing",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ListingImageUrl",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "DateCreated", "DateUpdated", "ListingImage", "ListingImageUrl" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5292), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5293), null, null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ListingImage", "ListingImageUrl" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5295), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5296), null, null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ListingImage", "ListingImageUrl" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5298), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5298), null, null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ListingImage", "ListingImageUrl" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5300), new DateTime(2025, 1, 25, 12, 5, 24, 324, DateTimeKind.Local).AddTicks(5301), null, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListingImage",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "ListingImageUrl",
                table: "Listing");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1107), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1418), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1420), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1423), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1424), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1426), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1562), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1565), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1566), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1660), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1663), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1665), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1667), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1760), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1763), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1765), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1767), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1769), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1771), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1771) });
        }
    }
}
