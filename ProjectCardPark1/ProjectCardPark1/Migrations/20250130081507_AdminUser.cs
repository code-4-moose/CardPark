using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class AdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

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
                columns: new[] { "Address", "Name", "Stars", "UserId" },
                values: new object[] { "Nil", "Admin", 0.0, "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2618), new DateTime(2025, 1, 30, 16, 11, 6, 244, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdd48abb-d02e-42c8-93d6-18919550f56f", "AQAAAAIAAYagAAAAEIWtvfz4Fiom0wma1gY1GDMexK5JterkDcyRg2AiCk3aNT3ijVcZR2yigqKrKDrOzA==", "15f2542b-32cf-41aa-8e76-d435d12f1468" });

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Name", "Stars", "UserId" },
                values: new object[] { "Beautify Card!", "Beautify Card!", 9.5, "1" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "ListingId", "Name", "NoRatings", "ProfileImage", "ProfileImageUrl", "RatingId", "Stars", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 2, "Beautify Card!", 889966000, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Beautify Card!", null, null, null, 3, 9.5, null, "2" },
                    { 3, "Beautify Card!", 779966111, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Beautify Card!", null, null, null, 4, 8.5, null, "3" },
                    { 4, "Beautify Card!", 339968881, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Beautify Card!", null, null, null, 2, 5.5, null, "4" }
                });
        }
    }
}
