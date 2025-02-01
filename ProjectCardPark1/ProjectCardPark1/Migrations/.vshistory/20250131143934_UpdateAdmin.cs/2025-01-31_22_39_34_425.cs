using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewerName",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Listing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListingId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Card_Listing_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "AdminId", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 1, 1, 12345678, "System", new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(2645), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(2658), "SuperBoss", "System" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b682ae-9e1d-442d-b2bb-b39edfb3fe1c", "AQAAAAIAAYagAAAAENyQUu60QMIyWK1rzydB0zaDZmqhGZdPErgsM1RjWKJEohkVryjLqOcK9iNDWIojIA==", "261e4a64-c1fd-4372-b4cf-230e1b59d033" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdminId", "DateCreated", "DateUpdated" },
                values: new object[] { 0, new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(2906), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdminId", "DateCreated", "DateUpdated" },
                values: new object[] { 0, new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(2908), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdminId", "DateCreated", "DateUpdated" },
                values: new object[] { 0, new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(2911), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3023), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3023), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3026), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3027), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3028), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3029), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3031), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3031), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3033), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3033), null });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3035), new DateTime(2025, 1, 31, 22, 39, 33, 640, DateTimeKind.Local).AddTicks(3035), null });

            migrationBuilder.CreateIndex(
                name: "IX_Listing_AdminId",
                table: "Listing",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_AdminId",
                table: "Category",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Card_ListingId",
                table: "Card",
                column: "ListingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Admin_AdminId",
                table: "Category",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_Admin_AdminId",
                table: "Listing",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Admin_AdminId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Listing_Admin_AdminId",
                table: "Listing");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropIndex(
                name: "IX_Listing_AdminId",
                table: "Listing");

            migrationBuilder.DropIndex(
                name: "IX_Category_AdminId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewerName",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7b06406-1273-4e41-9cda-045b2da86ab8", "AQAAAAIAAYagAAAAEIfISPF7jq5iEl1aX8QdjdLl103NTbLcGIA6p4ZpCOz71LLNNOzhEeowGE+QjIRydA==", "8f9b1236-65dd-40bf-9bdf-751ec1437aea" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8104), new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8156), new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8159), new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8460), new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8460), "John" });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8463), new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8463), "John" });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8465), new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8465), "John" });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8467), new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8467), "John" });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8469), new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8469), "John" });

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerName" },
                values: new object[] { new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8471), new DateTime(2025, 1, 31, 21, 55, 53, 753, DateTimeKind.Local).AddTicks(8472), "John" });
        }
    }
}
