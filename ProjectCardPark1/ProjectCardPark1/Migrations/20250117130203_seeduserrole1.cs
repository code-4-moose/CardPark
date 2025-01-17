using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class seeduserrole1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1380), new DateTime(2025, 1, 17, 21, 2, 2, 250, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2267), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2533), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2536), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2539), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2540), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2542), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2651), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2653), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2656), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2773), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2777), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2779), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2781), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2908), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2912), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2914), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2916), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2918), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2919), new DateTime(2025, 1, 17, 20, 27, 36, 798, DateTimeKind.Local).AddTicks(2920) });
        }
    }
}
