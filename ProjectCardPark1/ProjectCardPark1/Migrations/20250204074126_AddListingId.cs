using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class AddListingId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "ListingId",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1375), new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d073f7ab-cdb8-49a5-a4b6-6bb1221f8717", "AQAAAAIAAYagAAAAECbJO7ooTn5H5ThYEcRcjPSI9UNXOTC2EP75rF5z9V9Hps36PcLi3P6oARHiCrTVhQ==", "e04d8cb9-559e-4acb-917a-43757fd94c26" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1721), new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1724), new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1726), new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1728), new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1730), new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1852), new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1854), new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1856), new DateTime(2025, 2, 4, 15, 41, 25, 259, DateTimeKind.Local).AddTicks(1857) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListingId",
                table: "Rating");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9486), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6180512b-9726-4ea2-b37e-2cf7a9f1c014", "AQAAAAIAAYagAAAAEI8uMqPO2iIC2rM+S7Z9CW9tIz0gEye4e1+mWIVHo6PjMhhU9kNw9/oigEfYodM7Sw==", "d97190a6-c512-4720-9144-1e26277d3fe6" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9778), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9782), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9784), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9786), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9788), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9903), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9906), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9908), new DateTime(2025, 1, 31, 23, 13, 57, 383, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "RatingId", "ReviewerName", "Stars", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(19), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(20), "Beautify Card!", 1, null, 9.5, "System", 1 },
                    { 2, "System", new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(23), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(23), "Cards are damaged! Dishonesty!", 2, null, 3.0, "System", 2 },
                    { 3, "System", new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(25), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(26), "Will Trade again!", 3, null, 8.0, "System", 2 },
                    { 4, "System", new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(27), "Will NOT Trade again! Shame!", 4, null, 1.0, "System", 2 },
                    { 5, "System", new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(29), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(29), "Great! Never been so good!", 5, null, 8.9000000000000004, "System", 3 },
                    { 6, "System", new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(31), new DateTime(2025, 1, 31, 23, 13, 57, 384, DateTimeKind.Local).AddTicks(31), "Scary Trader!", 6, null, 0.0, "System", 3 }
                });
        }
    }
}
