using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfileImage",
                table: "User",
                type: "varbinary(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfileImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfileImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfileImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfileImage",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1380), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6ea0f791-5c75-4491-8758-556fdb282862", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPgEenTlbfChSB5EjbL63Qy5vKpUGH+ggEqs1gxqnFNRHuwHwdYXmz5T2QD/ObZy4g==", null, false, "08a59c9d-d509-4f4e-8288-382aaff6df35", false, "admin@localhost.com" });

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
        }
    }
}
