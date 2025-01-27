using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class yes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listing_User_UserId",
                table: "Listing");

            migrationBuilder.DropIndex(
                name: "IX_Listing_UserId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(4715), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5011), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5015), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5017), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5019), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5020), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5159), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5162), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5164), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5270), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5270), 1 });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5273), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5274), 1 });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5276), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5276), 1 });

            migrationBuilder.UpdateData(
                table: "Listing",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5278), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5278), 2 });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5397), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5402), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5405), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5407), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5408), new DateTime(2025, 1, 25, 20, 56, 12, 730, DateTimeKind.Local).AddTicks(5409) });

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
    }
}
