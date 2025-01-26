using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class listings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(4715), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5011), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5015), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5017), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5019), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5020), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5159), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5162), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5164), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Description", "Name" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5270), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5270), null, null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Description", "Name" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5273), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5274), null, null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Description", "Name" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5276), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5276), null, null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Description", "Name" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5278), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5278), null, null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5397), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5402), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5405), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5407), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5408), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5409) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Listing");

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6372), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6375), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6377), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6379), new DateTime(2025, 1, 25, 12, 27, 5, 10, DateTimeKind.Local).AddTicks(6379) });

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
    }
}
