using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class listingss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60a24002-e042-4310-8490-e03a87e92195", "AQAAAAIAAYagAAAAEIJip9XNvAa5Ed/cbBRe3WhFhZDiCsfPN2Y0aNX+ooI8+1h68wBP67Lzsz77n3C19A==", "68ed50e7-6b23-447f-99b7-c9bcf8ca0032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4181efe7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31b959e2-2be8-4f89-b147-8369d8a11350", "AQAAAAIAAYagAAAAEMsJ9DY/zqDo0ejLpFLNBfoc1PaHl5FGvq0MYj5KYfBKLH3N60Rn340Bi2kyNUI/8Q==", "a0f1ee35-04b1-4a0f-8598-658640a8e5cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5181efe8-31de-47f0-860f-e514d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1dde3c1-e4ee-4aab-a041-722c11b02aca", "AQAAAAIAAYagAAAAEDQh06NWjDJdhMSsG9G7DRJ4l7Fz4ANYLQti93MxYGRwXijw/NVB63k/zLK2Qbh1/g==", "70b14be6-cdec-48d0-9a23-09cdd7d7ccb9" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 326, DateTimeKind.Local).AddTicks(9392), new DateTime(2025, 2, 9, 19, 57, 54, 326, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 326, DateTimeKind.Local).AddTicks(9409), new DateTime(2025, 2, 9, 19, 57, 54, 326, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 326, DateTimeKind.Local).AddTicks(9411), new DateTime(2025, 2, 9, 19, 57, 54, 326, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 326, DateTimeKind.Local).AddTicks(9413), new DateTime(2025, 2, 9, 19, 57, 54, 326, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7113), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.InsertData(
                table: "Listing",
                columns: new[] { "Id", "Amount", "CategoryId", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ListingId", "ListingImage", "ListingImageUrl", "ListingStatus", "Name", "Price", "Sold", "UpdatedBy", "UserId", "UserName" },
                values: new object[,]
                {
                    { 2, 3, 3, "Hololive", "5181efe8-31de-47f0-860f-e514d04102e5", new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7131), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7131), "Ina Card WAH!", 3, null, "/Card_Images/Card_2.png", null, "Ina Card", 1.0, null, "5181efe8-31de-47f0-860f-e514d04102e5", 3, "David" },
                    { 3, 1, 3, "Hololive", "4181efe7-66dc-47f0-860f-e506d04102e5", new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7133), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7134), "Kiara Rare Card!!!", 3, null, "/Card_Images/Card_3.png", null, "Kiara Oshi Card", 350.0, null, "4181efe7-66dc-47f0-860f-e506d04102e5", 2, "Amos" },
                    { 4, 5, 2, "Pokemon", "4181efe7-66dc-47f0-860f-e506d04102e5", new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7136), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7137), "Its an Eevee", 2, null, "/Card_Images/Card_4.png", null, "Eevee Card", 10.0, null, "4181efe7-66dc-47f0-860f-e506d04102e5", 2, "Amos" },
                    { 5, 1, 1, "Vanguard", "5181efe8-31de-47f0-860f-e514d04102e5", new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7138), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7139), "YOUTHBERK", 5, null, "/Card_Images/Card_5.png", null, "YOUTHBERK", 30.0, null, "5181efe8-31de-47f0-860f-e514d04102e5", 3, "David" },
                    { 6, 2, 1, "Vanguard", "4181efe7-66dc-47f0-860f-e506d04102e5", new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7141), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7141), "Shojodoji dojo yo", 6, null, "/Card_Images/Card_6.png", null, "Shojodoji", 5.0, null, "4181efe7-66dc-47f0-860f-e506d04102e5", 2, "Amos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51e5dcf6-d128-419b-b434-68cb47473b5c", "AQAAAAIAAYagAAAAEC978ufRGqjX01Ft6cvJaDxMy+3vmQsvdZb1Q/Op9/xkEz79yoNdkja8uAJroXEPaw==", "f3df4984-9b56-42a8-b66e-eda8ebd7ab9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4181efe7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d63e523-65d0-4c8f-9d9a-5a39ca2cdb43", "AQAAAAIAAYagAAAAEAi1pIDUcO9wmOL4AkRKY5NGS6RBdHkVi2JjaoUvcR2V5Rx0Nz/Za0FqrzQecqYHEQ==", "6a70a943-6806-4f53-9161-e3c367732465" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5181efe8-31de-47f0-860f-e514d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61a83258-0981-4ad8-bd9d-7a831b70f700", "AQAAAAIAAYagAAAAEGl1Y1Bc9pp44JECLN5XPShK+ZBPmTQZUYvDebMAkd4pTDhcrgibQbcagloOVl5Grg==", "ec9ec186-1697-47bb-88f7-6c79821aa09f" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 41, 51, 791, DateTimeKind.Local).AddTicks(717), new DateTime(2025, 2, 9, 19, 41, 51, 791, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 41, 51, 791, DateTimeKind.Local).AddTicks(736), new DateTime(2025, 2, 9, 19, 41, 51, 791, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 41, 51, 791, DateTimeKind.Local).AddTicks(738), new DateTime(2025, 2, 9, 19, 41, 51, 791, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 41, 51, 791, DateTimeKind.Local).AddTicks(739), new DateTime(2025, 2, 9, 19, 41, 51, 791, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 41, 51, 932, DateTimeKind.Local).AddTicks(3296), new DateTime(2025, 2, 9, 19, 41, 51, 932, DateTimeKind.Local).AddTicks(3312) });
        }
    }
}
