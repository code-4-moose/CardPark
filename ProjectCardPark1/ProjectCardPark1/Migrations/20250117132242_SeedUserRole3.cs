using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2088), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2347), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2350), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2352), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2355), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2357), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2513), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2515), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2517), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2620), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2623), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2626), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2628), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2736), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2739), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2741), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2743), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2748), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2751), new DateTime(2025, 1, 17, 21, 22, 42, 7, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "ListingId", "Name", "RatingId", "Stars", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "Beautify Card!", 889988123, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Beautify Card!", 3, 9.5, null, 1 },
                    { 2, "Beautify Card!", 889966000, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Beautify Card!", 3, 9.5, null, 2 },
                    { 3, "Beautify Card!", 779966111, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Beautify Card!", 4, 8.5, null, 3 },
                    { 4, "Beautify Card!", 339968881, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Beautify Card!", 2, 5.5, null, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

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
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4109), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9746cbfd-71f9-4dc8-ad0e-a41aba905f84", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPJXARwXCif0ClHJCW+zyjXTVeEft/3FKr2hbxY9VQPc+g19ZmhbLjIINw81aP5jIg==", null, false, "1155ac0e-6fb0-4fe3-a695-0171a0369d7d", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4351), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4354), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4356), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4358), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4360), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4466), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4468), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4470), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4577), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4580), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4582), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4584), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4687), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4690), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4692), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4694), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4696), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4698), new DateTime(2025, 1, 17, 21, 14, 6, 842, DateTimeKind.Local).AddTicks(4698) });
        }
    }
}
