using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateListingReserve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditCardNo",
                table: "User");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "567918c3-6626-487d-8fb4-e9109ad162de", "AQAAAAIAAYagAAAAEGRQEy5eB+orADzDtivOlGQgTpHnDXV6+B5CRRdtAyWjC94s5x/EBffP9o0+nE9jtg==", "642020a1-159d-4a46-ba75-4c73cf1bc71d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4181efe7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff128ec1-c2d7-4f70-bc54-69ded57e8ed9", "AQAAAAIAAYagAAAAEMAJ9k0UiBxCJ+kkW/Q4H4tlKvc8KT6+nHuvH6nNmkVyR8W1zvYd/yAUGs5Dcn3WWg==", "7e431a2c-5191-4092-8721-0ac1288bb775" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5181efe8-31de-47f0-860f-e514d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2a7facd-79ac-4a49-b57d-535de58e2aa5", "AQAAAAIAAYagAAAAEMkRFyiy+eX2tRoXqQRwEJqvG25ycADCVPhPdtBJmCb/Wk+JbtwdhSceog50L0nzAQ==", "58fd892f-ff65-4b3b-95a2-6004dba26fbe" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 488, DateTimeKind.Local).AddTicks(9160), new DateTime(2025, 2, 9, 20, 52, 2, 488, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 488, DateTimeKind.Local).AddTicks(9174), new DateTime(2025, 2, 9, 20, 52, 2, 488, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 488, DateTimeKind.Local).AddTicks(9176), new DateTime(2025, 2, 9, 20, 52, 2, 488, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 488, DateTimeKind.Local).AddTicks(9178), new DateTime(2025, 2, 9, 20, 52, 2, 488, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5715), new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5735), false });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5740), new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5741), false });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5743), new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5744), false });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5746), new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5747), false });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5749), new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5750), false });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5752), new DateTime(2025, 2, 9, 20, 52, 2, 642, DateTimeKind.Local).AddTicks(5752), false });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "admin@localhost.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "amostan@gmail.com");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "davidlee@gmail.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreditCardNo",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fad71df-8c12-4159-855f-8d025287fc0b", "AQAAAAIAAYagAAAAEN8KYWX7rLk6wfps4QE8eYHEk4T+sUtZEnlEAoJU0xEX0AXyk4Hwt83OpypzA5ytDQ==", "80d3b051-0321-46f1-8ffe-57c9b8c66045" });

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
                values: new object[] { new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2852), new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2873), new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2875), new DateTime(2025, 2, 9, 18, 14, 41, 938, DateTimeKind.Local).AddTicks(2876) });

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
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7113), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7128), null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7131), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7131), null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7133), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7134), null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7136), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7137), null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7138), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7139), null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "Reserved" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7141), new DateTime(2025, 2, 9, 19, 57, 54, 467, DateTimeKind.Local).AddTicks(7141), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreditCardNo", "Email" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreditCardNo", "Email" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreditCardNo", "Email" },
                values: new object[] { null, null });
        }
    }
}
