using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class database101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listing_User_UserId1",
                table: "Listing");

            migrationBuilder.DropIndex(
                name: "IX_Listing_UserId1",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Listing");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Listing",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserIdentity",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1687), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1922), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1963), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1965), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1967), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1968), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2080), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2082), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2084), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "UserId", "UserIdentity" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2176), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2176), 1, null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "UserId", "UserIdentity" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2179), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2179), 1, null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "UserId", "UserIdentity" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2181), 1, null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "UserId", "UserIdentity" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2183), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2183), 2, null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2278), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2281), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2282), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2284), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2286), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2287), new DateTime(2025, 1, 25, 22, 13, 52, 802, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.CreateIndex(
                name: "IX_Listing_UserId",
                table: "Listing",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_User_UserId",
                table: "Listing",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listing_User_UserId",
                table: "Listing");

            migrationBuilder.DropIndex(
                name: "IX_Listing_UserId",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "UserIdentity",
                table: "Listing");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Listing",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6127), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6349), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6353), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6354), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6356), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6358), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6463), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6465), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6467), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "UserId", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6627), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6627), "1", null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "UserId", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6629), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6630), "1", null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "UserId", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6631), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6632), "1", null });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "UserId", "UserId1" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6633), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6634), "2", null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6739), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6742), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6743), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6745), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6747), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6749), new DateTime(2025, 1, 25, 21, 21, 48, 29, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.CreateIndex(
                name: "IX_Listing_UserId1",
                table: "Listing",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_User_UserId1",
                table: "Listing",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
