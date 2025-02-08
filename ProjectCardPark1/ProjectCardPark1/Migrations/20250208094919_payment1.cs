using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark1.Migrations
{
    /// <inheritdoc />
    public partial class payment1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Payment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49d417f5-0926-47e9-ad1b-0a40491cfc59", "AQAAAAIAAYagAAAAEKsH7Qv0QFtdv2si+Fi1ddCd7BoBkdzPNO14oPVb4xtrVPlISRX92aIsSp26pVdG4Q==", "ab61561f-0b93-412e-bc33-fb181c52b6fb" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2463), new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2484), new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2485), new DateTime(2025, 2, 8, 17, 49, 18, 572, DateTimeKind.Local).AddTicks(2486) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentId",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

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
        }
    }
}
