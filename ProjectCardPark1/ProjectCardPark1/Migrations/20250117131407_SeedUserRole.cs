using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9746cbfd-71f9-4dc8-ad0e-a41aba905f84", "AQAAAAIAAYagAAAAEPJXARwXCif0ClHJCW+zyjXTVeEft/3FKr2hbxY9VQPc+g19ZmhbLjIINw81aP5jIg==", "1155ac0e-6fb0-4fe3-a695-0171a0369d7d" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1380), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ea0f791-5c75-4491-8758-556fdb282862", "AQAAAAIAAYagAAAAEPgEenTlbfChSB5EjbL63Qy5vKpUGH+ggEqs1gxqnFNRHuwHwdYXmz5T2QD/ObZy4g==", "08a59c9d-d509-4f4e-8288-382aaff6df35" });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1681), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1684), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1686), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1689), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1691), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1813), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1816), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1818), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1918), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1921), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1923), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1925), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2029), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2034), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2036), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2038), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2040), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2042), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(2043) });

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
    }
}
