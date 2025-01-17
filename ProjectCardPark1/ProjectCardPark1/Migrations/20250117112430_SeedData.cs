using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "AdminId", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 1, 1, 12345678, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7321), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7333), "SuperBoss", "System" });

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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "AdminId", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 1, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7648), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7649), "PG", "unknown", "System" },
                    { 2, 1, 2, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7650), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7651), "PG", "unknown", "System" },
                    { 3, 1, 3, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7652), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7653), "R18", "WhoKnows", "System" }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "RatingId", "Stars", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7869), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7870), "Beautify Card!", 1, 9.5, "System", 1 },
                    { 2, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7871), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7872), "Cards are damaged! Dishonesty!", 2, 3.0, "System", 2 },
                    { 3, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7874), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7874), "Will Trade again!", 3, 8.0, "System", 2 },
                    { 4, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7876), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7876), "Will NOT Trade again! Shame!", 4, 1.0, "System", 2 },
                    { 5, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7878), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7878), "Great! Never been so good!", 5, 8.9000000000000004, "System", 3 },
                    { 6, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7880), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7880), "Scary Trader!", 6, 0.0, "System", 3 }
                });

            migrationBuilder.InsertData(
                table: "Listing",
                columns: new[] { "Id", "AdminId", "Amount", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "ListingId", "Price", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 100, 1, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7747), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7748), 1, 5.21, "System", 1 },
                    { 2, 1, 20, 2, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7750), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7750), 2, 1000.1, "System", 1 },
                    { 3, 1, 10, 3, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7752), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7753), 3, 55.600000000000001, "System", 1 },
                    { 4, 1, 8, 2, "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7754), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7755), 4, 23.399999999999999, "System", 2 }
                });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "CardId", "Condition", "CreatedBy", "DateCreated", "DateUpdated", "ListingId", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "New", "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7534), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7535), 1, "Pokemon", "System" },
                    { 2, 2, "Old", "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7537), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7537), 1, "Ultraman", "System" },
                    { 3, 3, "Broken", "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7539), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7540), 2, "Wonderwoman", "System" },
                    { 4, 4, "New", "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7541), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7542), 3, null, "System" },
                    { 5, 5, "Stolen", "System", new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7543), new DateTime(2025, 1, 17, 19, 24, 30, 324, DateTimeKind.Local).AddTicks(7544), 3, "Aquaman", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
