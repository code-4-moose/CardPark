using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class AdminAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2618), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "cdd48abb-d02e-42c8-93d6-18919550f56f", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIWtvfz4Fiom0wma1gY1GDMexK5JterkDcyRg2AiCk3aNT3ijVcZR2yigqKrKDrOzA==", null, false, "15f2542b-32cf-41aa-8e76-d435d12f1468", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2934), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2939), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2941), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2943), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2945), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3072), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3074), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3077), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3192), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3195), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3197), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3199), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3201), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3203), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(3204) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(4310), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(7974), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8013), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8016), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8018), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8024), new DateTime(2025, 1, 30, 16, 1, 30, 375, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3534), new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3608), new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3611), new DateTime(2025, 1, 30, 16, 1, 30, 376, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1886), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1959), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1972), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1975), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1977), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1981), new DateTime(2025, 1, 30, 16, 1, 30, 377, DateTimeKind.Local).AddTicks(1982) });
        }
    }
}
