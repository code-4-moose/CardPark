using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminDBMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9286), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ca26d35-c2fe-46a7-8abc-70b48104dc78", "AQAAAAIAAYagAAAAEBIwFBqyB/LyaHY8ecbnNOvdSQK5K/k41I0RzcD9jHzWfL6gK8asG8slFrTCarXHIw==", "9cce76a4-1484-4ffa-b6aa-9330b0540f7f" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9688), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9692), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9694), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9696), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9698), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9832), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9835), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9837), new DateTime(2025, 1, 30, 17, 25, 56, 326, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(235), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(244), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(246), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(251), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(253), new DateTime(2025, 1, 30, 17, 25, 56, 327, DateTimeKind.Local).AddTicks(254) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
