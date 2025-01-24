using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class UserIdUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1107), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1418), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1420), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1423), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1424), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1426), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1562), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1565), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1566), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1660), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1663), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1665), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1667), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1760), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1763), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1765), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1767), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1769), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1771), new DateTime(2025, 1, 23, 19, 41, 7, 688, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(3685), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4082), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4085), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4088), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4091), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4093), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4241), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4244), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4247), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4374), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4378), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4381), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4384), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4524), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4528), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4530), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4533), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4535), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4538), new DateTime(2025, 1, 20, 17, 15, 20, 240, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: 4);
        }
    }
}
