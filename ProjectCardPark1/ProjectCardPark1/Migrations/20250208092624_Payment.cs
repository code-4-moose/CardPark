using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class Payment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Listing_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f8f8775-c73d-471a-994c-28fc98752eb4", "AQAAAAIAAYagAAAAEDRCtW/ejT59cUvNfXG3dqu7uigObOBDrnL1EkuywbWwp+HlqjCHCIH6rvI0HRiUrQ==", "64d494c0-c3cd-4462-99dc-42485f245d16" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 26, 23, 700, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 2, 8, 17, 26, 23, 700, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 26, 23, 700, DateTimeKind.Local).AddTicks(2099), new DateTime(2025, 2, 8, 17, 26, 23, 700, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 26, 23, 700, DateTimeKind.Local).AddTicks(2101), new DateTime(2025, 2, 8, 17, 26, 23, 700, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ListingId",
                table: "Payment",
                column: "ListingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UserId",
                table: "Payment",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f37c16b9-9645-438e-9b71-d20bb7ea72a8", "AQAAAAIAAYagAAAAEDuL2YW8ubR8QkOfX8mkPAbXtckd4+ZLg2CAYhGcq/LoajdqPhc9paPSJMjerkWdQA==", "35cf0245-87a2-45eb-9259-68d78b1b0a2b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5290), new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5305), new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5307), new DateTime(2025, 2, 5, 17, 16, 56, 452, DateTimeKind.Local).AddTicks(5308) });
        }
    }
}
