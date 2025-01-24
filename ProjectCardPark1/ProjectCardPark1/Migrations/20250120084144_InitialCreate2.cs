using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(1751), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2179), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2183), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2186), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2188), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2191), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2413), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2416), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2419), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2554), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2557), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2560), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2563), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2729), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2735), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2738), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2740), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2743), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2745), new DateTime(2025, 1, 20, 16, 41, 43, 532, DateTimeKind.Local).AddTicks(2746) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(7984), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8403), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8407), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8410), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8414), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8417), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8805), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8810), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8813), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8956), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8960), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8964), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8968), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9111), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9115), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9119), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9122), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9126), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9129), new DateTime(2025, 1, 20, 15, 48, 54, 523, DateTimeKind.Local).AddTicks(9130) });
        }
    }
}
