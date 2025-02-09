using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class Listing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0e37d35-ad25-4a61-8892-59456c69a9d8", "AQAAAAIAAYagAAAAEEgg1D3JtQXDGlIKU58MQ2QKJ4o1J6V1NKbjW6jnE2FUnEBhGeEe2FLPX2rIU1AM0g==", "926a2c1f-00ec-477b-9be3-94657c4531cb" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4181efe7-66dc-47f0-860f-e506d04102e5", 0, "fa9428e6-6cb3-489b-936e-9726116d2628", "amostan@gmail.com", true, "Amos", "Tan", false, null, "AMOSTAN@GMAIL.COM", "AMOSTAN@GMAIL.COM", "AQAAAAIAAYagAAAAEHhb9qg/CuClQggqEgwEh49N/65wyDwbsvrOaIGW0korkO7gLkRFC24pSX4nj430eA==", null, false, "94a64aba-2d08-4b4d-9763-4265cb752fe2", false, "amostan@gmail.com" },
                    { "5181efe8-31de-47f0-860f-e514d04102e5", 0, "f2400ec6-f98d-4b14-b90f-675042a150f1", "davidlee@gmail.com", true, "David", "Lee", false, null, "DAVIDLEE@GMAIL.COM", "DAVIDLEE@GMAIL.COM", "AQAAAAIAAYagAAAAEEczuzuCa5qBN9hIcNfFwZI3jBVhW5oWqIxt/nvBTPDzFY9QQud8IQZP1wPB7UzQBA==", null, false, "59341ec5-18e2-4c55-ba6b-a6d17ba7ba68", false, "davidlee@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3728), new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3746), new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3748), new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Type", "UpdatedBy" },
                values: new object[] { 4, 4, "System", new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3750), new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3750), "Others", "WhoKnows", "System" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "ListingId", "Name", "NoRatings", "ProfileImage", "ProfileImageUrl", "RatingId", "Stars", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 2, "Nil", 889988124, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Amos", 0, null, null, 4, 0.0, null, "4181efe7-66dc-47f0-860f-e506d04102e5" },
                    { 3, "Nil", 889988125, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "David", 0, null, null, 5, 0.0, null, "5181efe8-31de-47f0-860f-e514d04102e5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "4181efe7-66dc-47f0-860f-e506d04102e5" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5181efe8-31de-47f0-860f-e514d04102e5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "4181efe7-66dc-47f0-860f-e506d04102e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5181efe8-31de-47f0-860f-e514d04102e5" });

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4181efe7-66dc-47f0-860f-e506d04102e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5181efe8-31de-47f0-860f-e514d04102e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "810cbfce-aed6-4f37-ab10-fa69f3b7c5f0", "AQAAAAIAAYagAAAAEHMIVNPnUp+B+qK/W/N3kaNH/qG4vwdD5s4pU5Vj+0wM1vkbgF3pdXIwFsx/mkThpg==", "a380c2ca-ff43-4d6b-b455-b109c061ea84" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3593), new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3610), new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3612), new DateTime(2025, 2, 8, 18, 11, 19, 129, DateTimeKind.Local).AddTicks(3613) });
        }
    }
}
