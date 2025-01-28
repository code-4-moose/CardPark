using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class UserNoRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoRatings",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3672), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3924), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3928), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3930), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3932), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3934), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4206), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4209), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4211), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4324), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4326), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4328), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4331), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4332), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4334), new DateTime(2025, 1, 28, 17, 32, 22, 947, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "NoRatings",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "NoRatings",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "NoRatings",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "NoRatings",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoRatings",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1498), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1738), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1741), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1744), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1746), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1748), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1954), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1957), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1959), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2069), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2073), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2075), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2077), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2079), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2081), new DateTime(2025, 1, 28, 17, 31, 25, 646, DateTimeKind.Local).AddTicks(2082) });
        }
    }
}
