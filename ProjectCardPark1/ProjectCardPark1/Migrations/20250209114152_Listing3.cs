using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class Listing3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateCreated", "DateUpdated", "ListingImageUrl", "UserName" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 41, 51, 932, DateTimeKind.Local).AddTicks(3296), new DateTime(2025, 2, 9, 19, 41, 51, 932, DateTimeKind.Local).AddTicks(3312), "/Card_Images/Card_1.png", "David" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "DateUpdated", "ListingImageUrl", "UserName" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 35, 11, 800, DateTimeKind.Local).AddTicks(7888), new DateTime(2025, 2, 9, 19, 35, 11, 800, DateTimeKind.Local).AddTicks(7909), ".\\wwwroot\\Card Images\\Card 1.png", "David Lee" });
        }
    }
}
