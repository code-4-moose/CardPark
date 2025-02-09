using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class listing1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Listing",
                columns: new[] { "Id", "Amount", "CategoryId", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ListingId", "ListingImage", "ListingImageUrl", "ListingStatus", "Name", "Price", "Sold", "UpdatedBy", "UserId", "UserName" },
                values: new object[] { 1, 1, 3, "Hololive", "5181efe8-31de-47f0-860f-e514d04102e5", new DateTime(2025, 2, 9, 19, 31, 16, 518, DateTimeKind.Local).AddTicks(4740), new DateTime(2025, 2, 9, 19, 31, 16, 518, DateTimeKind.Local).AddTicks(4760), "Suisei Oshi Card", 3, null, null, null, "Suisei OSR", 3.0, null, "5181efe8-31de-47f0-860f-e514d04102e5", 3, "David Lee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0e37d35-ad25-4a61-8892-59456c69a9d8", "AQAAAAIAAYagAAAAEEgg1D3JtQXDGlIKU58MQ2QKJ4o1J6V1NKbjW6jnE2FUnEBhGeEe2FLPX2rIU1AM0g==", "926a2c1f-00ec-477b-9be3-94657c4531cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4181efe7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa9428e6-6cb3-489b-936e-9726116d2628", "AQAAAAIAAYagAAAAEHhb9qg/CuClQggqEgwEh49N/65wyDwbsvrOaIGW0korkO7gLkRFC24pSX4nj430eA==", "94a64aba-2d08-4b4d-9763-4265cb752fe2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5181efe8-31de-47f0-860f-e514d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2400ec6-f98d-4b14-b90f-675042a150f1", "AQAAAAIAAYagAAAAEEczuzuCa5qBN9hIcNfFwZI3jBVhW5oWqIxt/nvBTPDzFY9QQud8IQZP1wPB7UzQBA==", "59341ec5-18e2-4c55-ba6b-a6d17ba7ba68" });

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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3750), new DateTime(2025, 2, 9, 19, 12, 55, 977, DateTimeKind.Local).AddTicks(3750) });
        }
    }
}
