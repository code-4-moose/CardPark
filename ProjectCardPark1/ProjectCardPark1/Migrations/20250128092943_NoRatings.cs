using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class NoRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoRatings",
                table: "Rating");

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
    }
}
