using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class Listing2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f5279bf-1d73-4957-abcc-7458e767046a", "AQAAAAIAAYagAAAAEKth3dbLZ1TExpDHYgueDRA/iT1ImNPqCsqXcrhhW7pKMgalI04rYe0TkE9HCvMgug==", "b7c4af8c-04ec-4f18-af79-49c84a09a8bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4181efe7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29919457-16b4-4f09-b00e-bbe8d0f52838", "AQAAAAIAAYagAAAAEOE5I5PIu0urV1IZM/+IYMNSKgrcgzHJGh2ZWBaleCZGG48VEu6fqtLJ8HsNF63nDg==", "d4734131-d78e-456c-8a90-e3a5dc3f3149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5181efe8-31de-47f0-860f-e514d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab61c50c-2fae-409b-ab7a-0cf88b749f8b", "AQAAAAIAAYagAAAAEJvSi52ax/bjp2hJBx+CRJbyftM0qNrvHfzRgAC0IQsI7pO4ocXI5opvu3TgwVnovw==", "dcf8a5a0-6dcb-42f4-98cc-591645fd3d13" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 35, 11, 657, DateTimeKind.Local).AddTicks(1751), new DateTime(2025, 2, 9, 19, 35, 11, 657, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 35, 11, 657, DateTimeKind.Local).AddTicks(1769), new DateTime(2025, 2, 9, 19, 35, 11, 657, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 35, 11, 657, DateTimeKind.Local).AddTicks(1771), new DateTime(2025, 2, 9, 19, 35, 11, 657, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 35, 11, 657, DateTimeKind.Local).AddTicks(1773), new DateTime(2025, 2, 9, 19, 35, 11, 657, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ListingImageUrl" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 35, 11, 800, DateTimeKind.Local).AddTicks(7888), new DateTime(2025, 2, 9, 19, 35, 11, 800, DateTimeKind.Local).AddTicks(7909), ".\\wwwroot\\Card Images\\Card 1.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8800528-1484-48b6-8f3e-4e6f44a718d2", "AQAAAAIAAYagAAAAEDBLKN17PjfePz6Jb3TaAxU46BugjF/7TTDMW/2ibiNnyIQqk0ISVr6U93uDjNDwsQ==", "5de35c5c-5afd-439f-8928-8ceb2bb2b030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4181efe7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3beee462-c58e-415f-8c45-bde25c3e366f", "AQAAAAIAAYagAAAAEEX6yeyt+bpaBEwnQ7+NeSdDy4zWfnCV5pCQdfggAT9ZuBI2gOAj+k0vOt11U5C/1w==", "f11ffb5c-cab4-4f78-80f7-4e2392757107" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5181efe8-31de-47f0-860f-e514d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df7e45ee-6bca-4594-94f1-eff2d73d0fb2", "AQAAAAIAAYagAAAAED5Idp2mGZizt3A7Yul3LOQp5ncSk4HbSRpKR7CDK/T2mVRkvcNYWABhkaW1N5rEtw==", "ee37fab2-88db-47a7-b08b-3f40b76940c0" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4168), new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4185), new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4187), new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4202), new DateTime(2025, 2, 9, 19, 31, 16, 375, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ListingImageUrl" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 16, 518, DateTimeKind.Local).AddTicks(4740), new DateTime(2025, 2, 9, 19, 31, 16, 518, DateTimeKind.Local).AddTicks(4760), null });
        }
    }
}
