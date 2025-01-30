using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class AdminRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7112), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e9e0d22-0c37-47fe-88b3-dad8390d0838", "AQAAAAIAAYagAAAAEHnTSI9n9a+7/bgBegxwb9eKw8NA7gNTHm48cSa7Akm/eytXGLTPhYXDr1CEKU6u1Q==", "b97c3d57-7701-4544-b781-f06530a322b9" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7441), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7444), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7447), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7449), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7451), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7569), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7572), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7575), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7679), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7682), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7684), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7686), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7688), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7691), new DateTime(2025, 1, 30, 16, 17, 2, 3, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "NoRatings",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(2221), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f7e59fe-2b20-4f36-98dd-5e080948cd34", "AQAAAAIAAYagAAAAEH39NcTxnuEhyz0PjtjqMYrEn0g22FTDDHGb8aLLYRwrK5swA9zPC4CoyzI/g6TrLw==", "d0d6edee-2790-4fae-90ea-71642607889f" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3042), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3047), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3050), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3053), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3056), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3251), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3260), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3263), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3463), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3470), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3473), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3476), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3480), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3482), new DateTime(2025, 1, 30, 16, 15, 5, 821, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "NoRatings",
                value: null);
        }
    }
}
