using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class RemoveNoRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoRatings",
                table: "Rating");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1498), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1738), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1741), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1744), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1746), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1748), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1954), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1957), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1959), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2069), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2073), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2075), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2077), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2079), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2081), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2082) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoRatings",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9557), new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9780), new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9783), new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9785), new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9787), new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9789), new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9907), new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9911), new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9913), new DateTime(2025, 1, 28, 17, 29, 42, 484, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "NoRatings" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(5), new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(6), 0 });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "NoRatings" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(8), new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(9), 0 });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "NoRatings" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(10), new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(11), 0 });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "NoRatings" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(12), new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(12), 0 });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "NoRatings" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(14), new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(14), 0 });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "NoRatings" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(16), new DateTime(2025, 1, 28, 17, 29, 42, 485, DateTimeKind.Local).AddTicks(16), 0 });
        }
    }
}
