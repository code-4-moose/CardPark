using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileImageUrl",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(3685), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4082), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4085), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4088), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4091), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4093), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4241), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4244), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4247), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4374), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4378), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4381), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4384), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4524), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4528), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4530), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4533), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4535), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4538), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfileImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfileImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfileImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfileImageUrl",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImageUrl",
                table: "User");

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
    }
}
